using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Examen.src.forms
{
    public partial class ConfessionForm : Form
    {
        ExamenData _data;
        string[] guide = { "As you enter, do the sign of the Cross with your Confessor.",
                           "Follow this up with 'Bless me Father, for I have sinned' or 'Forgive me, Father, for I have sinned'",
                           "Confess all your sins: ",
                           "Your Confessor will typically give you some help regarding your sins confessed, listen intently.",
                           "Next, he will give you a penance, something to do following the Sacrament, make sure to remember this.",
                           "Your Confessor will ask for your Act of Contrition, either speak from the heart or the prayer below:",
                           "The Confessor will then present to you absolution which will end with the Sign of the Cross and dismissal.",
                           "Now, just leave the confessional and do your penance with a contrite heart, meditating on what you're asking!"};
        private bool _suppressCloseConfirmation = false; // flag for closing
        private StringBuilder sb;
        public ConfessionForm(ExamenData data)
        {
            InitializeComponent();
            sb = new StringBuilder();
            this._data = data;
        }

        private void ConfessionForm_Load(object sender, EventArgs e)
        {
            if (this._data == null)
            {
                // how did we get here?
                MessageBox.Show("CRITICAL ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Entrance
            if (_data.AddGuide)
            {
                sb.AppendLine(guide[0]);
                sb.AppendLine(guide[1]);
                sb.AppendLine("");
            }

            // Sins to confess
            sb.AppendLine(guide[2]);
            for (int i = 0; i < _data.SelectedSins.Count; i++)
            {
                // loads sins to the form
                sb.AppendLine($"\t{(i + 1)}. {_data.SelectedSins[i].Confession}");

                // if the sin is mortal, show that
                if (_data.SelectedSins[i].Mortal)
                {
                    sb.AppendLine($"\t\tThis sin was mortal, committed {_data.SelectedSins[i].NumTimes} time(s) on {_data.SelectedSins[i].Date}.");
                }
            }


            // Info on Confessor response and penance
            if (_data.AddGuide)
            {
                sb.AppendLine();
                sb.AppendLine(guide[3]);
                sb.AppendLine(guide[4]);
            }

            sb.AppendLine();
            // Act of Contrition
            sb.AppendLine(guide[5]);
            sb.AppendLine();

            if (_data.AddPrayer)
                sb.AppendLine($"ACT OF CONTRITION\n\"{_data.SelectedPrayer}\"");
            else
                sb.AppendLine("ACT OF CONTRITION\n\"O my God, I am heartily sorry for having offended Thee, and I detest all my sins because of Thy just punishments, but most of all because they offend Thee, my God, Who art all-good and deserving of all my love. I firmly resolve, with the help of Thy grace, to sin no more and to avoid the near occasions of sin.\"");

            sb.AppendLine();
            if (_data.AddGuide)
                sb.AppendLine(guide[6]);

            sb.AppendLine(guide[7]);

            richTextBox1.Text = sb.ToString();
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to restart?", "Restart?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _suppressCloseConfirmation = true;
                _data.Quit = false;
                _data.Reset = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _data.Quit = true;
                _suppressCloseConfirmation = true;
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void ConfessionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_suppressCloseConfirmation == false)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                    _data.Quit = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveDialog.Title = "Save PDF";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveDialog.FileName;

                    // Save PDF
                    using (PdfWriter writer = new PdfWriter(filePath))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document document = new Document(pdf))
                    {
                        document.Add(new Paragraph(sb.ToString()));
                    }

                    MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
