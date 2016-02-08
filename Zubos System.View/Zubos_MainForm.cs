using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zubos.System.Business;

namespace Zubos_System
{
    public partial class Zubos_MainForm : Form
    {
        public Zubos_MainForm()
        {
            InitializeComponent();
            Global.AllOpenForms.Add(this);
        }

        /// <summary>
        /// Exit application Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit Zubos Management System?",
                            "Attention",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Global.FinaliseApplication();
            }
        }

        private void Zubos_MainForm_Load(object sender, EventArgs e)
        {
            Global.InitialiseApplication();
        }

        private void BtnNewBooking_Click(object sender, EventArgs e)
        {
            Form FrmNewBooking = new ZubosFrmNewBooking();
            FrmNewBooking.Show();
        }

    }
}
