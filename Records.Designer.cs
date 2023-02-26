
namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    partial class Records
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
            this.components = new System.ComponentModel.Container();
            this.cmbRecords = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridViewRec = new System.Windows.Forms.DataGridView();
            this.fLEET_MANAGEMENT_DATABASEDataSet = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.FLEET_MANAGEMENT_DATABASEDataSet();
            this.fLEETMANAGEMENTDATABASEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEET_MANAGEMENT_DATABASEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEETMANAGEMENTDATABASEDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRecords
            // 
            this.cmbRecords.FormattingEnabled = true;
            this.cmbRecords.Items.AddRange(new object[] {
            "Customer Records",
            "Vehicle Records",
            "Employee Attendance",
            "Trip Records",
            "Incident Records",
            "Payments"});
            this.cmbRecords.Location = new System.Drawing.Point(424, 45);
            this.cmbRecords.Name = "cmbRecords";
            this.cmbRecords.Size = new System.Drawing.Size(143, 21);
            this.cmbRecords.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(424, 93);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(143, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // dataGridViewRec
            // 
            this.dataGridViewRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRec.Location = new System.Drawing.Point(172, 146);
            this.dataGridViewRec.Name = "dataGridViewRec";
            this.dataGridViewRec.Size = new System.Drawing.Size(649, 239);
            this.dataGridViewRec.TabIndex = 2;
            // 
            // fLEET_MANAGEMENT_DATABASEDataSet
            // 
            this.fLEET_MANAGEMENT_DATABASEDataSet.DataSetName = "FLEET_MANAGEMENT_DATABASEDataSet";
            this.fLEET_MANAGEMENT_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fLEETMANAGEMENTDATABASEDataSetBindingSource
            // 
            this.fLEETMANAGEMENTDATABASEDataSetBindingSource.DataSource = this.fLEET_MANAGEMENT_DATABASEDataSet;
            this.fLEETMANAGEMENTDATABASEDataSetBindingSource.Position = 0;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dataGridViewRec);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.cmbRecords);
            this.Name = "Records";
            this.Size = new System.Drawing.Size(942, 419);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEET_MANAGEMENT_DATABASEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEETMANAGEMENTDATABASEDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRecords;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridViewRec;
        private FLEET_MANAGEMENT_DATABASEDataSet fLEET_MANAGEMENT_DATABASEDataSet;
        private System.Windows.Forms.BindingSource fLEETMANAGEMENTDATABASEDataSetBindingSource;
    }
}
