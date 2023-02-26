using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    public partial class Emergencies : UserControl
    {
        public Emergencies()
        {
            InitializeComponent();
        }

        private void btGetData_Click(object sender, EventArgs e)
        {
            string mainconn = "Data Source = LAPTOP-31H3BH8T\\SQLEXPRESS; Initial Catalog = FLEET MANAGEMENT DATABASE; Integrated Security = True";
            SqlConnection conn = new SqlConnection(mainconn);

            conn.Open();
            // if (btnTripId.Text != "")
            // {
            SqlCommand command = new SqlCommand("select Vehicle_Id, Employee_Id From Trips where Trip_Id = @Trip_Id", conn);
            command.Parameters.AddWithValue("@Trip_Id ", btnTripId.Text);
            SqlDataReader dataReader1 = command.ExecuteReader();
            while (dataReader1.Read())
            {
                txtVehReg.Text = dataReader1.GetValue(0).ToString();
                txtDriverID.Text = dataReader1.GetValue(1).ToString();

            }
            conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string mainconn = "Data Source = LAPTOP - 31H3BH8T\\SQLEXPRESS; Initial Catalog = FLEET MANAGEMENT DATABASE; Integrated Security = True";
            SqlConnection conn = new SqlConnection(mainconn);

            string cmds = $" insert into Emergancies values (@Date_Of_Incident, @Incident, @Incident_Description, @Trip_Id ) ";
            SqlCommand command = new SqlCommand(cmds, conn);
            conn.Open();
            command.Parameters.AddWithValue("@Date_Of_Incident", Convert.ToDateTime(dateTimePickerEm.Value.ToString().Trim()));
            command.Parameters.AddWithValue("@Incident", cmbIncident.SelectedItem.ToString().Trim());
            command.Parameters.AddWithValue("@Incident_Description ", txtIncDescrip.Text.Trim());

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data inserted successfully");
        }
    }
}
