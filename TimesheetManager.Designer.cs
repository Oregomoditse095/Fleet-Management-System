
namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    partial class TimesheetManager
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnViewTs = new System.Windows.Forms.Button();
            this.btnUpdateTs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewTimesheet1 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.ViewTimesheet();
            this.updateTimesheet1 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.UpdateTimesheet();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.lblExit);
            this.panel2.Controls.Add(this.btnViewTs);
            this.panel2.Controls.Add(this.btnUpdateTs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 39);
            this.panel2.TabIndex = 2;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExit.Location = new System.Drawing.Point(916, 3);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(26, 25);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnViewTs
            // 
            this.btnViewTs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnViewTs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewTs.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewTs.Location = new System.Drawing.Point(202, 3);
            this.btnViewTs.Name = "btnViewTs";
            this.btnViewTs.Size = new System.Drawing.Size(193, 31);
            this.btnViewTs.TabIndex = 1;
            this.btnViewTs.Text = "VIEW TIMESHEET";
            this.btnViewTs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewTs.UseVisualStyleBackColor = false;
            this.btnViewTs.Click += new System.EventHandler(this.btnViewTs_Click);
            // 
            // btnUpdateTs
            // 
            this.btnUpdateTs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUpdateTs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateTs.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateTs.Location = new System.Drawing.Point(3, 3);
            this.btnUpdateTs.Name = "btnUpdateTs";
            this.btnUpdateTs.Size = new System.Drawing.Size(193, 31);
            this.btnUpdateTs.TabIndex = 0;
            this.btnUpdateTs.Text = "UPDATE TIMESHEET";
            this.btnUpdateTs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateTs.UseVisualStyleBackColor = false;
            this.btnUpdateTs.Click += new System.EventHandler(this.BtnUpdateTs_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewTimesheet1);
            this.panel1.Controls.Add(this.updateTimesheet1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 422);
            this.panel1.TabIndex = 3;
            // 
            // viewTimesheet1
            // 
            this.viewTimesheet1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewTimesheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTimesheet1.Location = new System.Drawing.Point(0, 0);
            this.viewTimesheet1.Name = "viewTimesheet1";
            this.viewTimesheet1.Size = new System.Drawing.Size(945, 422);
            this.viewTimesheet1.TabIndex = 1;
            // 
            // updateTimesheet1
            // 
            this.updateTimesheet1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateTimesheet1.Location = new System.Drawing.Point(0, 0);
            this.updateTimesheet1.Name = "updateTimesheet1";
            this.updateTimesheet1.Size = new System.Drawing.Size(945, 422);
            this.updateTimesheet1.TabIndex = 0;
            // 
            // TimesheetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(945, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimesheetManager";
            this.Text = "TimesheetManager";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnViewTs;
        private System.Windows.Forms.Button btnUpdateTs;
        private System.Windows.Forms.Panel panel1;
        private ViewTimesheet viewTimesheet1;
        private UpdateTimesheet updateTimesheet1;
    }
}