using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace Zubos_System
{
    public partial class ZubosFrmCalendar : Form
    {
        public ZubosFrmCalendar()
        {
            InitializeComponent();
        }

        private void ZubosFrmCalendar_Load(object sender, EventArgs e)
        {
            DateTime firstDayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddTicks(-1);
            mainCalendar.SetViewRange(firstDayOfMonth, lastDayOfMonth);
        }
    }
}
