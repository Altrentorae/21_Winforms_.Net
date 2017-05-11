using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    public partial class usrSettings : Form
    {
        public usrSettings()
        {
            InitializeComponent();
        }

        private void usrSettings_Load(object sender, EventArgs e)
        {
            //EXPONENT not yet implemented, below disables controls for it
            minBetRadioExponent.Enabled = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            simClick();
            this.Close();
        }

        public byte getMode()
        {

            if (minBetRadioLinear.Checked) { return 0; }
            else if (minBetRadioExponent.Checked) { return 1; }
            else { return 2; }

        }
        public int LIN, EXP, FRA;
        public bool INC;

        private void minBetRadioLinear_CheckedChanged(object sender, EventArgs e)
        {
            if (getMode() == 0) { incrementLinear.Enabled = true; } else { incrementLinear.Enabled = false; }
        }

        private void minBetRadioExponent_CheckedChanged(object sender, EventArgs e)
        {
            if (getMode() == 0) { incrementLinear.Enabled = true; } else { incrementLinear.Enabled = false; }
        }

        private void minBetRadioFract_CheckedChanged(object sender, EventArgs e)
        {
            if (getMode() == 0) { incrementLinear.Enabled = true; } else { incrementLinear.Enabled = false; }
        }

        public void simClick()
        {
            LIN = (int)linearInput.Value;
            EXP = (int)exponentInput.Value;
            FRA = (int)fractional.Value;
            INC = incrementLinear.Checked;
        }
        public void setLin()
        {
            minBetRadioLinear.Checked = true;
        }
    }
}
