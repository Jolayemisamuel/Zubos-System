using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zubos_System
{
    public partial class ZubosFrmNewBooking : Form
    {
        public ZubosFrmNewBooking()
        {
            InitializeComponent();
        }

        private void ChkDone_CheckedChanged(object sender, EventArgs e)
        {
            BtnSubmit.Enabled = ChkDone.Checked;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
