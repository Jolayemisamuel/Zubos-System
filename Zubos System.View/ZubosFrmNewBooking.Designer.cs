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
            this.LblName = new System.Windows.Forms.Label();
            this.LblHouseNumber = new System.Windows.Forms.Label();
            this.TxtHouseNumber = new System.Windows.Forms.TextBox();
            this.LblHouseName = new System.Windows.Forms.Label();
            this.TxtHouseName = new System.Windows.Forms.TextBox();
            this.LblStreet = new System.Windows.Forms.Label();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.LblPostcode = new System.Windows.Forms.Label();
            this.TxtPostcode = new System.Windows.Forms.TextBox();
            this.DtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.LblDateFrom = new System.Windows.Forms.Label();
            this.LblDateTo = new System.Windows.Forms.Label();
            this.DtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.CmbRoom = new System.Windows.Forms.ComboBox();
            this.LblRoom = new System.Windows.Forms.Label();
            this.GrpBoxRoomDetail = new System.Windows.Forms.GroupBox();
            this.LblNameRoomDetail = new System.Windows.Forms.Label();
            this.LblPriceRoomDetail = new System.Windows.Forms.Label();
            this.LblNumberRoomDetail = new System.Windows.Forms.Label();
            this.LblExtraRoomDetail = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.ChkDone = new System.Windows.Forms.CheckBox();
            this.GrpBoxNewBooking.SuspendLayout();
            this.GrpBoxRoomDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 47);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(223, 22);
            this.TxtName.TabIndex = 0;
            // 
            // GrpBoxNewBooking
            // 
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
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(13, 24);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(104, 17);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Booking Name:";
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
            this.TxtStreet.Size = new System.Drawing.Size(223, 22);
            this.TxtStreet.TabIndex = 6;
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
            // 
            // DtpDateFrom
            // 
            this.DtpDateFrom.Location = new System.Drawing.Point(16, 288);
            this.DtpDateFrom.Name = "DtpDateFrom";
            this.DtpDateFrom.Size = new System.Drawing.Size(200, 22);
            this.DtpDateFrom.TabIndex = 10;
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
            // LblDateTo
            // 
            this.LblDateTo.AutoSize = true;
            this.LblDateTo.Location = new System.Drawing.Point(13, 313);
            this.LblDateTo.Name = "LblDateTo";
            this.LblDateTo.Size = new System.Drawing.Size(63, 17);
            this.LblDateTo.TabIndex = 13;
            this.LblDateTo.Text = "Date To:";
            // 
            // DtpDateTo
            // 
            this.DtpDateTo.Location = new System.Drawing.Point(16, 337);
            this.DtpDateTo.Name = "DtpDateTo";
            this.DtpDateTo.Size = new System.Drawing.Size(200, 22);
            this.DtpDateTo.TabIndex = 12;
            // 
            // CmbRoom
            // 
            this.CmbRoom.FormattingEnabled = true;
            this.CmbRoom.Location = new System.Drawing.Point(297, 47);
            this.CmbRoom.Name = "CmbRoom";
            this.CmbRoom.Size = new System.Drawing.Size(269, 24);
            this.CmbRoom.TabIndex = 14;
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
            // GrpBoxRoomDetail
            // 
            this.GrpBoxRoomDetail.Controls.Add(this.LblExtraRoomDetail);
            this.GrpBoxRoomDetail.Controls.Add(this.LblNumberRoomDetail);
            this.GrpBoxRoomDetail.Controls.Add(this.LblPriceRoomDetail);
            this.GrpBoxRoomDetail.Controls.Add(this.LblNameRoomDetail);
            this.GrpBoxRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxRoomDetail.Location = new System.Drawing.Point(297, 77);
            this.GrpBoxRoomDetail.Name = "GrpBoxRoomDetail";
            this.GrpBoxRoomDetail.Size = new System.Drawing.Size(269, 282);
            this.GrpBoxRoomDetail.TabIndex = 16;
            this.GrpBoxRoomDetail.TabStop = false;
            this.GrpBoxRoomDetail.Text = "Room Details";
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
            // ChkDone
            // 
            this.ChkDone.AutoSize = true;
            this.ChkDone.Location = new System.Drawing.Point(364, 384);
            this.ChkDone.Name = "ChkDone";
            this.ChkDone.Size = new System.Drawing.Size(64, 21);
            this.ChkDone.TabIndex = 18;
            this.ChkDone.Text = "Done";
            this.ChkDone.UseVisualStyleBackColor = true;
            this.ChkDone.CheckedChanged += new System.EventHandler(this.ChkDone_CheckedChanged);
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
            this.Text = "New Booking";
            this.TopMost = true;
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
    }
}