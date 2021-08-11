using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_Reworked
{
    public partial class frmControl : MetroFramework.Forms.MetroForm
    {
        public frmControl()
        {
            InitializeComponent();
        }

        private void btnFinder_Click(object sender, EventArgs e)
        {
            newPatient1.Hide();
            dashboard1.Hide();
            appointments1.Hide();
            patientFinder1.Show();
            patientFinder1.BringToFront();

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            patientFinder1.Hide();
            dashboard1.Hide();
            appointments1.Hide();
            newPatient1.Show();
            newPatient1.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            newPatient1.Hide();
            patientFinder1.Hide();
            appointments1.Hide();
            dashboard1.Show();
            dashboard1.BringToFront();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            newPatient1.Hide();
            dashboard1.Hide();
            patientFinder1.Hide();
            appointments1.Show();
            appointments1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmControl_Load(object sender, EventArgs e)
        {
            //Open Patient Finder
            newPatient1.Hide();
            dashboard1.Hide();
            appointments1.Hide();
            patientFinder1.Show();
            patientFinder1.BringToFront();
        }
    }
}
