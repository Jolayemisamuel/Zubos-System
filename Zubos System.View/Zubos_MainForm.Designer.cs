namespace Zubos_System
{
    partial class Zubos_MainForm
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
            this.zMainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrpBoxNav = new System.Windows.Forms.GroupBox();
            this.GrpBoxAdmin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnExitApp = new System.Windows.Forms.Button();
            this.zMainStatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GrpBoxNav.SuspendLayout();
            this.GrpBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // zMainStatusStrip
            // 
            this.zMainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.zMainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus,
            this.toolStripStatusLabel1});
            this.zMainStatusStrip.Location = new System.Drawing.Point(0, 581);
            this.zMainStatusStrip.Name = "zMainStatusStrip";
            this.zMainStatusStrip.Size = new System.Drawing.Size(1008, 29);
            this.zMainStatusStrip.TabIndex = 3;
            this.zMainStatusStrip.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            this.LblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(796, 24);
            this.LblStatus.Spring = true;
            this.LblStatus.Text = "*/*";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(197, 24);
            this.toolStripStatusLabel1.Text = "Zubos Management System";
            this.toolStripStatusLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.GrpBoxNav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 581);
            this.panel1.TabIndex = 4;
            // 
            // GrpBoxNav
            // 
            this.GrpBoxNav.Controls.Add(this.GrpBoxAdmin);
            this.GrpBoxNav.Controls.Add(this.BtnExitApp);
            this.GrpBoxNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpBoxNav.Location = new System.Drawing.Point(0, 0);
            this.GrpBoxNav.Name = "GrpBoxNav";
            this.GrpBoxNav.Size = new System.Drawing.Size(211, 577);
            this.GrpBoxNav.TabIndex = 1;
            this.GrpBoxNav.TabStop = false;
            this.GrpBoxNav.Text = "Navigation";
            // 
            // GrpBoxAdmin
            // 
            this.GrpBoxAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxAdmin.Controls.Add(this.button1);
            this.GrpBoxAdmin.Location = new System.Drawing.Point(6, 23);
            this.GrpBoxAdmin.Name = "GrpBoxAdmin";
            this.GrpBoxAdmin.Size = new System.Drawing.Size(199, 226);
            this.GrpBoxAdmin.TabIndex = 8;
            this.GrpBoxAdmin.TabStop = false;
            this.GrpBoxAdmin.Text = "Admin";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(8, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "New Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnExitApp
            // 
            this.BtnExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExitApp.Location = new System.Drawing.Point(6, 529);
            this.BtnExitApp.Name = "BtnExitApp";
            this.BtnExitApp.Size = new System.Drawing.Size(199, 45);
            this.BtnExitApp.TabIndex = 7;
            this.BtnExitApp.Text = "Exit Zubos System";
            this.BtnExitApp.UseVisualStyleBackColor = true;
            this.BtnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            // 
            // Zubos_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 610);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zMainStatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Zubos_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zubos Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Zubos_MainForm_Load);
            this.zMainStatusStrip.ResumeLayout(false);
            this.zMainStatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.GrpBoxNav.ResumeLayout(false);
            this.GrpBoxAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip zMainStatusStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GrpBoxNav;
        private System.Windows.Forms.Button BtnExitApp;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox GrpBoxAdmin;
        private System.Windows.Forms.Button button1;
    }
}

