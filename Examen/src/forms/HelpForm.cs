using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Web;

namespace Examen
{
    public partial class HelpForm : Form
    {
        public List<HelpItem> items;
        public HelpForm()
        {
            InitializeComponent();
            items = new List<HelpItem>();
            LoadHelpItems();
        }

        public void LoadHelpItems()
        {
            string json = File.ReadAllText("data/qanda.json");
            items = JsonSerializer.Deserialize<List<HelpItem>>(json);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchbox.Text))
                return;

            string query = $"https://www.catholic.com/search?q={Uri.EscapeDataString(searchbox.Text)}";
            DialogResult result = MessageBox.Show("You're about to be sent to CatholicAnswers.com. Proceed?", "Help?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = query,
                    UseShellExecute = true
                });
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void getAnswer(object sender, EventArgs e)
        {
            if (items.Count == 0)
                return;

            Button b = (Button)sender;

            HelpItem question = items.FirstOrDefault(h => h.Question == b.Text);

            if (question != null)
                MessageBox.Show(question.Answer, question.Question);
            else
                MessageBox.Show("Could not find answer.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public class HelpItem 
    { 
        public string? Question {  get; set; }
        public string? Answer { get; set; }
    }
}
