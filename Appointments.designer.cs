
namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    partial class Appointments
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
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnJobSheets = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.appointmentsScreen1 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.AppointmentsScreen();
            this.jobSheet1 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.JobSheet();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.appointmentsScreen1);
            this.panel1.Controls.Add(this.jobSheet1);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 416);
            this.panel1.TabIndex = 2;
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAppointments.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAppointments.Location = new System.Drawing.Point(3, 3);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(202, 35);
            this.btnAppointments.TabIndex = 3;
            this.btnAppointments.Text = "APPOINTMENTS";
            this.btnAppointments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnJobSheets
            // 
            this.btnJobSheets.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnJobSheets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJobSheets.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobSheets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJobSheets.Location = new System.Drawing.Point(211, 3);
            this.btnJobSheets.Name = "btnJobSheets";
            this.btnJobSheets.Size = new System.Drawing.Size(193, 35);
            this.btnJobSheets.TabIndex = 4;
            this.btnJobSheets.Text = "JOB SHEETS";
            this.btnJobSheets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJobSheets.UseVisualStyleBackColor = false;
            this.btnJobSheets.Click += new System.EventHandler(this.btnJobSheets_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnAppointments);
            this.panel2.Controls.Add(this.btnJobSheets);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 38);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(762, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // appointmentsScreen1
            // 
            this.appointmentsScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentsScreen1.Location = new System.Drawing.Point(0, 0);
            this.appointmentsScreen1.Name = "appointmentsScreen1";
            this.appointmentsScreen1.Size = new System.Drawing.Size(801, 416);
            this.appointmentsScreen1.TabIndex = 1;
            this.appointmentsScreen1.Load += new System.EventHandler(this.appointmentsScreen1_Load);
            // 
            // jobSheet1
            // 
            this.jobSheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobSheet1.Location = new System.Drawing.Point(0, 0);
            this.jobSheet1.Name = "jobSheet1";
            this.jobSheet1.Size = new System.Drawing.Size(801, 416);
            this.jobSheet1.TabIndex = 0;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnJobSheets;
        private System.Windows.Forms.Panel panel2;
        private JobSheet jobSheet1;
        private AppointmentsScreen appointmentsScreen1;
        private System.Windows.Forms.Label label7;
    }
}