
namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    partial class OfficeManager
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
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnDelegations = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delegations1 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.Delegations();
            this.records1 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.Records();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.lblExit);
            this.panel2.Controls.Add(this.btnRecords);
            this.panel2.Controls.Add(this.btnDelegations);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 39);
            this.panel2.TabIndex = 3;
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
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecords.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecords.Location = new System.Drawing.Point(202, 3);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(193, 31);
            this.btnRecords.TabIndex = 1;
            this.btnRecords.Text = "MANAGEMENT RECORDS";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnDelegations
            // 
            this.btnDelegations.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDelegations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelegations.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelegations.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelegations.Location = new System.Drawing.Point(3, 3);
            this.btnDelegations.Name = "btnDelegations";
            this.btnDelegations.Size = new System.Drawing.Size(193, 31);
            this.btnDelegations.TabIndex = 0;
            this.btnDelegations.Text = "DELEGATIONS";
            this.btnDelegations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelegations.UseVisualStyleBackColor = false;
            this.btnDelegations.Click += new System.EventHandler(this.btnDelegations_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delegations1);
            this.panel1.Controls.Add(this.records1);
            this.panel1.Location = new System.Drawing.Point(3, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 419);
            this.panel1.TabIndex = 4;
            // 
            // delegations1
            // 
            this.delegations1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delegations1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delegations1.Location = new System.Drawing.Point(0, 0);
            this.delegations1.Name = "delegations1";
            this.delegations1.Size = new System.Drawing.Size(942, 419);
            this.delegations1.TabIndex = 1;
            // 
            // records1
            // 
            this.records1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.records1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.records1.Location = new System.Drawing.Point(0, 0);
            this.records1.Name = "records1";
            this.records1.Size = new System.Drawing.Size(942, 419);
            this.records1.TabIndex = 0;
            // 
            // OfficeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(945, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OfficeManager";
            this.Text = "OfficeManager";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnDelegations;
        private System.Windows.Forms.Panel panel1;
        private Delegations delegations1;
        private Records records1;
    }
}