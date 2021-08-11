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
    public partial class Appointments : UserControl
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            this.appointmentTableAdapter.Fill(this.dataSet1.Appointment);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.appointmentTableAdapter.AppointmentDate(this.dataSet1.Appointment, dtTimePicker.Value.ToString());

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.appointmentTableAdapter.Fill(this.dataSet1.Appointment);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.appointmentBindingSource.EndEdit();
            this.appointmentTableAdapter.Update(dataSet1.Appointment);
        }
    }
}
