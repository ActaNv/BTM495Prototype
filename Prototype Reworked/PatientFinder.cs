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
    public partial class PatientFinder : UserControl
    {
        public PatientFinder()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.FillBy(this.dataSet1.Patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void PatientFinder_Load(object sender, EventArgs e)
        {
            this.patientTableAdapter.Fill(this.dataSet1.Patient);
    

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.EndEdit();
            this.patientTableAdapter.Update(dataSet1.Patient);

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPatientNumber_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgPatient.DataSource;
            bs.Filter = "PhoneNumber like '%" + txtPatientNumber.Text + "%'";
            dtgPatient.DataSource = bs;
        }
    }
}
