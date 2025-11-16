using Examen.src.objs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class PrayerForm : Form
    {
        ExamenData _data;
        List<Prayer> prayers = new List<Prayer>();
        int totalPrayers = 0;
        string filePath = "data/prayerData.txt";

        public PrayerForm(ExamenData data)
        {
            InitializeComponent();
            LoadPrayersFromFile();
            _data = data;

            for (int i = 0; i < totalPrayers; i++)
            {
                // creates the buttons for each prayer
                Button button = new Button();
                button.Text = $"{prayers[i].PrayerContents}";
                button.Tag = prayers[i].PrayerID;
                button.AutoSize = false;
                button.Width = 350;
                button.UseCompatibleTextRendering = true;
                button.TextAlign = ContentAlignment.MiddleCenter;

                // sizes the buttons height relative to the length of the text it holds
                Size textSize = TextRenderer.MeasureText(
                    button.Text,
                    button.Font,
                    new Size(button.Width - 10, int.MaxValue), // leave a little padding
                    TextFormatFlags.WordBreak
                );

                // sets the height using the above codes results
                button.Height = textSize.Height + 20;

                // if button is clicked
                button.Click += (s, e) =>
                {
                    // set selected prayer and let the data know the user would like a prayer
                    _data.SelectedPrayer = prayers[(int)button.Tag-1].PrayerContents; // why does this suddenly need to be -2 and not -1??
                    _data.AddPrayer = true;
                    DialogResult = DialogResult.OK;
                };
                // add the button to the controls for the panel
                prayerPanel.Controls.Add(button);
            }
        }

        private void LoadPrayersFromFile()
        {
            int prayerID = 1;

            if (!File.Exists(filePath))
            {
                // File not found - no data loaded. Consider logging or notifying.
                System.Diagnostics.Debug.WriteLine($"Prayer file not found: {filePath}");
                return;
            }


            var lines = File.ReadAllLines(filePath).Append(string.Empty); 
            string prayer = "";
            foreach (var line in lines)
            {
                // if white space, then add the prayer and prepare for the next one
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (!string.IsNullOrWhiteSpace(prayer))
                    {
                        prayers.Add(new Prayer(prayerID++, prayer.Trim()));
                        prayer = "";
                    }
                }
                else
                {
                    prayer += line.Trim() + " ";
                    System.Diagnostics.Debug.WriteLine($"{prayer}");
                }
            }

            totalPrayers = prayers.Count;
        }
    }
}
