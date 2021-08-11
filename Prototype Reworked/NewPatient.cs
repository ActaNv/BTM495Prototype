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
    public partial class NewPatient : UserControl
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.PatientTableAdapter f = new DataSet1TableAdapters.PatientTableAdapter();
            f.InsertPatient(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNumber.Text, txtEmail.Text, dtBirthDate.Value.ToString());
            
        }
    }
}
