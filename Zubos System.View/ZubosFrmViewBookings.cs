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
            DgvBookings.Columns[(DgvBookings.Columns.Count - 2)].Width = 350;
        }

        private void DgvBookings_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBookings.SelectedRows.Count > 0)
            {
                TxtBookingNotes.Text = (string)DgvBookings.SelectedRows[0].Cells["Notes"].Value;

                int CustomerID = (int)DgvBookings.SelectedRows[0].Cells["myCustomer"].Value;

                Customer selectedCustomer = Customer.GetCustomerByID(CustomerID);
                TxtCustName.Text = selectedCustomer.Name;
                TxtHouseNumb.Text = selectedCustomer.HouseNumber.ToString();
                TxtHouseName.Text = selectedCustomer.HouseName;
                TxtStreet.Text = selectedCustomer.Street;
                TxtPostcode.Text = selectedCustomer.Postcode;


                int RoomID = (int)DgvBookings.SelectedRows[0].Cells["myRoom"].Value;

                Room selectedRoom = Room.GetRoomByID(RoomID);
                TxtRoomName.Text = selectedRoom.Name;
                TxtRoomNumber.Text = selectedRoom.RoomID.ToString();
                TxtPrice.Text = selectedRoom.Price.ToString();
                TxtAdditionalInfo.Text = selectedRoom.AdditionalInfo;
            }
        }

        private void BtnEditBooking_Click(object sender, EventArgs e)
        {

        }
    }
}
