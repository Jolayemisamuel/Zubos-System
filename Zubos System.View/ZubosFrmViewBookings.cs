using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zubos.System.Business;

namespace Zubos_System
{
    public partial class ZubosFrmViewBookings : Form
    {
        public ZubosFrmViewBookings()
        {
            InitializeComponent();
        }

        private void ZubosFrmViewBookings_Load(object sender, EventArgs e)
        {
            DgvBookings.DataSource = BookingDetail.GetAllBookingsAsDataTable();
            DgvBookings.AutoResizeColumns();
        }

        private void DgvBookings_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
