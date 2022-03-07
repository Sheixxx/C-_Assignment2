namespace Assignment2
{
    partial class AppointmentManagement
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
            this.groupBoxAppointmentManagement = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.comboBoxDoctorCode = new System.Windows.Forms.ComboBox();
            this.textBoxDoctorSpeciality = new System.Windows.Forms.TextBox();
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.labelDoctorSpeciality = new System.Windows.Forms.Label();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.labelDoctorCode = new System.Windows.Forms.Label();
            this.groupBoxAppointment = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxAppointmentTime = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAppointmentTime = new System.Windows.Forms.Label();
            this.labelAppointmentDate = new System.Windows.Forms.Label();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.comboBoxPatientCode = new System.Windows.Forms.ComboBox();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.labelPatientGender = new System.Windows.Forms.Label();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.labelPatientCode = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxAppointmentManagement.SuspendLayout();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBoxAppointment.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAppointmentManagement
            // 
            this.groupBoxAppointmentManagement.Controls.Add(this.buttonExit);
            this.groupBoxAppointmentManagement.Controls.Add(this.buttonNew);
            this.groupBoxAppointmentManagement.Controls.Add(this.buttonAddAppointment);
            this.groupBoxAppointmentManagement.Controls.Add(this.groupBoxDoctor);
            this.groupBoxAppointmentManagement.Controls.Add(this.groupBoxAppointment);
            this.groupBoxAppointmentManagement.Controls.Add(this.groupBoxPatient);
            this.groupBoxAppointmentManagement.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAppointmentManagement.Name = "groupBoxAppointmentManagement";
            this.groupBoxAppointmentManagement.Size = new System.Drawing.Size(788, 438);
            this.groupBoxAppointmentManagement.TabIndex = 0;
            this.groupBoxAppointmentManagement.TabStop = false;
            this.groupBoxAppointmentManagement.Text = "Appointment Management";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(575, 385);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(575, 356);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(175, 23);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.Location = new System.Drawing.Point(575, 327);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(175, 23);
            this.buttonAddAppointment.TabIndex = 5;
            this.buttonAddAppointment.Text = "Add Appointment";
            this.buttonAddAppointment.UseVisualStyleBackColor = true;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.comboBoxDoctorCode);
            this.groupBoxDoctor.Controls.Add(this.textBoxDoctorSpeciality);
            this.groupBoxDoctor.Controls.Add(this.textBoxDoctorName);
            this.groupBoxDoctor.Controls.Add(this.labelDoctorSpeciality);
            this.groupBoxDoctor.Controls.Add(this.labelDoctorName);
            this.groupBoxDoctor.Controls.Add(this.labelDoctorCode);
            this.groupBoxDoctor.Location = new System.Drawing.Point(463, 21);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(308, 211);
            this.groupBoxDoctor.TabIndex = 2;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "groupBoxDoctor";
            // 
            // comboBoxDoctorCode
            // 
            this.comboBoxDoctorCode.FormattingEnabled = true;
            this.comboBoxDoctorCode.Location = new System.Drawing.Point(166, 32);
            this.comboBoxDoctorCode.Name = "comboBoxDoctorCode";
            this.comboBoxDoctorCode.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDoctorCode.TabIndex = 10;
            this.comboBoxDoctorCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctorCode_SelectedIndexChanged);
            // 
            // textBoxDoctorSpeciality
            // 
            this.textBoxDoctorSpeciality.Location = new System.Drawing.Point(187, 126);
            this.textBoxDoctorSpeciality.Name = "textBoxDoctorSpeciality";
            this.textBoxDoctorSpeciality.ReadOnly = true;
            this.textBoxDoctorSpeciality.Size = new System.Drawing.Size(100, 22);
            this.textBoxDoctorSpeciality.TabIndex = 9;
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Location = new System.Drawing.Point(187, 77);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.ReadOnly = true;
            this.textBoxDoctorName.Size = new System.Drawing.Size(100, 22);
            this.textBoxDoctorName.TabIndex = 8;
            // 
            // labelDoctorSpeciality
            // 
            this.labelDoctorSpeciality.AutoSize = true;
            this.labelDoctorSpeciality.Location = new System.Drawing.Point(43, 130);
            this.labelDoctorSpeciality.Name = "labelDoctorSpeciality";
            this.labelDoctorSpeciality.Size = new System.Drawing.Size(109, 16);
            this.labelDoctorSpeciality.TabIndex = 2;
            this.labelDoctorSpeciality.Text = "Doctor Speciality";
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Location = new System.Drawing.Point(43, 83);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(87, 16);
            this.labelDoctorName.TabIndex = 1;
            this.labelDoctorName.Text = "Doctor Name";
            // 
            // labelDoctorCode
            // 
            this.labelDoctorCode.AutoSize = true;
            this.labelDoctorCode.Location = new System.Drawing.Point(43, 40);
            this.labelDoctorCode.Name = "labelDoctorCode";
            this.labelDoctorCode.Size = new System.Drawing.Size(83, 16);
            this.labelDoctorCode.TabIndex = 0;
            this.labelDoctorCode.Text = "Doctor Code";
            // 
            // groupBoxAppointment
            // 
            this.groupBoxAppointment.Controls.Add(this.maskedTextBoxAppointmentTime);
            this.groupBoxAppointment.Controls.Add(this.dateTimePicker1);
            this.groupBoxAppointment.Controls.Add(this.labelAppointmentTime);
            this.groupBoxAppointment.Controls.Add(this.labelAppointmentDate);
            this.groupBoxAppointment.Location = new System.Drawing.Point(12, 283);
            this.groupBoxAppointment.Name = "groupBoxAppointment";
            this.groupBoxAppointment.Size = new System.Drawing.Size(356, 135);
            this.groupBoxAppointment.TabIndex = 1;
            this.groupBoxAppointment.TabStop = false;
            this.groupBoxAppointment.Text = "groupBoxAppointment";
            // 
            // maskedTextBoxAppointmentTime
            // 
            this.maskedTextBoxAppointmentTime.Location = new System.Drawing.Point(144, 83);
            this.maskedTextBoxAppointmentTime.Name = "maskedTextBoxAppointmentTime";
            this.maskedTextBoxAppointmentTime.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBoxAppointmentTime.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelAppointmentTime
            // 
            this.labelAppointmentTime.AutoSize = true;
            this.labelAppointmentTime.Location = new System.Drawing.Point(19, 89);
            this.labelAppointmentTime.Name = "labelAppointmentTime";
            this.labelAppointmentTime.Size = new System.Drawing.Size(116, 16);
            this.labelAppointmentTime.TabIndex = 4;
            this.labelAppointmentTime.Text = "Appointment Time";
            // 
            // labelAppointmentDate
            // 
            this.labelAppointmentDate.AutoSize = true;
            this.labelAppointmentDate.Location = new System.Drawing.Point(19, 44);
            this.labelAppointmentDate.Name = "labelAppointmentDate";
            this.labelAppointmentDate.Size = new System.Drawing.Size(114, 16);
            this.labelAppointmentDate.TabIndex = 3;
            this.labelAppointmentDate.Text = "Appointment Date";
            this.labelAppointmentDate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.comboBoxPatientCode);
            this.groupBoxPatient.Controls.Add(this.textBoxPatientName);
            this.groupBoxPatient.Controls.Add(this.labelPatientGender);
            this.groupBoxPatient.Controls.Add(this.labelPatientName);
            this.groupBoxPatient.Controls.Add(this.labelPatientCode);
            this.groupBoxPatient.Controls.Add(this.radioButtonMale);
            this.groupBoxPatient.Controls.Add(this.radioButtonFemale);
            this.groupBoxPatient.Location = new System.Drawing.Point(3, 18);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(365, 214);
            this.groupBoxPatient.TabIndex = 0;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "groupBoxPatient";
            // 
            // comboBoxPatientCode
            // 
            this.comboBoxPatientCode.FormattingEnabled = true;
            this.comboBoxPatientCode.Location = new System.Drawing.Point(153, 43);
            this.comboBoxPatientCode.Name = "comboBoxPatientCode";
            this.comboBoxPatientCode.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPatientCode.TabIndex = 11;
            this.comboBoxPatientCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatientCode_SelectedIndexChanged);
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Location = new System.Drawing.Point(153, 86);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.ReadOnly = true;
            this.textBoxPatientName.Size = new System.Drawing.Size(121, 22);
            this.textBoxPatientName.TabIndex = 3;
            // 
            // labelPatientGender
            // 
            this.labelPatientGender.AutoSize = true;
            this.labelPatientGender.Location = new System.Drawing.Point(28, 138);
            this.labelPatientGender.Name = "labelPatientGender";
            this.labelPatientGender.Size = new System.Drawing.Size(96, 16);
            this.labelPatientGender.TabIndex = 7;
            this.labelPatientGender.Text = "Patient Gender";
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Location = new System.Drawing.Point(28, 92);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(88, 16);
            this.labelPatientName.TabIndex = 6;
            this.labelPatientName.Text = "Patient Name";
            // 
            // labelPatientCode
            // 
            this.labelPatientCode.AutoSize = true;
            this.labelPatientCode.Location = new System.Drawing.Point(28, 49);
            this.labelPatientCode.Name = "labelPatientCode";
            this.labelPatientCode.Size = new System.Drawing.Size(84, 16);
            this.labelPatientCode.TabIndex = 5;
            this.labelPatientCode.Text = "Patient Code";
            this.labelPatientCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(153, 157);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(39, 20);
            this.radioButtonMale.TabIndex = 4;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "M";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(153, 131);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(36, 20);
            this.radioButtonFemale.TabIndex = 3;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "F";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // AppointmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAppointmentManagement);
            this.Name = "AppointmentManagement";
            this.Text = "Appointment Management";
            this.groupBoxAppointmentManagement.ResumeLayout(false);
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDoctor.PerformLayout();
            this.groupBoxAppointment.ResumeLayout(false);
            this.groupBoxAppointment.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAppointmentManagement;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.GroupBox groupBoxAppointment;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.Label labelPatientCode;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelPatientGender;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.Label labelAppointmentTime;
        private System.Windows.Forms.Label labelAppointmentDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.ComboBox comboBoxDoctorCode;
        private System.Windows.Forms.TextBox textBoxDoctorSpeciality;
        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.Label labelDoctorSpeciality;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.Label labelDoctorCode;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAppointmentTime;
        private System.Windows.Forms.ComboBox comboBoxPatientCode;
    }
}