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

        private void ZubosFrmNewBooking_Load(object sender, EventArgs e)
        {
            TxtName.Focus();
            CmbRoom.DataSource = Room.GetAllRoomsAsList();
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
    }
}
