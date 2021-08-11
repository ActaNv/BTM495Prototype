
namespace Prototype_Reworked
{
    partial class Appointments
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
            this.btnFind = new System.Windows.Forms.Button();
            this.dtgApp = new System.Windows.Forms.DataGridView();
            this.dtTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataSet1 = new Prototype_Reworked.DataSet1();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new Prototype_Reworked.DataSet1TableAdapters.AppointmentTableAdapter();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Appointment Finder";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(476, 6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(57, 26);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dtgApp
            // 
            this.dtgApp.AutoGenerateColumns = false;
            this.dtgApp.BackgroundColor = System.Drawing.Color.White;
            this.dtgApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appIDDataGridViewTextBoxColumn,
            this.appointmentTitleDataGridViewTextBoxColumn,
            this.appointmentDescriptionDataGridViewTextBoxColumn,
            this.appointmentDateDataGridViewTextBoxColumn,
            this.appointmentTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.attendanceDataGridViewCheckBoxColumn,
            this.patientIDDataGridViewTextBoxColumn});
            this.dtgApp.DataSource = this.appointmentBindingSource;
            this.dtgApp.Location = new System.Drawing.Point(14, 60);
            this.dtgApp.Name = "dtgApp";
            this.dtgApp.Size = new System.Drawing.Size(686, 282);
            this.dtgApp.TabIndex = 25;
            // 
            // dtTimePicker
            // 
            this.dtTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTimePicker.Location = new System.Drawing.Point(270, 6);
            this.dtTimePicker.Name = "dtTimePicker";
            this.dtTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dtTimePicker.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(625, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.dataSet1;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // appIDDataGridViewTextBoxColumn
            // 
            this.appIDDataGridViewTextBoxColumn.DataPropertyName = "appID";
            this.appIDDataGridViewTextBoxColumn.HeaderText = "appID";
            this.appIDDataGridViewTextBoxColumn.Name = "appIDDataGridViewTextBoxColumn";
            this.appIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentTitleDataGridViewTextBoxColumn
            // 
            this.appointmentTitleDataGridViewTextBoxColumn.DataPropertyName = "appointmentTitle";
            this.appointmentTitleDataGridViewTextBoxColumn.HeaderText = "appointmentTitle";
            this.appointmentTitleDataGridViewTextBoxColumn.Name = "appointmentTitleDataGridViewTextBoxColumn";
            // 
            // appointmentDescriptionDataGridViewTextBoxColumn
            // 
            this.appointmentDescriptionDataGridViewTextBoxColumn.DataPropertyName = "appointmentDescription";
            this.appointmentDescriptionDataGridViewTextBoxColumn.HeaderText = "appointmentDescription";
            this.appointmentDescriptionDataGridViewTextBoxColumn.Name = "appointmentDescriptionDataGridViewTextBoxColumn";
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "appointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "appointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            // 
            // appointmentTimeDataGridViewTextBoxColumn
            // 
            this.appointmentTimeDataGridViewTextBoxColumn.DataPropertyName = "appointmentTime";
            this.appointmentTimeDataGridViewTextBoxColumn.HeaderText = "appointmentTime";
            this.appointmentTimeDataGridViewTextBoxColumn.Name = "appointmentTimeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            // 
            // attendanceDataGridViewCheckBoxColumn
            // 
            this.attendanceDataGridViewCheckBoxColumn.DataPropertyName = "attendance";
            this.attendanceDataGridViewCheckBoxColumn.HeaderText = "attendance";
            this.attendanceDataGridViewCheckBoxColumn.Name = "attendanceDataGridViewCheckBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(544, 360);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtTimePicker);
            this.Controls.Add(this.dtgApp);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label4);
            this.Name = "Appointments";
            this.Size = new System.Drawing.Size(720, 420);
            this.Load += new System.EventHandler(this.Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dtgApp;
        private System.Windows.Forms.DateTimePicker dtTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn attendanceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.Button btnReset;
    }
}
