﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Zubos.System.Business;

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
            TxtName.Enabled = !ChkDone.Checked;
            TxtHouseNumber.Enabled = !ChkDone.Checked;
            TxtHouseName.Enabled = !ChkDone.Checked;
            TxtStreet.Enabled = !ChkDone.Checked;
            TxtPostcode.Enabled = !ChkDone.Checked;
            DtpDateFrom.Enabled = !ChkDone.Checked;
            TxtDays.Enabled = !ChkDone.Checked;
            CmbRoom.Enabled = !ChkDone.Checked;
            TxtBookingNotes.Enabled = !ChkDone.Checked;
            BtnSubmit.Enabled = ChkDone.Checked;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            BookingDetail.CreateBooking(TxtName.Text, 
                                        Convert.ToInt32(TxtHouseNumber.Text), 
                                        TxtHouseName.Text, TxtStreet.Text, 
                                        TxtPostcode.Text, DtpDateFrom.Value, 
                                        Convert.ToInt32(TxtDays.Text), 
                                        Convert.ToDouble(TxtPrice.Text), 
                                        Room.GetRoomByID((int)CmbRoom.SelectedValue), 
                                        TxtBookingNotes.Text);
        }

        private void ZubosFrmNewBooking_Load(object sender, EventArgs e)
        {
            CmbRoom.DataSource = Room.GetAllUnassignedRoomsAsList().OrderBy(O => O.Name).ToList();
            TxtName.Focus();
        }

        private void CmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedRoomID = (int)CmbRoom.SelectedValue;
            Room ReturnedRoom = Room.GetRoomByID(SelectedRoomID);
            TxtRoomName.Text = ReturnedRoom.Name;
            TxtRoomNumber.Text = ReturnedRoom.RoomID.ToString();
            TxtPrice.Text = ReturnedRoom.Price.ToString();
            TxtAdditionalInfo.Text = ReturnedRoom.AdditionalInfo;
        }

        private void TxtDays_TextChanged(object sender, EventArgs e)
        {
            Regex nonNumericRegex = new Regex(@"\D");
            if (!nonNumericRegex.IsMatch(TxtDays.Text) && TxtDays.Text != String.Empty)
            {
                DtpDateTo.Value = DtpDateFrom.Value.AddDays(Convert.ToInt32(TxtDays.Text));
            }
            else if(TxtDays.Text != String.Empty)
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

        private void TxtPostcode_TextChanged(object sender, EventArgs e)
        {
            //UK Postcode
            Regex UKPostCodeRegEx = new Regex(@"(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|
                                                (([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|
                                                (([A-Z-[QVX]][0-9][A-HJKPSTUW])|
                                                ([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) 
                                               [0-9][A-Z-[CIKMOV]]{2})");
        }

        private void TxtHouseNumber_TextChanged(object sender, EventArgs e)
        {
            Regex nonNumericRegex = new Regex(@"\D");
            if (nonNumericRegex.IsMatch(TxtHouseNumber.Text) && TxtHouseNumber.Text != String.Empty)
            {
                TxtHouseNumber.Text = TxtHouseNumber.Text.Remove(TxtHouseNumber.Text.Length - 1, 1);
                TxtHouseNumber.Select(TxtHouseNumber.Text.Length, 0);
            }
        }
    }
}
