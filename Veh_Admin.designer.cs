
namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    partial class Veh_Admin
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
            this.components = new System.ComponentModel.Container();
            this.btnShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.fLEET_MANAGEMENT_DATABASEDataSet = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.FLEET_MANAGEMENT_DATABASEDataSet();
            this.fLEETMANAGEMENTDATABASEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLEET_MANAGEMENT_DATABASEDataSet2 = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.FLEET_MANAGEMENT_DATABASEDataSet2();
            this.vehiclesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new JAPTECH_FLEET_MANAGEMENT_SYSTEM.FLEET_MANAGEMENT_DATABASEDataSet2TableAdapters.VehiclesTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTankLitresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEET_MANAGEMENT_DATABASEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEETMANAGEMENTDATABASEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEET_MANAGEMENT_DATABASEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShow.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Location = new System.Drawing.Point(37, 410);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(134, 30);
            this.btnShow.TabIndex = 43;
            this.btnShow.Text = "SHOW RECORDS";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(173, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 85);
            this.label3.TabIndex = 31;
            this.label3.Text = "VEHICLE RECORDS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(762, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.CurrentChanged += new System.EventHandler(this.vehiclesBindingSource_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.vehicleTankLitresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehiclesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(37, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 294);
            this.dataGridView1.TabIndex = 29;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(212, 410);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // fLEET_MANAGEMENT_DATABASEDataSet2
            // 
            this.fLEET_MANAGEMENT_DATABASEDataSet2.DataSetName = "FLEET_MANAGEMENT_DATABASEDataSet2";
            this.fLEET_MANAGEMENT_DATABASEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclesBindingSource1
            // 
            this.vehiclesBindingSource1.DataMember = "Vehicles";
            this.vehiclesBindingSource1.DataSource = this.fLEET_MANAGEMENT_DATABASEDataSet2;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Vehicle_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vehicle_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Employee_Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee_Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vehicle_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vehicle_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vehicle_Model";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vehicle_Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vehicle_Color";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vehicle_Color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // vehicleTankLitresDataGridViewTextBoxColumn
            // 
            this.vehicleTankLitresDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Tank_Litres";
            this.vehicleTankLitresDataGridViewTextBoxColumn.HeaderText = "Vehicle_Tank_Litres";
            this.vehicleTankLitresDataGridViewTextBoxColumn.Name = "vehicleTankLitresDataGridViewTextBoxColumn";
            // 
            // Veh_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Veh_Admin";
            this.Text = "Veh_Admin";
            this.Load += new System.EventHandler(this.Veh_Admin_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEET_MANAGEMENT_DATABASEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEETMANAGEMENTDATABASEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEET_MANAGEMENT_DATABASEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource fLEETMANAGEMENTDATABASEDataSetBindingSource;
        private FLEET_MANAGEMENT_DATABASEDataSet fLEET_MANAGEMENT_DATABASEDataSet;
        private FLEET_MANAGEMENT_DATABASEDataSet2 fLEET_MANAGEMENT_DATABASEDataSet2;
        private System.Windows.Forms.BindingSource vehiclesBindingSource1;
        private FLEET_MANAGEMENT_DATABASEDataSet2TableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTankLitresDataGridViewTextBoxColumn;
    }
}