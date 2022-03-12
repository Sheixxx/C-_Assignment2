namespace Assignment2
{
    partial class ShowPatientAppointments
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
            this.groupBoxPatientCode = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelPatientCode = new System.Windows.Forms.Label();
            this.textBoxPatientCode = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxPatientInfo = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPA = new System.Windows.Forms.DataGridView();
            this.groupBoxAppointment = new System.Windows.Forms.GroupBox();
            this.labelACode = new System.Windows.Forms.Label();
            this.labelDCode = new System.Windows.Forms.Label();
            this.labelATime = new System.Windows.Forms.Label();
            this.labelADate = new System.Windows.Forms.Label();
            this.textBoxACode = new System.Windows.Forms.TextBox();
            this.dateTimePickerADate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDCode = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDCode = new System.Windows.Forms.MaskedTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxPatientCode.SuspendLayout();
            this.groupBoxPatientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPA)).BeginInit();
            this.groupBoxAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPatientCode
            // 
            this.groupBoxPatientCode.Controls.Add(this.buttonCancel);
            this.groupBoxPatientCode.Controls.Add(this.textBoxPatientCode);
            this.groupBoxPatientCode.Controls.Add(this.labelPatientCode);
            this.groupBoxPatientCode.Controls.Add(this.buttonSearch);
            this.groupBoxPatientCode.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPatientCode.Name = "groupBoxPatientCode";
            this.groupBoxPatientCode.Size = new System.Drawing.Size(776, 132);
            this.groupBoxPatientCode.TabIndex = 0;
            this.groupBoxPatientCode.TabStop = false;
            this.groupBoxPatientCode.Text = "Enter Patient Code";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(564, 25);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(118, 42);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelPatientCode
            // 
            this.labelPatientCode.AutoSize = true;
            this.labelPatientCode.Location = new System.Drawing.Point(6, 70);
            this.labelPatientCode.Name = "labelPatientCode";
            this.labelPatientCode.Size = new System.Drawing.Size(101, 20);
            this.labelPatientCode.TabIndex = 2;
            this.labelPatientCode.Text = "Patient Code";
            // 
            // textBoxPatientCode
            // 
            this.textBoxPatientCode.Location = new System.Drawing.Point(113, 64);
            this.textBoxPatientCode.Name = "textBoxPatientCode";
            this.textBoxPatientCode.Size = new System.Drawing.Size(200, 26);
            this.textBoxPatientCode.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(564, 73);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 42);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxPatientInfo
            // 
            this.groupBoxPatientInfo.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBoxPatientInfo.Controls.Add(this.textBoxAddress);
            this.groupBoxPatientInfo.Controls.Add(this.textBoxName);
            this.groupBoxPatientInfo.Controls.Add(this.labelAddress);
            this.groupBoxPatientInfo.Controls.Add(this.labelBirthDate);
            this.groupBoxPatientInfo.Controls.Add(this.labelName);
            this.groupBoxPatientInfo.Location = new System.Drawing.Point(12, 150);
            this.groupBoxPatientInfo.Name = "groupBoxPatientInfo";
            this.groupBoxPatientInfo.Size = new System.Drawing.Size(776, 125);
            this.groupBoxPatientInfo.TabIndex = 1;
            this.groupBoxPatientInfo.TabStop = false;
            this.groupBoxPatientInfo.Text = "Patient Info";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(6, 76);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(86, 20);
            this.labelBirthDate.TabIndex = 1;
            this.labelBirthDate.Text = "Birth_Date";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(381, 38);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(481, 32);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(174, 64);
            this.textBoxAddress.TabIndex = 6;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(113, 76);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerBirthDate.TabIndex = 7;
            // 
            // dataGridViewPA
            // 
            this.dataGridViewPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPA.Location = new System.Drawing.Point(12, 281);
            this.dataGridViewPA.Name = "dataGridViewPA";
            this.dataGridViewPA.RowHeadersWidth = 62;
            this.dataGridViewPA.RowTemplate.Height = 28;
            this.dataGridViewPA.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewPA.TabIndex = 2;
            this.dataGridViewPA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPA_CellContentClick);
            // 
            // groupBoxAppointment
            // 
            this.groupBoxAppointment.Controls.Add(this.buttonDelete);
            this.groupBoxAppointment.Controls.Add(this.buttonSave);
            this.groupBoxAppointment.Controls.Add(this.maskedTextBoxDCode);
            this.groupBoxAppointment.Controls.Add(this.comboBoxDCode);
            this.groupBoxAppointment.Controls.Add(this.dateTimePickerADate);
            this.groupBoxAppointment.Controls.Add(this.textBoxACode);
            this.groupBoxAppointment.Controls.Add(this.labelADate);
            this.groupBoxAppointment.Controls.Add(this.labelATime);
            this.groupBoxAppointment.Controls.Add(this.labelDCode);
            this.groupBoxAppointment.Controls.Add(this.labelACode);
            this.groupBoxAppointment.Location = new System.Drawing.Point(12, 437);
            this.groupBoxAppointment.Name = "groupBoxAppointment";
            this.groupBoxAppointment.Size = new System.Drawing.Size(776, 161);
            this.groupBoxAppointment.TabIndex = 3;
            this.groupBoxAppointment.TabStop = false;
            this.groupBoxAppointment.Text = "Appointment";
            // 
            // labelACode
            // 
            this.labelACode.AutoSize = true;
            this.labelACode.Location = new System.Drawing.Point(21, 52);
            this.labelACode.Name = "labelACode";
            this.labelACode.Size = new System.Drawing.Size(142, 20);
            this.labelACode.TabIndex = 8;
            this.labelACode.Text = "Appointment Code";
            // 
            // labelDCode
            // 
            this.labelDCode.AutoSize = true;
            this.labelDCode.Location = new System.Drawing.Point(381, 106);
            this.labelDCode.Name = "labelDCode";
            this.labelDCode.Size = new System.Drawing.Size(99, 20);
            this.labelDCode.TabIndex = 9;
            this.labelDCode.Text = "Doctor Code";
            // 
            // labelATime
            // 
            this.labelATime.AutoSize = true;
            this.labelATime.Location = new System.Drawing.Point(381, 52);
            this.labelATime.Name = "labelATime";
            this.labelATime.Size = new System.Drawing.Size(138, 20);
            this.labelATime.TabIndex = 10;
            this.labelATime.Text = "Appointment Time";
            // 
            // labelADate
            // 
            this.labelADate.AutoSize = true;
            this.labelADate.Location = new System.Drawing.Point(21, 106);
            this.labelADate.Name = "labelADate";
            this.labelADate.Size = new System.Drawing.Size(139, 20);
            this.labelADate.TabIndex = 11;
            this.labelADate.Text = "Appointment Date";
            // 
            // textBoxACode
            // 
            this.textBoxACode.Location = new System.Drawing.Point(169, 46);
            this.textBoxACode.Name = "textBoxACode";
            this.textBoxACode.Size = new System.Drawing.Size(200, 26);
            this.textBoxACode.TabIndex = 8;
            // 
            // dateTimePickerADate
            // 
            this.dateTimePickerADate.Location = new System.Drawing.Point(169, 100);
            this.dateTimePickerADate.Name = "dateTimePickerADate";
            this.dateTimePickerADate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerADate.TabIndex = 13;
            // 
            // comboBoxDCode
            // 
            this.comboBoxDCode.FormattingEnabled = true;
            this.comboBoxDCode.Location = new System.Drawing.Point(525, 100);
            this.comboBoxDCode.Name = "comboBoxDCode";
            this.comboBoxDCode.Size = new System.Drawing.Size(114, 28);
            this.comboBoxDCode.TabIndex = 15;
            // 
            // maskedTextBoxDCode
            // 
            this.maskedTextBoxDCode.Location = new System.Drawing.Point(525, 49);
            this.maskedTextBoxDCode.Mask = "00:00";
            this.maskedTextBoxDCode.Name = "maskedTextBoxDCode";
            this.maskedTextBoxDCode.Size = new System.Drawing.Size(114, 26);
            this.maskedTextBoxDCode.TabIndex = 16;
            this.maskedTextBoxDCode.ValidatingType = typeof(System.DateTime);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(676, 46);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 39);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(676, 94);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 39);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ShowPatientAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.groupBoxAppointment);
            this.Controls.Add(this.dataGridViewPA);
            this.Controls.Add(this.groupBoxPatientInfo);
            this.Controls.Add(this.groupBoxPatientCode);
            this.Name = "ShowPatientAppointments";
            this.Text = "ShowPatientAppointments";
            this.groupBoxPatientCode.ResumeLayout(false);
            this.groupBoxPatientCode.PerformLayout();
            this.groupBoxPatientInfo.ResumeLayout(false);
            this.groupBoxPatientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPA)).EndInit();
            this.groupBoxAppointment.ResumeLayout(false);
            this.groupBoxAppointment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPatientCode;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxPatientCode;
        private System.Windows.Forms.Label labelPatientCode;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxPatientInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridViewPA;
        private System.Windows.Forms.GroupBox groupBoxAppointment;
        private System.Windows.Forms.Label labelADate;
        private System.Windows.Forms.Label labelATime;
        private System.Windows.Forms.Label labelDCode;
        private System.Windows.Forms.Label labelACode;
        private System.Windows.Forms.TextBox textBoxACode;
        private System.Windows.Forms.DateTimePicker dateTimePickerADate;
        private System.Windows.Forms.ComboBox comboBoxDCode;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDCode;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
    }
}