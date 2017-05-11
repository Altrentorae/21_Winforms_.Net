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
    public partial class initial_settings : Form
    {
        public initial_settings()
        {
            InitializeComponent();
        }

        private void difficultyGroup_Enter(object sender, EventArgs e)
        {

        }

        

        public bool aceSetting;
        public byte diff;
        public long money;

        public void updateValues()
        {
            if (diff0.Checked == true) { diff = 0; }
            if (diff1.Checked == true) { diff = 1; }
            if (diff2.Checked == true) { diff = 2; }
            if (diff3.Checked == true) { diff = 3; }
            if (diff4.Checked == true) { diff = 4; }

            
            if (aceHigh.Checked == true) { aceSetting = true; }
            

            money = (long)moneyInput.Value;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            updateValues();
            this.Close();
        }
    }
    
}
