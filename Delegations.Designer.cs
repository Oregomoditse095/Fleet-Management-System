
namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    partial class Delegations
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delegations));
            this.btnTripMan = new System.Windows.Forms.Button();
            this.btnServiceMan = new System.Windows.Forms.Button();
            this.btnVehAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTripMan
            // 
            this.btnTripMan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTripMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTripMan.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripMan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTripMan.Image = ((System.Drawing.Image)(resources.GetObject("btnTripMan.Image")));
            this.btnTripMan.Location = new System.Drawing.Point(57, 83);
            this.btnTripMan.Name = "btnTripMan";
            this.btnTripMan.Size = new System.Drawing.Size(251, 226);
            this.btnTripMan.TabIndex = 2;
            this.btnTripMan.Text = "TRIP MANAGER";
            this.btnTripMan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTripMan.UseVisualStyleBackColor = false;
            this.btnTripMan.Click += new System.EventHandler(this.BtnTripMan_Click);
            // 
            // btnServiceMan
            // 
            this.btnServiceMan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnServiceMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServiceMan.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceMan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServiceMan.Image = ((System.Drawing.Image)(resources.GetObject("btnServiceMan.Image")));
            this.btnServiceMan.Location = new System.Drawing.Point(341, 83);
            this.btnServiceMan.Name = "btnServiceMan";
            this.btnServiceMan.Size = new System.Drawing.Size(251, 226);
            this.btnServiceMan.TabIndex = 3;
            this.btnServiceMan.Text = "SERVICE MANAGER";
            this.btnServiceMan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServiceMan.UseVisualStyleBackColor = false;
            this.btnServiceMan.Click += new System.EventHandler(this.BtnServiceMan_Click);
            // 
            // btnVehAdmin
            // 
            this.btnVehAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVehAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVehAdmin.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVehAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnVehAdmin.Image")));
            this.btnVehAdmin.Location = new System.Drawing.Point(624, 83);
            this.btnVehAdmin.Name = "btnVehAdmin";
            this.btnVehAdmin.Size = new System.Drawing.Size(251, 226);
            this.btnVehAdmin.TabIndex = 4;
            this.btnVehAdmin.Text = "VEHICLE ADMINISTRATOR";
            this.btnVehAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVehAdmin.UseVisualStyleBackColor = false;
            this.btnVehAdmin.Click += new System.EventHandler(this.BtnVehAdmin_Click);
            // 
            // Delegations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnVehAdmin);
            this.Controls.Add(this.btnServiceMan);
            this.Controls.Add(this.btnTripMan);
            this.Name = "Delegations";
            this.Size = new System.Drawing.Size(942, 419);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTripMan;
        private System.Windows.Forms.Button btnServiceMan;
        private System.Windows.Forms.Button btnVehAdmin;
    }
}
