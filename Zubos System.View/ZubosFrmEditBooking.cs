using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zubos.System.Business;
using System.Text.RegularExpressions;

namespace Zubos_System
{
    public partial class ZubosFrmEditBooking : Form
    {
        BookingDetail selectedBooking { get; set; }
        Customer assignedCustomer { get; set; }
        Room assignedRoom { get; set; }

        public ZubosFrmEditBooking(BookingDetail bookingObj)
        {
            InitializeComponent();
            selectedBooking = bookingObj;
        }

        private void ZubosFrmEditBooking_Load(object sender, EventArgs e)
        {
            LoadBookingDetail();
            LoadRoom();
            LoadCustomer();
        }

        private void LoadBookingDetail()
        {
            TxtBookingID.Text = selectedBooking.BookingDetailID.ToString();
            DtpDateFrom.Value = selectedBooking.DateStart;
            TxtDays.Text = selectedBooking.Days.ToString();
            TxtPrice.Text = selectedBooking.PaymentAmount.ToString();
            TxtAdditionalInfo.Text = selectedBooking.Notes;
        }
        private void LoadRoom()
        {
            assignedRoom = Room.GetRoomByID(selectedBooking.myRoom);
            TxtRoomID.Text = assignedRoom.RoomID.ToString();
            TxtRoomName.Text = assignedRoom.Name;
        }
        private void LoadCustomer()
        {
            assignedCustomer = Customer.GetCustomerByID(selectedBooking.myCustomer);
            TxtCustID.Text = assignedCustomer.CustomerID.ToString();
            TxtCustName.Text = assignedCustomer.Name;
        }

        private void TxtDays_TextChanged(object sender, EventArgs e)
        {
            Regex nonNumericRegex = new Regex(@"\D");
            if (!nonNumericRegex.IsMatch(TxtDays.Text) && TxtDays.Text != String.Empty)
            {
                DtpDateTo.Value = DtpDateFrom.Value.AddDays(Convert.ToInt32(TxtDays.Text));
            }
            else if (TxtDays.Text != String.Empty)
            {
                TxtDays.Text = TxtDays.Text.Remove(TxtDays.Text.Length - 1, 1);
                TxtDays.Select(TxtDays.Text.Length, 0);
            }
        }

        private void DtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            Regex nonNumericRegex = new Regex(@"\D");
            if (!nonNumericRegex.IsMatch(TxtDays.Text) && TxtDays.Text != String.Empty)
            {
                DtpDateTo.Value = DtpDateFrom.Value.AddDays(Convert.ToInt32(TxtDays.Text));
            }
        }
    }
}
