using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examen
{
    public partial class ExaminationForm : Form
    {
        int currCategory = 0;
        ExamenData _data;
        SinsManager _sinsManager;

        List<Sins> selectedSins = new List<Sins>();
        List<FlowLayoutPanel> _categoryPanels = new List<FlowLayoutPanel>();
        List<FlowLayoutPanel> _sinsPanels = new List<FlowLayoutPanel>();

        public ExaminationForm(ExamenData data)
        {
            InitializeComponent();
            _data = data;
            _sinsManager = new SinsManager();

            // create commandment panels
            int sinID = 1;
            for (int i = 0; i < 10; i++)
            {
                FlowLayoutPanel categoryPanel = new FlowLayoutPanel();
                categoryPanel.Name = $"categoryPanel{i + 1}";
                categoryPanel.Dock = DockStyle.Fill;       
                categoryPanel.FlowDirection = FlowDirection.TopDown;
                categoryPanel.WrapContents = false;          
                categoryPanel.AutoScroll = true;           
                categoryPanel.Visible = (i == 0);
                categoryPanel.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);

                // Handle resize to adjust children widths
                categoryPanel.Resize += (s, ev) =>
                {
                    foreach (FlowLayoutPanel sinPanel in categoryPanel.Controls.OfType<FlowLayoutPanel>())
                    {
                        sinPanel.Width = categoryPanel.ClientSize.Width - categoryPanel.Padding.Horizontal;
                        sinPanel.PerformLayout();
                    }
                };

                _categoryPanels.Add(categoryPanel);
                commandmentsPanel.Controls.Add(categoryPanel);

                // create sin panels for each commandment
                while (sinID < _sinsManager.numberOfSins())
                {
                    // gets the current sin from sinManager
                    Sins? sin = _sinsManager.searchID(sinID);
                    // if sin doesn't exist or the commandment isn't the same
                    if (sin == null || sin.Commandment != i + 1)
                        break; // Move to the next commandment


                    // creates the panel for the sin
                    FlowLayoutPanel sinPanel = new FlowLayoutPanel();
                    sinPanel.Name = $"sinPanel{sin.SinsID}";
                    sinPanel.BorderStyle = BorderStyle.FixedSingle;
                    sinPanel.AutoSize = true;
                    sinPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    sinPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    sinPanel.Width = categoryPanel.ClientSize.Width - categoryPanel.Padding.Horizontal;


                    // creates the controls for each sin
                    // checkbox for the sin
                    CheckBox sinCB = new CheckBox();
                    sinCB.Text = sin.Sin;
                    sinCB.AutoSize = true;      // height adjusts automatically
                    sinCB.Dock = DockStyle.Top; 
                    //sinCB.Name = $"sinCheckBox{sin.SinsID}";

                    // checkbox if it is mortal
                    CheckBox mortalCB = new CheckBox();
                    mortalCB.Name = $"mortalCheckBox{sin.SinsID}";
                    mortalCB.Text = "Mortal?";

                    // label and textbox for how many times
                    Label label = new Label();
                    label.Text = "How many times?";
                    label.AutoSize = true;
                    TextBox textBox = new TextBox();
                    textBox.Name = $"timesIn{sin.SinsID}";
                    textBox.Text = "1";

                    // datepicker for when
                    DateTimePicker datePicker = new DateTimePicker();
                    datePicker.Name = $"date{sin.SinsID}";
                    datePicker.Format = DateTimePickerFormat.Short;
                    datePicker.Value = DateTime.Today;

                    // adds the controls to the sin panel
                    sinPanel.Controls.Add(sinCB);
                    sinPanel.Controls.Add(mortalCB);
                    sinPanel.Controls.Add(label);
                    sinPanel.Controls.Add(textBox);
                    sinPanel.Controls.Add(datePicker);

                    // hides all except the sin itself
                    mortalCB.Visible = false;
                    label.Visible = false;
                    textBox.Visible = false;
                    datePicker.Visible = false;

                    // enables the visibility of the mortal checkbox when the sin checkbox is checked
                    sinCB.CheckedChanged += (s, e) =>
                    {
                        bool isChecked = sinCB.Checked;

                        // adds or removes the sin from the selectedSins list
                        if (isChecked)
                            selectedSins.Add(sin);
                        else
                            selectedSins.Remove(sin);

                        mortalCB.Visible = isChecked;
                        mortalCB.Checked = false; // reset mortal checkbox
                    };

                    // enables the visibility of the label, textbox and datepicker when the mortal checkbox is checked
                    mortalCB.CheckedChanged += (s, e) =>
                    {
                        bool isMortal = mortalCB.Checked;

                        label.Visible = isMortal;
                        textBox.Visible = isMortal;
                        datePicker.Visible = isMortal;
                    };

                    // add controls to the panel and lists of panels.
                    categoryPanel.Controls.Add(sinPanel);
                    _sinsPanels.Add(sinPanel);

                    // increment the sinID.
                    sinID++;
                } // end of while loop



            } // end of for loop
        } // end of constructor

        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _data.Quit = true;
                this.DialogResult = DialogResult.Cancel;
            }
        }

        // clears all items on the current panel
        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear the current commandment?", "Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // for each sinPanel in current commandment panel, clear all controls
                foreach (FlowLayoutPanel sinPanel in _categoryPanels[currCategory].Controls.OfType<FlowLayoutPanel>())
                {
                    foreach (CheckBox cb in sinPanel.Controls.OfType<CheckBox>())
                        cb.Checked = false;
                    foreach (TextBox tb in sinPanel.Controls.OfType<TextBox>())
                        tb.Text = "1";
                    foreach (DateTimePicker dtp in sinPanel.Controls.OfType<DateTimePicker>())
                        dtp.Value = DateTime.Today;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to restart your examination?", "Reset?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // for each commandPanel in categoryPanels, sinPanel in commandPanel, clear all controls
                foreach (FlowLayoutPanel commandPanel in _categoryPanels)
                    foreach (FlowLayoutPanel sinPanel in commandPanel.Controls.OfType<FlowLayoutPanel>())
                    {
                        foreach (CheckBox cb in sinPanel.Controls.OfType<CheckBox>())
                            cb.Checked = false;
                        foreach (TextBox tb in sinPanel.Controls.OfType<TextBox>())
                            tb.Text = "1";
                        foreach (DateTimePicker dtp in sinPanel.Controls.OfType<DateTimePicker>())
                            dtp.Value = DateTime.Today;
                    }
            }
        }

        private void confessButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to submit your examination?", "Submit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // for each selected sin, get the values from the controls and set them in the sin object
                foreach (Sins sin in selectedSins)
                {
                    // grabs the sin panel that shares the same ID as the sin
                    FlowLayoutPanel? sinPanel = _sinsPanels.FirstOrDefault(sp => sp.Name == $"sinPanel{sin.SinsID}");
                    // if found, get the values from the controls
                    if (sinPanel != null)
                    {
                        // checks to see if the controls were checked/filled and sets the sin object values
                        CheckBox? mortalCB = sinPanel.Controls.OfType<CheckBox>().FirstOrDefault(cb => cb.Name == $"mortalCheckBox{sin.SinsID}");
                        TextBox? timesTB = sinPanel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"timesIn{sin.SinsID}");
                        DateTimePicker? datePicker = sinPanel.Controls.OfType<DateTimePicker>().FirstOrDefault(dp => dp.Name == $"date{sin.SinsID}");
                        
                        if (mortalCB != null)
                            sin.Mortal = mortalCB.Checked;
                        if (timesTB != null)
                        {
                            if (int.TryParse(timesTB.Text, out int numTimes))
                                sin.NumTimes = numTimes;
                            else
                                sin.NumTimes = 1; // default to 1 if parsing fails
                            
                        }
                        if (datePicker != null)
                        {
                            if (datePicker.Value > DateTime.Today)
                                sin.Date = DateOnly.FromDateTime(DateTime.Today);
                            else
                                sin.Date = DateOnly.FromDateTime(datePicker.Value);
                        }
                    }
                }

                _data.SelectedSins = selectedSins;
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                // do nothing, stay on the form
            }
        }

        private void showCommandment(object sender, EventArgs e) 
        {
            string commandment = ((Button)sender).Text;
            int commandmentNumber = int.Parse(commandment[0].ToString()) - 1;

            for (int i = 0; i < _categoryPanels.Count; i++)
            {
                _categoryPanels[i].Visible = (i == commandmentNumber);
            }
            currCategory = commandmentNumber;

            _categoryPanels[commandmentNumber].PerformLayout();
            _categoryPanels[commandmentNumber].Refresh();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
            this.Show();
        }
    }
}
