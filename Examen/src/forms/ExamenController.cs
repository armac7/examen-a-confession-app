using Examen.src.forms;
using Examen;
using System.Diagnostics.Eventing.Reader;

namespace Examen
{
    public partial class ExamenController : Form
    {
        // Data object to hold examination state
        ExamenData _data;
        bool firstExamen = true;

        // Interface objects for managing stages
        IStageManager examManager = new StageManager<ExaminationForm>();
        IStageManager customizationManager = new StageManager<CustomizeForm>();
        IStageManager prayerManager = new StageManager<PrayerForm>();
        IStageManager confessionManager = new StageManager<ConfessionForm>();

        public ExamenController()
        {
            InitializeComponent();
            _data = new ExamenData();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();

        }

        private void confessButton_Click_1(object sender, EventArgs e)
        {
            // if first time pressed, just run exam

            // if this is the first examination
            if (firstExamen)
            {
                this.Hide();
                examManager.Run(_data);

                // if user decides to quit during exam, exit app
                if (_data.Quit)
                {
                    Application.Exit();
                    return;
                }

                // if no sins selected, inform user and return to main menu
                if ((_data.SelectedSins == null || _data.SelectedSins.Count == 0))
                {
                    MessageBox.Show("No sins were selected. Returning to main menu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    firstExamen = true;
                    this.Show();
                    return;
                }


                // if sins are selected, run customization
                customizationManager.Run(_data);
                firstExamen = false;
            }
            else // else confirm with user to start new exam
            {
                DialogResult result = MessageBox.Show("Are you sure you want to start a new examination? \nNOTE: Your previous selections will be lost.", "Confirm New Examination", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _data = new ExamenData(); // Reset data
                    firstExamen = true;
                    this.Hide();
                    examManager.Run(_data);
                } // end of if
                else
                {
                    this.Show();
                    return;
                } // end of else
            } // end of else


            RunPrayerIfNeeded();
            RunConfession();
        } /* end of confessButton_Click_1 */

        // helper function for confessionButton_Click_1
        private void RunPrayerIfNeeded()
        {
            if (!_data.AddPrayer)
                return;

            // if a prayer has not already been selected
            if (_data.SelectedPrayer == null || _data.SelectedPrayer == "")
                prayerManager.Run(_data);
            else // if a prayer has already been selected
            {
                DialogResult prayerConfirm = MessageBox.Show("Would you like to choose a different prayer?", "Confirm Prayer Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (prayerConfirm == DialogResult.Yes)
                    prayerManager.Run(_data);
            }

            // if prayer form is closed and no prayer selected
            if (_data.SelectedPrayer == null)
                _data.AddPrayer = false; // User did not select a prayer
        }

        // helper function for confessionButton_Click_1
        private void RunConfession()
        {
            confessionManager.Run(_data);

            if (_data.Quit)
                Application.Exit();
            else if (_data.Reset)
            {
                _data = new ExamenData();
                firstExamen = true;
                this.Show();
            }
        }

        private void prayersButton_Click(object sender, EventArgs e)
        {
            prayerManager.Run(_data);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            this.Hide();
            helpForm.ShowDialog();
            this.Show();
        }
    } /* end of ExamenController class */

    public interface IStageManager 
    {
        ExamenData Run(ExamenData input);
    }

    public class StageManager<T> : IStageManager where T : Form
    {
        public ExamenData Run(ExamenData input)
        {
            using (var form = (T)Activator.CreateInstance(typeof(T), input))
            {
                form.ShowDialog();
            }
            return input;
        }
    }


}
