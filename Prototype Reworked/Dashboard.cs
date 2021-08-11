using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Prototype_Reworked
{
    
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.patientTableAdapter.Fill(this.dataSet1.Patient);
            tabControl1.SelectedTab = tabPage1;

            int h = 1;
            int m = 0;

            for (h = 1; h <= 24; h++)
                cbHour.Items.Add(h);
            for (m = 0; m < 60; m++)
                cbMinute.Items.Add(m);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                DataSet1TableAdapters.AppointmentTableAdapter b = new DataSet1TableAdapters.AppointmentTableAdapter();
                b.InsertAppointment(txtTitle.Text, txtDetails.Text, dtApp.Value, cbHour.Text + ":" + cbMinute.Text, (int)cbPatient.SelectedValue);
                MessageBox.Show("Saved");
        }
    }
}

