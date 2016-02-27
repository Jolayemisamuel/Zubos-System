namespace Zubos_System
{
    partial class ZubosFrmNewBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtName = new System.Windows.Forms.TextBox();
            this.GrpBoxNewBooking = new System.Windows.Forms.GroupBox();
            this.TxtBookingNotes = new System.Windows.Forms.TextBox();
            this.LblBookingNotes = new System.Windows.Forms.Label();
            this.ChkDone = new System.Windows.Forms.CheckBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.GrpBoxRoomDetail = new System.Windows.Forms.GroupBox();
            this.TxtAdditionalInfo = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtRoomNumber = new System.Windows.Forms.TextBox();
            this.TxtRoomName = new System.Windows.Forms.TextBox();
            this.LblExtraRoomDetail = new System.Windows.Forms.Label();
            this.LblNumberRoomDetail = new System.Windows.Forms.Label();
            this.LblPriceRoomDetail = new System.Windows.Forms.Label();
            this.LblNameRoomDetail = new System.Windows.Forms.Label();
            this.LblRoom = new System.Windows.Forms.Label();
            this.CmbRoom = new System.Windows.Forms.ComboBox();
            this.LblDateTo = new System.Windows.Forms.Label();
            this.DtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.LblDateFrom = new System.Windows.Forms.Label();
            this.DtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.LblPostcode = new System.Windows.Forms.Label();
            this.TxtPostcode = new System.Windows.Forms.TextBox();
            this.LblStreet = new System.Windows.Forms.Label();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.LblHouseName = new System.Windows.Forms.Label();
            this.TxtHouseName = new System.Windows.Forms.TextBox();
            this.LblHouseNumber = new System.Windows.Forms.Label();
            this.TxtHouseNumber = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDays = new System.Windows.Forms.Label();
            this.TxtDays = new System.Windows.Forms.TextBox();
            this.GrpBoxNewBooking.SuspendLayout();
            this.GrpBoxRoomDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 47);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(240, 22);
            this.TxtName.TabIndex = 0;
            // 
            // GrpBoxNewBooking
            // 
            this.GrpBoxNewBooking.Controls.Add(this.LblDays);
            this.GrpBoxNewBooking.Controls.Add(this.TxtDays);
            this.GrpBoxNewBooking.Controls.Add(this.TxtBookingNotes);
            this.GrpBoxNewBooking.Controls.Add(this.LblBookingNotes);
            this.GrpBoxNewBooking.Controls.Add(this.ChkDone);
            this.GrpBoxNewBooking.Controls.Add(this.BtnSubmit);
            this.GrpBoxNewBooking.Controls.Add(this.GrpBoxRoomDetail);
            this.GrpBoxNewBooking.Controls.Add(this.LblRoom);
            this.GrpBoxNewBooking.Controls.Add(this.CmbRoom);
            this.GrpBoxNewBooking.Controls.Add(this.LblDateTo);
            this.GrpBoxNewBooking.Controls.Add(this.DtpDateTo);
            this.GrpBoxNewBooking.Controls.Add(this.LblDateFrom);
            this.GrpBoxNewBooking.Controls.Add(this.DtpDateFrom);
            this.GrpBoxNewBooking.Controls.Add(this.LblPostcode);
            this.GrpBoxNewBooking.Controls.Add(this.TxtPostcode);
            this.GrpBoxNewBooking.Controls.Add(this.LblStreet);
            this.GrpBoxNewBooking.Controls.Add(this.TxtStreet);
            this.GrpBoxNewBooking.Controls.Add(this.LblHouseName);
            this.GrpBoxNewBooking.Controls.Add(this.TxtHouseName);
            this.GrpBoxNewBooking.Controls.Add(this.LblHouseNumber);
            this.GrpBoxNewBooking.Controls.Add(this.TxtHouseNumber);
            this.GrpBoxNewBooking.Controls.Add(this.LblName);
            this.GrpBoxNewBooking.Controls.Add(this.TxtName);
            this.GrpBoxNewBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpBoxNewBooking.Location = new System.Drawing.Point(0, 0);
            this.GrpBoxNewBooking.Name = "GrpBoxNewBooking";
            this.GrpBoxNewBooking.Size = new System.Drawing.Size(588, 426);
            this.GrpBoxNewBooking.TabIndex = 1;
            this.GrpBoxNewBooking.TabStop = false;
            // 
            // TxtBookingNotes
            // 
            this.TxtBookingNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBookingNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookingNotes.Location = new System.Drawing.Point(297, 317);
            this.TxtBookingNotes.MaxLength = 500;
            this.TxtBookingNotes.Multiline = true;
            this.TxtBookingNotes.Name = "TxtBookingNotes";
            this.TxtBookingNotes.Size = new System.Drawing.Size(269, 61);
            this.TxtBookingNotes.TabIndex = 18;
            // 
            // LblBookingNotes
            // 
            this.LblBookingNotes.AutoSize = true;
            this.LblBookingNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookingNotes.Location = new System.Drawing.Point(294, 295);
            this.LblBookingNotes.Name = "LblBookingNotes";
            this.LblBookingNotes.Size = new System.Drawing.Size(104, 17);
            this.LblBookingNotes.TabIndex = 25;
            this.LblBookingNotes.Text = "Booking Notes:";
            // 
            // ChkDone
            // 
            this.ChkDone.AutoSize = true;
            this.ChkDone.Location = new System.Drawing.Point(364, 393);
            this.ChkDone.Name = "ChkDone";
            this.ChkDone.Size = new System.Drawing.Size(64, 21);
            this.ChkDone.TabIndex = 18;
            this.ChkDone.Text = "Done";
            this.ChkDone.UseVisualStyleBackColor = true;
            this.ChkDone.CheckedChanged += new System.EventHandler(this.ChkDone_CheckedChanged);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Enabled = false;
            this.BtnSubmit.Location = new System.Drawing.Point(434, 384);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(132, 30);
            this.BtnSubmit.TabIndex = 17;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // GrpBoxRoomDetail
            // 
            this.GrpBoxRoomDetail.Controls.Add(this.TxtAdditionalInfo);
            this.GrpBoxRoomDetail.Controls.Add(this.TxtPrice);
            this.GrpBoxRoomDetail.Controls.Add(this.TxtRoomNumber);
            this.GrpBoxRoomDetail.Controls.Add(this.TxtRoomName);
            this.GrpBoxRoomDetail.Controls.Add(this.LblExtraRoomDetail);
            this.GrpBoxRoomDetail.Controls.Add(this.LblNumberRoomDetail);
            this.GrpBoxRoomDetail.Controls.Add(this.LblPriceRoomDetail);
            this.GrpBoxRoomDetail.Controls.Add(this.LblNameRoomDetail);
            this.GrpBoxRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxRoomDetail.Location = new System.Drawing.Point(297, 77);
            this.GrpBoxRoomDetail.Name = "GrpBoxRoomDetail";
            this.GrpBoxRoomDetail.Size = new System.Drawing.Size(269, 215);
            this.GrpBoxRoomDetail.TabIndex = 16;
            this.GrpBoxRoomDetail.TabStop = false;
            this.GrpBoxRoomDetail.Text = "Room Details";
            // 
            // TxtAdditionalInfo
            // 
            this.TxtAdditionalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdditionalInfo.Location = new System.Drawing.Point(9, 134);
            this.TxtAdditionalInfo.MaxLength = 500;
            this.TxtAdditionalInfo.Multiline = true;
            this.TxtAdditionalInfo.Name = "TxtAdditionalInfo";
            this.TxtAdditionalInfo.ReadOnly = true;
            this.TxtAdditionalInfo.Size = new System.Drawing.Size(254, 70);
            this.TxtAdditionalInfo.TabIndex = 24;
            // 
            // TxtPrice
            // 
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(115, 80);
            this.TxtPrice.MaxLength = 300;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(148, 22);
            this.TxtPrice.TabIndex = 23;
            this.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtRoomNumber
            // 
            this.TxtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomNumber.Location = new System.Drawing.Point(115, 50);
            this.TxtRoomNumber.MaxLength = 300;
            this.TxtRoomNumber.Name = "TxtRoomNumber";
            this.TxtRoomNumber.ReadOnly = true;
            this.TxtRoomNumber.Size = new System.Drawing.Size(148, 22);
            this.TxtRoomNumber.TabIndex = 22;
            this.TxtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtRoomName
            // 
            this.TxtRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomName.Location = new System.Drawing.Point(61, 23);
            this.TxtRoomName.MaxLength = 300;
            this.TxtRoomName.Name = "TxtRoomName";
            this.TxtRoomName.ReadOnly = true;
            this.TxtRoomName.Size = new System.Drawing.Size(202, 22);
            this.TxtRoomName.TabIndex = 21;
            this.TxtRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblExtraRoomDetail
            // 
            this.LblExtraRoomDetail.AutoSize = true;
            this.LblExtraRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExtraRoomDetail.Location = new System.Drawing.Point(8, 114);
            this.LblExtraRoomDetail.Name = "LblExtraRoomDetail";
            this.LblExtraRoomDetail.Size = new System.Drawing.Size(101, 17);
            this.LblExtraRoomDetail.TabIndex = 20;
            this.LblExtraRoomDetail.Text = "Additional Info:";
            // 
            // LblNumberRoomDetail
            // 
            this.LblNumberRoomDetail.AutoSize = true;
            this.LblNumberRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberRoomDetail.Location = new System.Drawing.Point(6, 52);
            this.LblNumberRoomDetail.Name = "LblNumberRoomDetail";
            this.LblNumberRoomDetail.Size = new System.Drawing.Size(103, 17);
            this.LblNumberRoomDetail.TabIndex = 19;
            this.LblNumberRoomDetail.Text = "Room Number:";
            // 
            // LblPriceRoomDetail
            // 
            this.LblPriceRoomDetail.AutoSize = true;
            this.LblPriceRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPriceRoomDetail.Location = new System.Drawing.Point(6, 82);
            this.LblPriceRoomDetail.Name = "LblPriceRoomDetail";
            this.LblPriceRoomDetail.Size = new System.Drawing.Size(44, 17);
            this.LblPriceRoomDetail.TabIndex = 18;
            this.LblPriceRoomDetail.Text = "Price:";
            // 
            // LblNameRoomDetail
            // 
            this.LblNameRoomDetail.AutoSize = true;
            this.LblNameRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameRoomDetail.Location = new System.Drawing.Point(6, 23);
            this.LblNameRoomDetail.Name = "LblNameRoomDetail";
            this.LblNameRoomDetail.Size = new System.Drawing.Size(49, 17);
            this.LblNameRoomDetail.TabIndex = 17;
            this.LblNameRoomDetail.Text = "Name:";
            // 
            // LblRoom
            // 
            this.LblRoom.AutoSize = true;
            this.LblRoom.Location = new System.Drawing.Point(294, 24);
            this.LblRoom.Name = "LblRoom";
            this.LblRoom.Size = new System.Drawing.Size(49, 17);
            this.LblRoom.TabIndex = 15;
            this.LblRoom.Text = "Room:";
            // 
            // CmbRoom
            // 
            this.CmbRoom.DisplayMember = "Name";
            this.CmbRoom.DropDownHeight = 300;
            this.CmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbRoom.FormattingEnabled = true;
            this.CmbRoom.IntegralHeight = false;
            this.CmbRoom.Location = new System.Drawing.Point(297, 47);
            this.CmbRoom.Name = "CmbRoom";
            this.CmbRoom.Size = new System.Drawing.Size(269, 24);
            this.CmbRoom.TabIndex = 14;
            this.CmbRoom.ValueMember = "RoomID";
            this.CmbRoom.SelectedIndexChanged += new System.EventHandler(this.CmbRoom_SelectedIndexChanged);
            // 
            // LblDateTo
            // 
            this.LblDateTo.AutoSize = true;
            this.LblDateTo.Location = new System.Drawing.Point(13, 366);
            this.LblDateTo.Name = "LblDateTo";
            this.LblDateTo.Size = new System.Drawing.Size(63, 17);
            this.LblDateTo.TabIndex = 13;
            this.LblDateTo.Text = "Date To:";
            // 
            // DtpDateTo
            // 
            this.DtpDateTo.Enabled = false;
            this.DtpDateTo.Location = new System.Drawing.Point(12, 386);
            this.DtpDateTo.Name = "DtpDateTo";
            this.DtpDateTo.Size = new System.Drawing.Size(200, 22);
            this.DtpDateTo.TabIndex = 12;
            // 
            // LblDateFrom
            // 
            this.LblDateFrom.AutoSize = true;
            this.LblDateFrom.Location = new System.Drawing.Point(13, 264);
            this.LblDateFrom.Name = "LblDateFrom";
            this.LblDateFrom.Size = new System.Drawing.Size(78, 17);
            this.LblDateFrom.TabIndex = 11;
            this.LblDateFrom.Text = "Date From:";
            // 
            // DtpDateFrom
            // 
            this.DtpDateFrom.Location = new System.Drawing.Point(12, 284);
            this.DtpDateFrom.Name = "DtpDateFrom";
            this.DtpDateFrom.Size = new System.Drawing.Size(200, 22);
            this.DtpDateFrom.TabIndex = 10;
            this.DtpDateFrom.Value = new System.DateTime(2016, 2, 25, 18, 35, 24, 0);
            this.DtpDateFrom.ValueChanged += new System.EventHandler(this.DtpDateFrom_ValueChanged);
            // 
            // LblPostcode
            // 
            this.LblPostcode.AutoSize = true;
            this.LblPostcode.Location = new System.Drawing.Point(13, 216);
            this.LblPostcode.Name = "LblPostcode";
            this.LblPostcode.Size = new System.Drawing.Size(77, 17);
            this.LblPostcode.TabIndex = 9;
            this.LblPostcode.Text = "Post Code:";
            // 
            // TxtPostcode
            // 
            this.TxtPostcode.Location = new System.Drawing.Point(12, 239);
            this.TxtPostcode.MaxLength = 8;
            this.TxtPostcode.Name = "TxtPostcode";
            this.TxtPostcode.Size = new System.Drawing.Size(78, 22);
            this.TxtPostcode.TabIndex = 8;
            this.TxtPostcode.TextChanged += new System.EventHandler(this.TxtPostcode_TextChanged);
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Location = new System.Drawing.Point(13, 168);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(50, 17);
            this.LblStreet.TabIndex = 7;
            this.LblStreet.Text = "Street:";
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(12, 191);
            this.TxtStreet.MaxLength = 60;
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(265, 22);
            this.TxtStreet.TabIndex = 6;
            // 
            // LblHouseName
            // 
            this.LblHouseName.AutoSize = true;
            this.LblHouseName.Location = new System.Drawing.Point(13, 120);
            this.LblHouseName.Name = "LblHouseName";
            this.LblHouseName.Size = new System.Drawing.Size(94, 17);
            this.LblHouseName.TabIndex = 5;
            this.LblHouseName.Text = "House Name:";
            // 
            // TxtHouseName
            // 
            this.TxtHouseName.Location = new System.Drawing.Point(12, 143);
            this.TxtHouseName.MaxLength = 45;
            this.TxtHouseName.Name = "TxtHouseName";
            this.TxtHouseName.Size = new System.Drawing.Size(176, 22);
            this.TxtHouseName.TabIndex = 4;
            // 
            // LblHouseNumber
            // 
            this.LblHouseNumber.AutoSize = true;
            this.LblHouseNumber.Location = new System.Drawing.Point(13, 72);
            this.LblHouseNumber.Name = "LblHouseNumber";
            this.LblHouseNumber.Size = new System.Drawing.Size(107, 17);
            this.LblHouseNumber.TabIndex = 3;
            this.LblHouseNumber.Text = "House Number:";
            // 
            // TxtHouseNumber
            // 
            this.TxtHouseNumber.Location = new System.Drawing.Point(12, 95);
            this.TxtHouseNumber.MaxLength = 4;
            this.TxtHouseNumber.Name = "TxtHouseNumber";
            this.TxtHouseNumber.Size = new System.Drawing.Size(63, 22);
            this.TxtHouseNumber.TabIndex = 2;
            this.TxtHouseNumber.TextChanged += new System.EventHandler(this.TxtHouseNumber_TextChanged);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(13, 24);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(104, 17);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Booking Name:";
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.Location = new System.Drawing.Point(13, 317);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(44, 17);
            this.LblDays.TabIndex = 27;
            this.LblDays.Text = "Days:";
            // 
            // TxtDays
            // 
            this.TxtDays.Location = new System.Drawing.Point(12, 337);
            this.TxtDays.MaxLength = 2;
            this.TxtDays.Name = "TxtDays";
            this.TxtDays.Size = new System.Drawing.Size(48, 22);
            this.TxtDays.TabIndex = 11;
            this.TxtDays.TextChanged += new System.EventHandler(this.TxtDays_TextChanged);
            // 
            // ZubosFrmNewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 426);
            this.Controls.Add(this.GrpBoxNewBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ZubosFrmNewBooking";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Booking";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ZubosFrmNewBooking_Load);
            this.GrpBoxNewBooking.ResumeLayout(false);
            this.GrpBoxNewBooking.PerformLayout();
            this.GrpBoxRoomDetail.ResumeLayout(false);
            this.GrpBoxRoomDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.GroupBox GrpBoxNewBooking;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblHouseNumber;
        private System.Windows.Forms.TextBox TxtHouseNumber;
        private System.Windows.Forms.Label LblHouseName;
        private System.Windows.Forms.TextBox TxtHouseName;
        private System.Windows.Forms.Label LblStreet;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.Label LblPostcode;
        private System.Windows.Forms.TextBox TxtPostcode;
        private System.Windows.Forms.Label LblDateTo;
        private System.Windows.Forms.DateTimePicker DtpDateTo;
        private System.Windows.Forms.Label LblDateFrom;
        private System.Windows.Forms.DateTimePicker DtpDateFrom;
        private System.Windows.Forms.GroupBox GrpBoxRoomDetail;
        private System.Windows.Forms.Label LblRoom;
        private System.Windows.Forms.ComboBox CmbRoom;
        private System.Windows.Forms.Label LblExtraRoomDetail;
        private System.Windows.Forms.Label LblNumberRoomDetail;
        private System.Windows.Forms.Label LblPriceRoomDetail;
        private System.Windows.Forms.Label LblNameRoomDetail;
        private System.Windows.Forms.CheckBox ChkDone;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox TxtAdditionalInfo;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtRoomNumber;
        private System.Windows.Forms.TextBox TxtRoomName;
        private System.Windows.Forms.TextBox TxtBookingNotes;
        private System.Windows.Forms.Label LblBookingNotes;
        private System.Windows.Forms.Label LblDays;
        private System.Windows.Forms.TextBox TxtDays;
    }
}