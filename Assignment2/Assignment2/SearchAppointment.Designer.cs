namespace Assignment2
{
    partial class SearchAppointment
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
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.dateTimePickerSelection = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.textBoxDoctorSpeciality = new System.Windows.Forms.TextBox();
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.labelDoctorSpeciality = new System.Windows.Forms.Label();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.dateTimePickerPatientBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.labelPatientBirthday = new System.Windows.Forms.Label();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxDate.SuspendLayout();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.buttonCancel);
            this.groupBoxDate.Controls.Add(this.buttonOk);
            this.groupBoxDate.Controls.Add(this.dateTimePickerSelection);
            this.groupBoxDate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(776, 100);
            this.groupBoxDate.TabIndex = 0;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Choose the date";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(666, 57);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(666, 21);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // dateTimePickerSelection
            // 
            this.dateTimePickerSelection.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSelection.Location = new System.Drawing.Point(35, 43);
            this.dateTimePickerSelection.Name = "dateTimePickerSelection";
            this.dateTimePickerSelection.Size = new System.Drawing.Size(181, 22);
            this.dateTimePickerSelection.TabIndex = 0;
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.textBoxDoctorSpeciality);
            this.groupBoxDoctor.Controls.Add(this.textBoxDoctorName);
            this.groupBoxDoctor.Controls.Add(this.labelDoctorSpeciality);
            this.groupBoxDoctor.Controls.Add(this.labelDoctorName);
            this.groupBoxDoctor.Location = new System.Drawing.Point(53, 274);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(200, 148);
            this.groupBoxDoctor.TabIndex = 1;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Doctor";
            // 
            // textBoxDoctorSpeciality
            // 
            this.textBoxDoctorSpeciality.Location = new System.Drawing.Point(94, 83);
            this.textBoxDoctorSpeciality.Name = "textBoxDoctorSpeciality";
            this.textBoxDoctorSpeciality.ReadOnly = true;
            this.textBoxDoctorSpeciality.Size = new System.Drawing.Size(100, 22);
            this.textBoxDoctorSpeciality.TabIndex = 5;
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Location = new System.Drawing.Point(94, 37);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.ReadOnly = true;
            this.textBoxDoctorName.Size = new System.Drawing.Size(100, 22);
            this.textBoxDoctorName.TabIndex = 4;
            this.textBoxDoctorName.TextChanged += new System.EventHandler(this.textBoxDoctorName_TextChanged);
            // 
            // labelDoctorSpeciality
            // 
            this.labelDoctorSpeciality.AutoSize = true;
            this.labelDoctorSpeciality.Location = new System.Drawing.Point(18, 89);
            this.labelDoctorSpeciality.Name = "labelDoctorSpeciality";
            this.labelDoctorSpeciality.Size = new System.Drawing.Size(66, 16);
            this.labelDoctorSpeciality.TabIndex = 4;
            this.labelDoctorSpeciality.Text = "Speciality";
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Location = new System.Drawing.Point(18, 40);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(44, 16);
            this.labelDoctorName.TabIndex = 0;
            this.labelDoctorName.Text = "Name";
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.dateTimePickerPatientBirthday);
            this.groupBoxPatient.Controls.Add(this.textBoxPatientName);
            this.groupBoxPatient.Controls.Add(this.labelPatientBirthday);
            this.groupBoxPatient.Controls.Add(this.labelPatientName);
            this.groupBoxPatient.Location = new System.Drawing.Point(520, 274);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(233, 148);
            this.groupBoxPatient.TabIndex = 2;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // dateTimePickerPatientBirthday
            // 
            this.dateTimePickerPatientBirthday.Checked = false;
            this.dateTimePickerPatientBirthday.Enabled = false;
            this.dateTimePickerPatientBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPatientBirthday.Location = new System.Drawing.Point(114, 84);
            this.dateTimePickerPatientBirthday.Name = "dateTimePickerPatientBirthday";
            this.dateTimePickerPatientBirthday.ShowUpDown = true;
            this.dateTimePickerPatientBirthday.Size = new System.Drawing.Size(113, 22);
            this.dateTimePickerPatientBirthday.TabIndex = 6;
            this.dateTimePickerPatientBirthday.TabStop = false;
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Location = new System.Drawing.Point(127, 37);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.ReadOnly = true;
            this.textBoxPatientName.Size = new System.Drawing.Size(100, 22);
            this.textBoxPatientName.TabIndex = 5;
            // 
            // labelPatientBirthday
            // 
            this.labelPatientBirthday.AutoSize = true;
            this.labelPatientBirthday.Location = new System.Drawing.Point(26, 89);
            this.labelPatientBirthday.Name = "labelPatientBirthday";
            this.labelPatientBirthday.Size = new System.Drawing.Size(65, 16);
            this.labelPatientBirthday.TabIndex = 5;
            this.labelPatientBirthday.Text = "Birth Date";
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Location = new System.Drawing.Point(26, 40);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(44, 16);
            this.labelPatientName.TabIndex = 4;
            this.labelPatientName.Text = "Name";
            this.labelPatientName.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxDoctor);
            this.Controls.Add(this.groupBoxDate);
            this.Name = "SearchAppointment";
            this.Text = "Search_Appointment";
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDoctor.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.Label labelDoctorSpeciality;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.TextBox textBoxDoctorSpeciality;
        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.DateTimePicker dateTimePickerPatientBirthday;
        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.Label labelPatientBirthday;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DateTimePicker dateTimePickerSelection;
    }
}