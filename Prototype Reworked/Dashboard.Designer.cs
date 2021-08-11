
namespace Prototype_Reworked
{
    partial class Dashboard
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
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.dtApp = new System.Windows.Forms.DateTimePicker();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new Prototype_Reworked.DataSet1();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Prototype_Reworked.DataSet1TableAdapters.PatientTableAdapter();
            this.cbPhoneNumber = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Appointment Dashboard  ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 277);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cbPhoneNumber);
            this.tabPage1.Controls.Add(this.cbPatient);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.txtDetails);
            this.tabPage1.Controls.Add(this.txtTitle);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointment Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(551, 220);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 25);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.ForeColor = System.Drawing.Color.Black;
            this.txtDetails.Location = new System.Drawing.Point(19, 52);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(607, 123);
            this.txtDetails.TabIndex = 1;
            this.txtDetails.Text = "Appointment Details";
            // 
            // txtTitle
            // 
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(19, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(607, 22);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Appointment Title";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btnPrevious);
            this.tabPage2.Controls.Add(this.cbMinute);
            this.tabPage2.Controls.Add(this.cbHour);
            this.tabPage2.Controls.Add(this.dtApp);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Date/Time";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(551, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(470, 220);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 25);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // cbMinute
            // 
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Location = new System.Drawing.Point(145, 64);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(121, 23);
            this.cbMinute.TabIndex = 2;
            this.cbMinute.Text = "Minute";
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(18, 64);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(121, 23);
            this.cbHour.TabIndex = 1;
            this.cbHour.Text = "Hour";
            // 
            // dtApp
            // 
            this.dtApp.Location = new System.Drawing.Point(18, 27);
            this.dtApp.Name = "dtApp";
            this.dtApp.Size = new System.Drawing.Size(608, 22);
            this.dtApp.TabIndex = 0;
            // 
            // cbPatient
            // 
            this.cbPatient.DataSource = this.patientBindingSource;
            this.cbPatient.DisplayMember = "FirstName";
            this.cbPatient.ForeColor = System.Drawing.Color.Black;
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(19, 181);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(177, 23);
            this.cbPatient.TabIndex = 9;
            this.cbPatient.ValueMember = "PatientID";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dataSet1;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // cbPhoneNumber
            // 
            this.cbPhoneNumber.DataSource = this.patientBindingSource;
            this.cbPhoneNumber.DisplayMember = "PhoneNumber";
            this.cbPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.cbPhoneNumber.FormattingEnabled = true;
            this.cbPhoneNumber.Location = new System.Drawing.Point(202, 181);
            this.cbPhoneNumber.Name = "cbPhoneNumber";
            this.cbPhoneNumber.Size = new System.Drawing.Size(184, 23);
            this.cbPhoneNumber.TabIndex = 10;
            this.cbPhoneNumber.ValueMember = "PatientID";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(737, 405);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.DateTimePicker dtApp;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.ComboBox cbPhoneNumber;
    }
}
