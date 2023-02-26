using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    public partial class JobSheet : UserControl
    {
        public JobSheet()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpID.Clear();
            txtPhoneNumber.Clear();
            txtWorkDone.Clear();
            txtAction.Clear();
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "" || txtEmpID.Text == "" || txtWorkDone.Text == "")
            {
                MessageBox.Show("Please fill in employee ID, phone number & work to be done");
            }
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {

                        sw.WriteLineAsync("JAPTECH JOB SHEET");
                        sw.WriteLine("----------------------------------------");
                        sw.WriteLine("Date: \t\t\t\t\t" + dateTimePicker1.Value);
                        sw.WriteLine("Work to be done: \t\t\t" + txtWorkDone.Text);
                        sw.WriteLine("Call this number for any enquiries: \t" + txtPhoneNumber.Text);
                        sw.WriteLine("Further action required: \t\t" + txtAction.Text);
                        sw.WriteLine("----------------------------------------");
                        sw.WriteLine("Signature: ___________");
                        MessageBox.Show("The job sheet has been successfully created");
                    }
                }
            }
        }
    }
}
