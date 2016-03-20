namespace Zubos_System
{
    partial class ZubosFrmEditBooking
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
            this.GrpBoxRoomDetail = new System.Windows.Forms.GroupBox();
            this.TxtDays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.LblDateTo = new System.Windows.Forms.Label();
            this.DtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.LblNameRoomDetail = new System.Windows.Forms.Label();
            this.TxtBookingID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAdditionalInfo = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblExtraRoomDetail = new System.Windows.Forms.Label();
            this.LblPriceRoomDetail = new System.Windows.Forms.Label();
            this.TxtRoomID = new System.Windows.Forms.TextBox();
            this.LblRoomID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAssignRoom = new System.Windows.Forms.Button();
            this.TxtRoomName = new System.Windows.Forms.TextBox();
            this.LblRoomName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAssignCust = new System.Windows.Forms.Button();
            this.TxtCustName = new System.Windows.Forms.TextBox();
            this.LblCustname = new System.Windows.Forms.Label();
            this.TxtCustID = new System.Windows.Forms.TextBox();
            this.LblCustID = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.GrpBoxRoomDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxRoomDetail
            // 
            this.GrpBoxRoomDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.GrpBoxRoomDetail.Controls.Add(this.TxtDays);
            this.GrpBoxRoomDetail.Controls.Add(this.label3);
            this.GrpBoxRoomDetail.Controls.Add(this.DtpDateTo);
            this.GrpBoxRoomDetail.Controls.Add(this.LblDateTo);
            this.GrpBoxRoomDetail.Controls.Add(this.DtpDateFrom);
            this.GrpBoxRoomDetail.Controls.Add(this.LblNameRoomDetail);
            this.GrpBoxRoomDetail.Controls.Add(this.TxtBookingID);
            this.GrpBoxRoomDetail.Controls.Add(this.label1);
            this.GrpBoxRoomDetail.Controls.Add(this.TxtAdditionalInfo);
            this.GrpBoxRoomDetail.Controls.Add(this.TxtPrice);
            this.GrpBoxRoomDetail.Controls.Add(this.LblExtraRoomDetail);
            this.GrpBoxRoomDetail.Controls.Add(this.LblPriceRoomDetail);
            this.GrpBoxRoomDetail.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxRoomDetail.Location = new System.Drawing.Point(12, 9);
            this.GrpBoxRoomDetail.Name = "GrpBoxRoomDetail";
            this.GrpBoxRoomDetail.Size = new System.Drawing.Size(373, 243);
            this.GrpBoxRoomDetail.TabIndex = 3;
            this.GrpBoxRoomDetail.TabStop = false;
            this.GrpBoxRoomDetail.Text = "Room Details";
            // 
            // TxtDays
            // 
            this.TxtDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDays.Location = new System.Drawing.Point(117, 87);
            this.TxtDays.MaxLength = 2;
            this.TxtDays.Name = "TxtDays";
            this.TxtDays.Size = new System.Drawing.Size(51, 22);
            this.TxtDays.TabIndex = 40;
            this.TxtDays.TextChanged += new System.EventHandler(this.TxtDays_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Duration(Days):";
            // 
            // DtpDateTo
            // 
            this.DtpDateTo.Enabled = false;
            this.DtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.DtpDateTo.Location = new System.Drawing.Point(117, 113);
            this.DtpDateTo.Name = "DtpDateTo";
            this.DtpDateTo.Size = new System.Drawing.Size(180, 22);
            this.DtpDateTo.TabIndex = 38;
            // 
            // LblDateTo
            // 
            this.LblDateTo.AutoSize = true;
            this.LblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateTo.Location = new System.Drawing.Point(6, 114);
            this.LblDateTo.Name = "LblDateTo";
            this.LblDateTo.Size = new System.Drawing.Size(65, 18);
            this.LblDateTo.TabIndex = 37;
            this.LblDateTo.Text = "Date To:";
            // 
            // DtpDateFrom
            // 
            this.DtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.DtpDateFrom.Location = new System.Drawing.Point(117, 59);
            this.DtpDateFrom.Name = "DtpDateFrom";
            this.DtpDateFrom.Size = new System.Drawing.Size(180, 22);
            this.DtpDateFrom.TabIndex = 36;
            this.DtpDateFrom.ValueChanged += new System.EventHandler(this.DtpDateFrom_ValueChanged);
            // 
            // LblNameRoomDetail
            // 
            this.LblNameRoomDetail.AutoSize = true;
            this.LblNameRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameRoomDetail.Location = new System.Drawing.Point(6, 60);
            this.LblNameRoomDetail.Name = "LblNameRoomDetail";
            this.LblNameRoomDetail.Size = new System.Drawing.Size(78, 18);
            this.LblNameRoomDetail.TabIndex = 35;
            this.LblNameRoomDetail.Text = "Date Start:";
            // 
            // TxtBookingID
            // 
            this.TxtBookingID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBookingID.Enabled = false;
            this.TxtBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookingID.Location = new System.Drawing.Point(117, 30);
            this.TxtBookingID.MaxLength = 300;
            this.TxtBookingID.Name = "TxtBookingID";
            this.TxtBookingID.ReadOnly = true;
            this.TxtBookingID.Size = new System.Drawing.Size(92, 22);
            this.TxtBookingID.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Booking ID:";
            // 
            // TxtAdditionalInfo
            // 
            this.TxtAdditionalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdditionalInfo.Location = new System.Drawing.Point(117, 167);
            this.TxtAdditionalInfo.MaxLength = 500;
            this.TxtAdditionalInfo.Multiline = true;
            this.TxtAdditionalInfo.Name = "TxtAdditionalInfo";
            this.TxtAdditionalInfo.Size = new System.Drawing.Size(246, 65);
            this.TxtAdditionalInfo.TabIndex = 32;
            // 
            // TxtPrice
            // 
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(117, 139);
            this.TxtPrice.MaxLength = 300;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(78, 22);
            this.TxtPrice.TabIndex = 31;
            // 
            // LblExtraRoomDetail
            // 
            this.LblExtraRoomDetail.AutoSize = true;
            this.LblExtraRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExtraRoomDetail.Location = new System.Drawing.Point(6, 167);
            this.LblExtraRoomDetail.Name = "LblExtraRoomDetail";
            this.LblExtraRoomDetail.Size = new System.Drawing.Size(52, 18);
            this.LblExtraRoomDetail.TabIndex = 28;
            this.LblExtraRoomDetail.Text = "Notes:";
            // 
            // LblPriceRoomDetail
            // 
            this.LblPriceRoomDetail.AutoSize = true;
            this.LblPriceRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPriceRoomDetail.Location = new System.Drawing.Point(6, 140);
            this.LblPriceRoomDetail.Name = "LblPriceRoomDetail";
            this.LblPriceRoomDetail.Size = new System.Drawing.Size(46, 18);
            this.LblPriceRoomDetail.TabIndex = 26;
            this.LblPriceRoomDetail.Text = "Price:";
            // 
            // TxtRoomID
            // 
            this.TxtRoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomID.Location = new System.Drawing.Point(58, 26);
            this.TxtRoomID.MaxLength = 300;
            this.TxtRoomID.Name = "TxtRoomID";
            this.TxtRoomID.ReadOnly = true;
            this.TxtRoomID.Size = new System.Drawing.Size(66, 22);
            this.TxtRoomID.TabIndex = 30;
            // 
            // LblRoomID
            // 
            this.LblRoomID.AutoSize = true;
            this.LblRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoomID.Location = new System.Drawing.Point(6, 27);
            this.LblRoomID.Name = "LblRoomID";
            this.LblRoomID.Size = new System.Drawing.Size(26, 18);
            this.LblRoomID.TabIndex = 27;
            this.LblRoomID.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAssignRoom);
            this.groupBox1.Controls.Add(this.TxtRoomName);
            this.groupBox1.Controls.Add(this.LblRoomName);
            this.groupBox1.Controls.Add(this.TxtRoomID);
            this.groupBox1.Controls.Add(this.LblRoomID);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(391, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 122);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room";
            // 
            // BtnAssignRoom
            // 
            this.BtnAssignRoom.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnAssignRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAssignRoom.Font = new System.Drawing.Font("LuzSans-Book", 7.5F, System.Drawing.FontStyle.Bold);
            this.BtnAssignRoom.Location = new System.Drawing.Point(44, 87);
            this.BtnAssignRoom.Name = "BtnAssignRoom";
            this.BtnAssignRoom.Size = new System.Drawing.Size(133, 28);
            this.BtnAssignRoom.TabIndex = 33;
            this.BtnAssignRoom.Text = "Assign Room";
            this.BtnAssignRoom.UseVisualStyleBackColor = false;
            // 
            // TxtRoomName
            // 
            this.TxtRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomName.Location = new System.Drawing.Point(58, 57);
            this.TxtRoomName.MaxLength = 300;
            this.TxtRoomName.Name = "TxtRoomName";
            this.TxtRoomName.ReadOnly = true;
            this.TxtRoomName.Size = new System.Drawing.Size(153, 22);
            this.TxtRoomName.TabIndex = 32;
            // 
            // LblRoomName
            // 
            this.LblRoomName.AutoSize = true;
            this.LblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoomName.Location = new System.Drawing.Point(6, 59);
            this.LblRoomName.Name = "LblRoomName";
            this.LblRoomName.Size = new System.Drawing.Size(52, 18);
            this.LblRoomName.TabIndex = 31;
            this.LblRoomName.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAssignCust);
            this.groupBox2.Controls.Add(this.TxtCustName);
            this.groupBox2.Controls.Add(this.LblCustname);
            this.groupBox2.Controls.Add(this.TxtCustID);
            this.groupBox2.Controls.Add(this.LblCustID);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(391, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 119);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer";
            // 
            // BtnAssignCust
            // 
            this.BtnAssignCust.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnAssignCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAssignCust.Font = new System.Drawing.Font("LuzSans-Book", 7.5F, System.Drawing.FontStyle.Bold);
            this.BtnAssignCust.Location = new System.Drawing.Point(44, 85);
            this.BtnAssignCust.Name = "BtnAssignCust";
            this.BtnAssignCust.Size = new System.Drawing.Size(133, 28);
            this.BtnAssignCust.TabIndex = 34;
            this.BtnAssignCust.Text = "Assign Customer";
            this.BtnAssignCust.UseVisualStyleBackColor = false;
            // 
            // TxtCustName
            // 
            this.TxtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustName.Location = new System.Drawing.Point(58, 53);
            this.TxtCustName.MaxLength = 300;
            this.TxtCustName.Name = "TxtCustName";
            this.TxtCustName.ReadOnly = true;
            this.TxtCustName.Size = new System.Drawing.Size(153, 22);
            this.TxtCustName.TabIndex = 35;
            // 
            // LblCustname
            // 
            this.LblCustname.AutoSize = true;
            this.LblCustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustname.Location = new System.Drawing.Point(6, 55);
            this.LblCustname.Name = "LblCustname";
            this.LblCustname.Size = new System.Drawing.Size(52, 18);
            this.LblCustname.TabIndex = 34;
            this.LblCustname.Text = "Name:";
            // 
            // TxtCustID
            // 
            this.TxtCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustID.Location = new System.Drawing.Point(58, 25);
            this.TxtCustID.MaxLength = 300;
            this.TxtCustID.Name = "TxtCustID";
            this.TxtCustID.ReadOnly = true;
            this.TxtCustID.Size = new System.Drawing.Size(86, 22);
            this.TxtCustID.TabIndex = 32;
            // 
            // LblCustID
            // 
            this.LblCustID.AutoSize = true;
            this.LblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustID.Location = new System.Drawing.Point(6, 25);
            this.LblCustID.Name = "LblCustID";
            this.LblCustID.Size = new System.Drawing.Size(26, 18);
            this.LblCustID.TabIndex = 31;
            this.LblCustID.Text = "ID:";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirm.Font = new System.Drawing.Font("LuzSans-Book", 7.5F, System.Drawing.FontStyle.Bold);
            this.BtnConfirm.Location = new System.Drawing.Point(475, 258);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(133, 28);
            this.BtnConfirm.TabIndex = 36;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            // 
            // ZubosFrmEditBooking
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(624, 295);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpBoxRoomDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZubosFrmEditBooking";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Booking";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ZubosFrmEditBooking_Load);
            this.GrpBoxRoomDetail.ResumeLayout(false);
            this.GrpBoxRoomDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxRoomDetail;
        private System.Windows.Forms.TextBox TxtAdditionalInfo;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtRoomID;
        private System.Windows.Forms.Label LblExtraRoomDetail;
        private System.Windows.Forms.Label LblRoomID;
        private System.Windows.Forms.Label LblPriceRoomDetail;
        private System.Windows.Forms.TextBox TxtBookingID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpDateTo;
        private System.Windows.Forms.Label LblDateTo;
        private System.Windows.Forms.DateTimePicker DtpDateFrom;
        private System.Windows.Forms.Label LblNameRoomDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtCustID;
        private System.Windows.Forms.Label LblCustID;
        private System.Windows.Forms.TextBox TxtRoomName;
        private System.Windows.Forms.Label LblRoomName;
        private System.Windows.Forms.Button BtnAssignRoom;
        private System.Windows.Forms.TextBox TxtCustName;
        private System.Windows.Forms.Label LblCustname;
        private System.Windows.Forms.Button BtnAssignCust;
        private System.Windows.Forms.Button BtnConfirm;
    }
}