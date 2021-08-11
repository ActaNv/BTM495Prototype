
namespace Prototype_Reworked
{
    partial class frmControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnFinder = new System.Windows.Forms.Button();
            this.appointments1 = new Prototype_Reworked.Appointments();
            this.dashboard1 = new Prototype_Reworked.Dashboard();
            this.newPatient1 = new Prototype_Reworked.NewPatient();
            this.patientFinder1 = new Prototype_Reworked.PatientFinder();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAppointments);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnNewPatient);
            this.panel1.Controls.Add(this.btnFinder);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 448);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 42);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.Location = new System.Drawing.Point(12, 297);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(130, 42);
            this.btnAppointments.TabIndex = 3;
            this.btnAppointments.Text = "Appointment Finder";
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(12, 207);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(130, 42);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Appointment Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Location = new System.Drawing.Point(12, 112);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(130, 42);
            this.btnNewPatient.TabIndex = 1;
            this.btnNewPatient.Text = "New Patient Form";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnFinder
            // 
            this.btnFinder.Location = new System.Drawing.Point(12, 29);
            this.btnFinder.Name = "btnFinder";
            this.btnFinder.Size = new System.Drawing.Size(130, 42);
            this.btnFinder.TabIndex = 0;
            this.btnFinder.Text = "Patient Finder";
            this.btnFinder.UseVisualStyleBackColor = true;
            this.btnFinder.Click += new System.EventHandler(this.btnFinder_Click);
            // 
            // appointments1
            // 
            this.appointments1.BackColor = System.Drawing.Color.White;
            this.appointments1.Location = new System.Drawing.Point(163, 9);
            this.appointments1.Name = "appointments1";
            this.appointments1.Size = new System.Drawing.Size(747, 420);
            this.appointments1.TabIndex = 4;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.White;
            this.dashboard1.Location = new System.Drawing.Point(163, 6);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(679, 423);
            this.dashboard1.TabIndex = 3;
            // 
            // newPatient1
            // 
            this.newPatient1.BackColor = System.Drawing.Color.White;
            this.newPatient1.Location = new System.Drawing.Point(163, 6);
            this.newPatient1.Name = "newPatient1";
            this.newPatient1.Size = new System.Drawing.Size(630, 438);
            this.newPatient1.TabIndex = 2;
            // 
            // patientFinder1
            // 
            this.patientFinder1.BackColor = System.Drawing.Color.White;
            this.patientFinder1.Location = new System.Drawing.Point(163, 6);
            this.patientFinder1.Name = "patientFinder1";
            this.patientFinder1.Size = new System.Drawing.Size(679, 423);
            this.patientFinder1.TabIndex = 1;
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 448);
            this.Controls.Add(this.appointments1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.newPatient1);
            this.Controls.Add(this.patientFinder1);
            this.Controls.Add(this.panel1);
            this.Name = "frmControl";
            this.Load += new System.EventHandler(this.frmControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnFinder;
        private PatientFinder patientFinder1;
        private NewPatient newPatient1;
        private Dashboard dashboard1;
        private Appointments appointments1;
    }
}

