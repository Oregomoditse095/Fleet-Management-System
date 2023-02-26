
namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    partial class TripManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.emergencybtn = new System.Windows.Forms.Button();
            this.recordbtn = new System.Windows.Forms.Button();
            this.bookingbtn = new System.Windows.Forms.Button();
            this.custRegbtn = new System.Windows.Forms.Button();
            this.emergencies1 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.Emergencies();
            this.recordings1 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.Recordings();
            this.tripBookings1 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.TripBookings();
            this.custRegcs1 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.custRegcs();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.emergencies1);
            this.panel1.Controls.Add(this.recordings1);
            this.panel1.Controls.Add(this.tripBookings1);
            this.panel1.Controls.Add(this.custRegcs1);
            this.panel1.Location = new System.Drawing.Point(3, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 458);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.lblExit);
            this.panel2.Controls.Add(this.emergencybtn);
            this.panel2.Controls.Add(this.recordbtn);
            this.panel2.Controls.Add(this.bookingbtn);
            this.panel2.Controls.Add(this.custRegbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 37);
            this.panel2.TabIndex = 1;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExit.Location = new System.Drawing.Point(932, 4);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(26, 25);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // emergencybtn
            // 
            this.emergencybtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.emergencybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emergencybtn.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencybtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emergencybtn.Location = new System.Drawing.Point(600, 4);
            this.emergencybtn.Name = "emergencybtn";
            this.emergencybtn.Size = new System.Drawing.Size(193, 31);
            this.emergencybtn.TabIndex = 3;
            this.emergencybtn.Text = "EMERGENCIES";
            this.emergencybtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emergencybtn.UseVisualStyleBackColor = false;
            this.emergencybtn.Click += new System.EventHandler(this.emergencybtn_Click);
            // 
            // recordbtn
            // 
            this.recordbtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.recordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recordbtn.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recordbtn.Location = new System.Drawing.Point(401, 3);
            this.recordbtn.Name = "recordbtn";
            this.recordbtn.Size = new System.Drawing.Size(193, 31);
            this.recordbtn.TabIndex = 2;
            this.recordbtn.Text = "RECORDINGS";
            this.recordbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.recordbtn.UseVisualStyleBackColor = false;
            this.recordbtn.Click += new System.EventHandler(this.recordbtn_Click);
            // 
            // bookingbtn
            // 
            this.bookingbtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bookingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookingbtn.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookingbtn.Location = new System.Drawing.Point(202, 3);
            this.bookingbtn.Name = "bookingbtn";
            this.bookingbtn.Size = new System.Drawing.Size(193, 31);
            this.bookingbtn.TabIndex = 1;
            this.bookingbtn.Text = "BOOKING PORTAL";
            this.bookingbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookingbtn.UseVisualStyleBackColor = false;
            this.bookingbtn.Click += new System.EventHandler(this.bookingbtn_Click);
            // 
            // custRegbtn
            // 
            this.custRegbtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.custRegbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.custRegbtn.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custRegbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custRegbtn.Location = new System.Drawing.Point(3, 3);
            this.custRegbtn.Name = "custRegbtn";
            this.custRegbtn.Size = new System.Drawing.Size(193, 31);
            this.custRegbtn.TabIndex = 0;
            this.custRegbtn.Text = "REGISTRATION";
            this.custRegbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.custRegbtn.UseVisualStyleBackColor = false;
            this.custRegbtn.Click += new System.EventHandler(this.custRegbtn_Click);
            // 
            // emergencies1
            // 
            this.emergencies1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emergencies1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emergencies1.Location = new System.Drawing.Point(0, 0);
            this.emergencies1.Name = "emergencies1";
            this.emergencies1.Size = new System.Drawing.Size(955, 458);
            this.emergencies1.TabIndex = 3;
            // 
            // recordings1
            // 
            this.recordings1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recordings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordings1.Location = new System.Drawing.Point(0, 0);
            this.recordings1.Name = "recordings1";
            this.recordings1.Size = new System.Drawing.Size(955, 458);
            this.recordings1.TabIndex = 2;
            // 
            // tripBookings1
            // 
            this.tripBookings1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tripBookings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tripBookings1.Location = new System.Drawing.Point(0, 0);
            this.tripBookings1.Name = "tripBookings1";
            this.tripBookings1.Size = new System.Drawing.Size(955, 458);
            this.tripBookings1.TabIndex = 1;
            // 
            // custRegcs1
            // 
            this.custRegcs1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custRegcs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custRegcs1.Location = new System.Drawing.Point(0, 0);
            this.custRegcs1.Name = "custRegcs1";
            this.custRegcs1.Size = new System.Drawing.Size(955, 458);
            this.custRegcs1.TabIndex = 0;
            // 
            // TripManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TripManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TripManager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button recordbtn;
        private System.Windows.Forms.Button bookingbtn;
        private System.Windows.Forms.Button custRegbtn;
        private System.Windows.Forms.Button emergencybtn;
        private custRegcs custRegcs1;
        private Recordings recordings1;
        private TripBookings tripBookings1;
        private Emergencies emergencies1;
        private System.Windows.Forms.Label lblExit;
    }
}