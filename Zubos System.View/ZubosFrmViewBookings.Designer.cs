namespace Zubos_System
{
    partial class ZubosFrmViewBookings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvBookings = new System.Windows.Forms.DataGridView();
            this.BtnEditBooking = new System.Windows.Forms.Button();
            this.GrpBoxRoom = new System.Windows.Forms.GroupBox();
            this.TxtAdditionalInfo = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtRoomNumber = new System.Windows.Forms.TextBox();
            this.TxtRoomName = new System.Windows.Forms.TextBox();
            this.LblExtraRoomDetail = new System.Windows.Forms.Label();
            this.LblNumberRoomDetail = new System.Windows.Forms.Label();
            this.LblPriceRoomDetail = new System.Windows.Forms.Label();
            this.LblNameRoomDetail = new System.Windows.Forms.Label();
            this.GrpBoxCustomer = new System.Windows.Forms.GroupBox();
            this.TxtPostcode = new System.Windows.Forms.TextBox();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.TxtHouseName = new System.Windows.Forms.TextBox();
            this.TxtHouseNumb = new System.Windows.Forms.TextBox();
            this.TxtCustName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblPostcode = new System.Windows.Forms.Label();
            this.LblHouseNumber = new System.Windows.Forms.Label();
            this.LblHouseName = new System.Windows.Forms.Label();
            this.LblStreet = new System.Windows.Forms.Label();
            this.GrpBoxBookingNotes = new System.Windows.Forms.GroupBox();
            this.TxtBookingNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookings)).BeginInit();
            this.GrpBoxRoom.SuspendLayout();
            this.GrpBoxCustomer.SuspendLayout();
            this.GrpBoxBookingNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvBookings
            // 
            this.DgvBookings.AllowUserToAddRows = false;
            this.DgvBookings.AllowUserToDeleteRows = false;
            this.DgvBookings.AllowUserToResizeColumns = false;
            this.DgvBookings.AllowUserToResizeRows = false;
            this.DgvBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBookings.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBookings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvBookings.Location = new System.Drawing.Point(0, 232);
            this.DgvBookings.MultiSelect = false;
            this.DgvBookings.Name = "DgvBookings";
            this.DgvBookings.ReadOnly = true;
            this.DgvBookings.RowTemplate.Height = 24;
            this.DgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBookings.Size = new System.Drawing.Size(1108, 535);
            this.DgvBookings.TabIndex = 0;
            this.DgvBookings.SelectionChanged += new System.EventHandler(this.DgvBookings_SelectionChanged);
            // 
            // BtnEditBooking
            // 
            this.BtnEditBooking.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditBooking.Font = new System.Drawing.Font("LuzSans-Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditBooking.Location = new System.Drawing.Point(12, 9);
            this.BtnEditBooking.Name = "BtnEditBooking";
            this.BtnEditBooking.Size = new System.Drawing.Size(112, 60);
            this.BtnEditBooking.TabIndex = 1;
            this.BtnEditBooking.Text = "Edit Booking";
            this.BtnEditBooking.UseVisualStyleBackColor = false;
            this.BtnEditBooking.Click += new System.EventHandler(this.BtnEditBooking_Click);
            // 
            // GrpBoxRoom
            // 
            this.GrpBoxRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.GrpBoxRoom.Controls.Add(this.TxtAdditionalInfo);
            this.GrpBoxRoom.Controls.Add(this.TxtPrice);
            this.GrpBoxRoom.Controls.Add(this.TxtRoomNumber);
            this.GrpBoxRoom.Controls.Add(this.TxtRoomName);
            this.GrpBoxRoom.Controls.Add(this.LblExtraRoomDetail);
            this.GrpBoxRoom.Controls.Add(this.LblNumberRoomDetail);
            this.GrpBoxRoom.Controls.Add(this.LblPriceRoomDetail);
            this.GrpBoxRoom.Controls.Add(this.LblNameRoomDetail);
            this.GrpBoxRoom.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxRoom.Location = new System.Drawing.Point(12, 75);
            this.GrpBoxRoom.Name = "GrpBoxRoom";
            this.GrpBoxRoom.Size = new System.Drawing.Size(506, 151);
            this.GrpBoxRoom.TabIndex = 2;
            this.GrpBoxRoom.TabStop = false;
            this.GrpBoxRoom.Text = "Room Details";
            // 
            // TxtAdditionalInfo
            // 
            this.TxtAdditionalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdditionalInfo.Location = new System.Drawing.Point(128, 104);
            this.TxtAdditionalInfo.MaxLength = 500;
            this.TxtAdditionalInfo.Multiline = true;
            this.TxtAdditionalInfo.Name = "TxtAdditionalInfo";
            this.TxtAdditionalInfo.ReadOnly = true;
            this.TxtAdditionalInfo.Size = new System.Drawing.Size(355, 40);
            this.TxtAdditionalInfo.TabIndex = 32;
            // 
            // TxtPrice
            // 
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(128, 76);
            this.TxtPrice.MaxLength = 300;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(116, 22);
            this.TxtPrice.TabIndex = 31;
            // 
            // TxtRoomNumber
            // 
            this.TxtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomNumber.Location = new System.Drawing.Point(128, 48);
            this.TxtRoomNumber.MaxLength = 300;
            this.TxtRoomNumber.Name = "TxtRoomNumber";
            this.TxtRoomNumber.ReadOnly = true;
            this.TxtRoomNumber.Size = new System.Drawing.Size(148, 22);
            this.TxtRoomNumber.TabIndex = 30;
            // 
            // TxtRoomName
            // 
            this.TxtRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomName.Location = new System.Drawing.Point(128, 22);
            this.TxtRoomName.MaxLength = 300;
            this.TxtRoomName.Name = "TxtRoomName";
            this.TxtRoomName.ReadOnly = true;
            this.TxtRoomName.Size = new System.Drawing.Size(235, 22);
            this.TxtRoomName.TabIndex = 29;
            // 
            // LblExtraRoomDetail
            // 
            this.LblExtraRoomDetail.AutoSize = true;
            this.LblExtraRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExtraRoomDetail.Location = new System.Drawing.Point(9, 104);
            this.LblExtraRoomDetail.Name = "LblExtraRoomDetail";
            this.LblExtraRoomDetail.Size = new System.Drawing.Size(103, 18);
            this.LblExtraRoomDetail.TabIndex = 28;
            this.LblExtraRoomDetail.Text = "Additional Info:";
            // 
            // LblNumberRoomDetail
            // 
            this.LblNumberRoomDetail.AutoSize = true;
            this.LblNumberRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberRoomDetail.Location = new System.Drawing.Point(9, 48);
            this.LblNumberRoomDetail.Name = "LblNumberRoomDetail";
            this.LblNumberRoomDetail.Size = new System.Drawing.Size(111, 18);
            this.LblNumberRoomDetail.TabIndex = 27;
            this.LblNumberRoomDetail.Text = "Room Number:";
            // 
            // LblPriceRoomDetail
            // 
            this.LblPriceRoomDetail.AutoSize = true;
            this.LblPriceRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPriceRoomDetail.Location = new System.Drawing.Point(9, 76);
            this.LblPriceRoomDetail.Name = "LblPriceRoomDetail";
            this.LblPriceRoomDetail.Size = new System.Drawing.Size(46, 18);
            this.LblPriceRoomDetail.TabIndex = 26;
            this.LblPriceRoomDetail.Text = "Price:";
            // 
            // LblNameRoomDetail
            // 
            this.LblNameRoomDetail.AutoSize = true;
            this.LblNameRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameRoomDetail.Location = new System.Drawing.Point(9, 22);
            this.LblNameRoomDetail.Name = "LblNameRoomDetail";
            this.LblNameRoomDetail.Size = new System.Drawing.Size(52, 18);
            this.LblNameRoomDetail.TabIndex = 25;
            this.LblNameRoomDetail.Text = "Name:";
            // 
            // GrpBoxCustomer
            // 
            this.GrpBoxCustomer.Controls.Add(this.TxtPostcode);
            this.GrpBoxCustomer.Controls.Add(this.TxtStreet);
            this.GrpBoxCustomer.Controls.Add(this.TxtHouseName);
            this.GrpBoxCustomer.Controls.Add(this.TxtHouseNumb);
            this.GrpBoxCustomer.Controls.Add(this.TxtCustName);
            this.GrpBoxCustomer.Controls.Add(this.LblName);
            this.GrpBoxCustomer.Controls.Add(this.LblPostcode);
            this.GrpBoxCustomer.Controls.Add(this.LblHouseNumber);
            this.GrpBoxCustomer.Controls.Add(this.LblHouseName);
            this.GrpBoxCustomer.Controls.Add(this.LblStreet);
            this.GrpBoxCustomer.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxCustomer.Location = new System.Drawing.Point(524, 75);
            this.GrpBoxCustomer.Name = "GrpBoxCustomer";
            this.GrpBoxCustomer.Size = new System.Drawing.Size(572, 151);
            this.GrpBoxCustomer.TabIndex = 3;
            this.GrpBoxCustomer.TabStop = false;
            this.GrpBoxCustomer.Text = "Customer Details";
            // 
            // TxtPostcode
            // 
            this.TxtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPostcode.Location = new System.Drawing.Point(436, 22);
            this.TxtPostcode.MaxLength = 300;
            this.TxtPostcode.Name = "TxtPostcode";
            this.TxtPostcode.ReadOnly = true;
            this.TxtPostcode.Size = new System.Drawing.Size(130, 22);
            this.TxtPostcode.TabIndex = 37;
            // 
            // TxtStreet
            // 
            this.TxtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStreet.Location = new System.Drawing.Point(118, 120);
            this.TxtStreet.MaxLength = 300;
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.ReadOnly = true;
            this.TxtStreet.Size = new System.Drawing.Size(224, 22);
            this.TxtStreet.TabIndex = 36;
            // 
            // TxtHouseName
            // 
            this.TxtHouseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtHouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHouseName.Location = new System.Drawing.Point(118, 86);
            this.TxtHouseName.MaxLength = 300;
            this.TxtHouseName.Name = "TxtHouseName";
            this.TxtHouseName.ReadOnly = true;
            this.TxtHouseName.Size = new System.Drawing.Size(224, 22);
            this.TxtHouseName.TabIndex = 35;
            // 
            // TxtHouseNumb
            // 
            this.TxtHouseNumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtHouseNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHouseNumb.Location = new System.Drawing.Point(118, 54);
            this.TxtHouseNumb.MaxLength = 300;
            this.TxtHouseNumb.Name = "TxtHouseNumb";
            this.TxtHouseNumb.ReadOnly = true;
            this.TxtHouseNumb.Size = new System.Drawing.Size(72, 22);
            this.TxtHouseNumb.TabIndex = 34;
            // 
            // TxtCustName
            // 
            this.TxtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustName.Location = new System.Drawing.Point(118, 24);
            this.TxtCustName.MaxLength = 300;
            this.TxtCustName.Name = "TxtCustName";
            this.TxtCustName.ReadOnly = true;
            this.TxtCustName.Size = new System.Drawing.Size(224, 22);
            this.TxtCustName.TabIndex = 33;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(8, 24);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(52, 18);
            this.LblName.TabIndex = 13;
            this.LblName.Text = "Name:";
            // 
            // LblPostcode
            // 
            this.LblPostcode.AutoSize = true;
            this.LblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPostcode.Location = new System.Drawing.Point(348, 24);
            this.LblPostcode.Name = "LblPostcode";
            this.LblPostcode.Size = new System.Drawing.Size(83, 18);
            this.LblPostcode.TabIndex = 21;
            this.LblPostcode.Text = "Post Code:";
            // 
            // LblHouseNumber
            // 
            this.LblHouseNumber.AutoSize = true;
            this.LblHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHouseNumber.Location = new System.Drawing.Point(8, 55);
            this.LblHouseNumber.Name = "LblHouseNumber";
            this.LblHouseNumber.Size = new System.Drawing.Size(113, 18);
            this.LblHouseNumber.TabIndex = 15;
            this.LblHouseNumber.Text = "House Number:";
            // 
            // LblHouseName
            // 
            this.LblHouseName.AutoSize = true;
            this.LblHouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHouseName.Location = new System.Drawing.Point(9, 87);
            this.LblHouseName.Name = "LblHouseName";
            this.LblHouseName.Size = new System.Drawing.Size(100, 18);
            this.LblHouseName.TabIndex = 17;
            this.LblHouseName.Text = "House Name:";
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStreet.Location = new System.Drawing.Point(9, 122);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(51, 18);
            this.LblStreet.TabIndex = 19;
            this.LblStreet.Text = "Street:";
            // 
            // GrpBoxBookingNotes
            // 
            this.GrpBoxBookingNotes.Controls.Add(this.TxtBookingNotes);
            this.GrpBoxBookingNotes.Location = new System.Drawing.Point(140, 3);
            this.GrpBoxBookingNotes.Name = "GrpBoxBookingNotes";
            this.GrpBoxBookingNotes.Size = new System.Drawing.Size(956, 66);
            this.GrpBoxBookingNotes.TabIndex = 4;
            this.GrpBoxBookingNotes.TabStop = false;
            this.GrpBoxBookingNotes.Text = "Booking Notes";
            // 
            // TxtBookingNotes
            // 
            this.TxtBookingNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.TxtBookingNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookingNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.TxtBookingNotes.Location = new System.Drawing.Point(6, 19);
            this.TxtBookingNotes.MaxLength = 750;
            this.TxtBookingNotes.Multiline = true;
            this.TxtBookingNotes.Name = "TxtBookingNotes";
            this.TxtBookingNotes.ReadOnly = true;
            this.TxtBookingNotes.Size = new System.Drawing.Size(944, 41);
            this.TxtBookingNotes.TabIndex = 0;
            // 
            // ZubosFrmViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1108, 767);
            this.Controls.Add(this.GrpBoxBookingNotes);
            this.Controls.Add(this.GrpBoxCustomer);
            this.Controls.Add(this.GrpBoxRoom);
            this.Controls.Add(this.BtnEditBooking);
            this.Controls.Add(this.DgvBookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ZubosFrmViewBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Bookings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ZubosFrmViewBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookings)).EndInit();
            this.GrpBoxRoom.ResumeLayout(false);
            this.GrpBoxRoom.PerformLayout();
            this.GrpBoxCustomer.ResumeLayout(false);
            this.GrpBoxCustomer.PerformLayout();
            this.GrpBoxBookingNotes.ResumeLayout(false);
            this.GrpBoxBookingNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBookings;
        private System.Windows.Forms.Button BtnEditBooking;
        private System.Windows.Forms.GroupBox GrpBoxRoom;
        private System.Windows.Forms.GroupBox GrpBoxCustomer;
        private System.Windows.Forms.TextBox TxtAdditionalInfo;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtRoomNumber;
        private System.Windows.Forms.TextBox TxtRoomName;
        private System.Windows.Forms.Label LblExtraRoomDetail;
        private System.Windows.Forms.Label LblNumberRoomDetail;
        private System.Windows.Forms.Label LblPriceRoomDetail;
        private System.Windows.Forms.Label LblNameRoomDetail;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblPostcode;
        private System.Windows.Forms.Label LblHouseNumber;
        private System.Windows.Forms.Label LblHouseName;
        private System.Windows.Forms.Label LblStreet;
        private System.Windows.Forms.TextBox TxtPostcode;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.TextBox TxtHouseName;
        private System.Windows.Forms.TextBox TxtHouseNumb;
        private System.Windows.Forms.TextBox TxtCustName;
        private System.Windows.Forms.GroupBox GrpBoxBookingNotes;
        private System.Windows.Forms.TextBox TxtBookingNotes;
    }
}