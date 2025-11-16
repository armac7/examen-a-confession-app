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
    public partial class CustomizeForm : Form
    {
        ExamenData _data;

        public CustomizeForm(ExamenData data)
        {
            InitializeComponent();
            _data = data;

            if (_data.AddPrayer)
                prayerCB.Checked = true;
            if (_data.AddGuide)
                guideCB.Checked = true;
        }

        private void prayerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (_data != null)
            {
                _data.AddPrayer = prayerCB.Checked;
            }
        }

        private void guideCB_CheckedChanged(object sender, EventArgs e)
        {
            if (_data != null)
            {
                _data.AddGuide = guideCB.Checked;
            }
        }

        private void confessButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
