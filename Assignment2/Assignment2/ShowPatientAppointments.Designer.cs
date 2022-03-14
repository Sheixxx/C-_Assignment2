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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxPatientCode = new System.Windows.Forms.TextBox();
            this.labelPatientCode = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxPatientInfo = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewPA = new System.Windows.Forms.DataGridView();
            this.groupBoxAppointment = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.maskedTextBoxDCode = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDCode = new System.Windows.Forms.ComboBox();
            this.dateTimePickerADate = new System.Windows.Forms.DateTimePicker();
            this.textBoxACode = new System.Windows.Forms.TextBox();
            this.labelADate = new System.Windows.Forms.Label();
            this.labelATime = new System.Windows.Forms.Label();
            this.labelDCode = new System.Windows.Forms.Label();
            this.labelACode = new System.Windows.Forms.Label();
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
            this.groupBoxPatientCode.Location = new System.Drawing.Point(11, 10);
            this.groupBoxPatientCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatientCode.Name = "groupBoxPatientCode";
            this.groupBoxPatientCode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatientCode.Size = new System.Drawing.Size(690, 106);
            this.groupBoxPatientCode.TabIndex = 0;
            this.groupBoxPatientCode.TabStop = false;
            this.groupBoxPatientCode.Text = "Enter Patient Code";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(501, 58);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 34);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxPatientCode
            // 
            this.textBoxPatientCode.Location = new System.Drawing.Point(100, 51);
            this.textBoxPatientCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPatientCode.Name = "textBoxPatientCode";
            this.textBoxPatientCode.Size = new System.Drawing.Size(178, 22);
            this.textBoxPatientCode.TabIndex = 3;
            this.textBoxPatientCode.TextChanged += new System.EventHandler(this.textBoxPatientCode_TextChanged);
            // 
            // labelPatientCode
            // 
            this.labelPatientCode.AutoSize = true;
            this.labelPatientCode.Location = new System.Drawing.Point(5, 56);
            this.labelPatientCode.Name = "labelPatientCode";
            this.labelPatientCode.Size = new System.Drawing.Size(84, 16);
            this.labelPatientCode.TabIndex = 2;
            this.labelPatientCode.Text = "Patient Code";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(501, 20);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 34);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxPatientInfo
            // 
            this.groupBoxPatientInfo.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBoxPatientInfo.Controls.Add(this.textBoxAddress);
            this.groupBoxPatientInfo.Controls.Add(this.textBoxName);
            this.groupBoxPatientInfo.Controls.Add(this.labelAddress);
            this.groupBoxPatientInfo.Controls.Add(this.labelBirthDate);
            this.groupBoxPatientInfo.Controls.Add(this.labelName);
            this.groupBoxPatientInfo.Location = new System.Drawing.Point(11, 120);
            this.groupBoxPatientInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatientInfo.Name = "groupBoxPatientInfo";
            this.groupBoxPatientInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatientInfo.Size = new System.Drawing.Size(690, 100);
            this.groupBoxPatientInfo.TabIndex = 1;
            this.groupBoxPatientInfo.TabStop = false;
            this.groupBoxPatientInfo.Text = "Patient Info";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(100, 61);
            this.dateTimePickerBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(178, 22);
            this.dateTimePickerBirthDate.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(428, 26);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(155, 52);
            this.textBoxAddress.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 26);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 22);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(339, 30);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(5, 61);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(69, 16);
            this.labelBirthDate.TabIndex = 1;
            this.labelBirthDate.Text = "Birth_Date";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // dataGridViewPA
            // 
            this.dataGridViewPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPA.Location = new System.Drawing.Point(11, 225);
            this.dataGridViewPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPA.Name = "dataGridViewPA";
            this.dataGridViewPA.RowHeadersWidth = 62;
            this.dataGridViewPA.RowTemplate.Height = 28;
            this.dataGridViewPA.Size = new System.Drawing.Size(690, 120);
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
            this.groupBoxAppointment.Location = new System.Drawing.Point(11, 350);
            this.groupBoxAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAppointment.Name = "groupBoxAppointment";
            this.groupBoxAppointment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAppointment.Size = new System.Drawing.Size(690, 129);
            this.groupBoxAppointment.TabIndex = 3;
            this.groupBoxAppointment.TabStop = false;
            this.groupBoxAppointment.Text = "Appointment";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(601, 75);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(67, 31);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(601, 37);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(67, 31);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // maskedTextBoxDCode
            // 
            this.maskedTextBoxDCode.Location = new System.Drawing.Point(467, 39);
            this.maskedTextBoxDCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxDCode.Mask = "00:00";
            this.maskedTextBoxDCode.Name = "maskedTextBoxDCode";
            this.maskedTextBoxDCode.Size = new System.Drawing.Size(102, 22);
            this.maskedTextBoxDCode.TabIndex = 16;
            this.maskedTextBoxDCode.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxDCode
            // 
            this.comboBoxDCode.FormattingEnabled = true;
            this.comboBoxDCode.Location = new System.Drawing.Point(467, 80);
            this.comboBoxDCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDCode.Name = "comboBoxDCode";
            this.comboBoxDCode.Size = new System.Drawing.Size(102, 24);
            this.comboBoxDCode.TabIndex = 15;
            // 
            // dateTimePickerADate
            // 
            this.dateTimePickerADate.Location = new System.Drawing.Point(150, 80);
            this.dateTimePickerADate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerADate.Name = "dateTimePickerADate";
            this.dateTimePickerADate.Size = new System.Drawing.Size(178, 22);
            this.dateTimePickerADate.TabIndex = 13;
            // 
            // textBoxACode
            // 
            this.textBoxACode.Location = new System.Drawing.Point(150, 37);
            this.textBoxACode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxACode.Name = "textBoxACode";
            this.textBoxACode.Size = new System.Drawing.Size(178, 22);
            this.textBoxACode.TabIndex = 8;
            // 
            // labelADate
            // 
            this.labelADate.AutoSize = true;
            this.labelADate.Location = new System.Drawing.Point(19, 85);
            this.labelADate.Name = "labelADate";
            this.labelADate.Size = new System.Drawing.Size(114, 16);
            this.labelADate.TabIndex = 11;
            this.labelADate.Text = "Appointment Date";
            // 
            // labelATime
            // 
            this.labelATime.AutoSize = true;
            this.labelATime.Location = new System.Drawing.Point(339, 42);
            this.labelATime.Name = "labelATime";
            this.labelATime.Size = new System.Drawing.Size(116, 16);
            this.labelATime.TabIndex = 10;
            this.labelATime.Text = "Appointment Time";
            // 
            // labelDCode
            // 
            this.labelDCode.AutoSize = true;
            this.labelDCode.Location = new System.Drawing.Point(339, 85);
            this.labelDCode.Name = "labelDCode";
            this.labelDCode.Size = new System.Drawing.Size(83, 16);
            this.labelDCode.TabIndex = 9;
            this.labelDCode.Text = "Doctor Code";
            // 
            // labelACode
            // 
            this.labelACode.AutoSize = true;
            this.labelACode.Location = new System.Drawing.Point(19, 42);
            this.labelACode.Name = "labelACode";
            this.labelACode.Size = new System.Drawing.Size(118, 16);
            this.labelACode.TabIndex = 8;
            this.labelACode.Text = "Appointment Code";
            // 
            // ShowPatientAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 488);
            this.Controls.Add(this.groupBoxAppointment);
            this.Controls.Add(this.dataGridViewPA);
            this.Controls.Add(this.groupBoxPatientInfo);
            this.Controls.Add(this.groupBoxPatientCode);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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