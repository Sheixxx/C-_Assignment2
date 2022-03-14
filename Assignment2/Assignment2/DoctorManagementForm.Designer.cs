namespace Assignment2
{
    partial class DoctorManagementForm
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
            this.groupBoxDM = new System.Windows.Forms.GroupBox();
            this.comboBoxSpecialty = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.buttonExitDM = new System.Windows.Forms.Button();
            this.buttonDeleteDM = new System.Windows.Forms.Button();
            this.buttonEditDM = new System.Windows.Forms.Button();
            this.buttonAddDM = new System.Windows.Forms.Button();
            this.buttonSearchDM = new System.Windows.Forms.Button();
            this.buttonNewDM = new System.Windows.Forms.Button();
            this.dateTimePickerHiringDateDM = new System.Windows.Forms.DateTimePicker();
            this.textBoxNameDM = new System.Windows.Forms.TextBox();
            this.textBoxCodeDM = new System.Windows.Forms.TextBox();
            this.labelSpecialty = new System.Windows.Forms.Label();
            this.labelHiringDateDM = new System.Windows.Forms.Label();
            this.labelTelephoneDM = new System.Windows.Forms.Label();
            this.labelNameDM = new System.Windows.Forms.Label();
            this.labelCodeDM = new System.Windows.Forms.Label();
            this.groupBoxDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDM
            // 
            this.groupBoxDM.Controls.Add(this.comboBoxSpecialty);
            this.groupBoxDM.Controls.Add(this.maskedTextBoxTelephone);
            this.groupBoxDM.Controls.Add(this.buttonExitDM);
            this.groupBoxDM.Controls.Add(this.buttonDeleteDM);
            this.groupBoxDM.Controls.Add(this.buttonEditDM);
            this.groupBoxDM.Controls.Add(this.buttonAddDM);
            this.groupBoxDM.Controls.Add(this.buttonSearchDM);
            this.groupBoxDM.Controls.Add(this.buttonNewDM);
            this.groupBoxDM.Controls.Add(this.dateTimePickerHiringDateDM);
            this.groupBoxDM.Controls.Add(this.textBoxNameDM);
            this.groupBoxDM.Controls.Add(this.textBoxCodeDM);
            this.groupBoxDM.Controls.Add(this.labelSpecialty);
            this.groupBoxDM.Controls.Add(this.labelHiringDateDM);
            this.groupBoxDM.Controls.Add(this.labelTelephoneDM);
            this.groupBoxDM.Controls.Add(this.labelNameDM);
            this.groupBoxDM.Controls.Add(this.labelCodeDM);
            this.groupBoxDM.Location = new System.Drawing.Point(17, 18);
            this.groupBoxDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDM.Name = "groupBoxDM";
            this.groupBoxDM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDM.Size = new System.Drawing.Size(677, 296);
            this.groupBoxDM.TabIndex = 0;
            this.groupBoxDM.TabStop = false;
            this.groupBoxDM.Text = "Doctor Management";
            // 
            // comboBoxSpecialty
            // 
            this.comboBoxSpecialty.FormattingEnabled = true;
            this.comboBoxSpecialty.Location = new System.Drawing.Point(180, 242);
            this.comboBoxSpecialty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSpecialty.Name = "comboBoxSpecialty";
            this.comboBoxSpecialty.Size = new System.Drawing.Size(216, 24);
            this.comboBoxSpecialty.TabIndex = 18;
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(180, 142);
            this.maskedTextBoxTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxTelephone.Mask = "00 00 00 00 00 00";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(216, 22);
            this.maskedTextBoxTelephone.TabIndex = 17;
            this.maskedTextBoxTelephone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxTelephone_MaskInputRejected);
            // 
            // buttonExitDM
            // 
            this.buttonExitDM.Location = new System.Drawing.Point(461, 212);
            this.buttonExitDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExitDM.Name = "buttonExitDM";
            this.buttonExitDM.Size = new System.Drawing.Size(176, 24);
            this.buttonExitDM.TabIndex = 16;
            this.buttonExitDM.Text = "Exit";
            this.buttonExitDM.UseVisualStyleBackColor = true;
            this.buttonExitDM.Click += new System.EventHandler(this.buttonExitDM_Click);
            // 
            // buttonDeleteDM
            // 
            this.buttonDeleteDM.Location = new System.Drawing.Point(461, 183);
            this.buttonDeleteDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteDM.Name = "buttonDeleteDM";
            this.buttonDeleteDM.Size = new System.Drawing.Size(176, 24);
            this.buttonDeleteDM.TabIndex = 15;
            this.buttonDeleteDM.Text = "Delete";
            this.buttonDeleteDM.UseVisualStyleBackColor = true;
            this.buttonDeleteDM.Click += new System.EventHandler(this.buttonDeleteDM_Click);
            // 
            // buttonEditDM
            // 
            this.buttonEditDM.Location = new System.Drawing.Point(461, 154);
            this.buttonEditDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditDM.Name = "buttonEditDM";
            this.buttonEditDM.Size = new System.Drawing.Size(176, 24);
            this.buttonEditDM.TabIndex = 14;
            this.buttonEditDM.Text = "Edit";
            this.buttonEditDM.UseVisualStyleBackColor = true;
            this.buttonEditDM.Click += new System.EventHandler(this.buttonEditDM_Click);
            // 
            // buttonAddDM
            // 
            this.buttonAddDM.Location = new System.Drawing.Point(461, 126);
            this.buttonAddDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddDM.Name = "buttonAddDM";
            this.buttonAddDM.Size = new System.Drawing.Size(176, 24);
            this.buttonAddDM.TabIndex = 13;
            this.buttonAddDM.Text = "Add";
            this.buttonAddDM.UseVisualStyleBackColor = true;
            this.buttonAddDM.Click += new System.EventHandler(this.buttonAddDM_Click);
            // 
            // buttonSearchDM
            // 
            this.buttonSearchDM.Location = new System.Drawing.Point(461, 97);
            this.buttonSearchDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchDM.Name = "buttonSearchDM";
            this.buttonSearchDM.Size = new System.Drawing.Size(176, 24);
            this.buttonSearchDM.TabIndex = 12;
            this.buttonSearchDM.Text = "Search";
            this.buttonSearchDM.UseVisualStyleBackColor = true;
            this.buttonSearchDM.Click += new System.EventHandler(this.buttonSearchDM_Click);
            // 
            // buttonNewDM
            // 
            this.buttonNewDM.Location = new System.Drawing.Point(461, 68);
            this.buttonNewDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNewDM.Name = "buttonNewDM";
            this.buttonNewDM.Size = new System.Drawing.Size(176, 24);
            this.buttonNewDM.TabIndex = 11;
            this.buttonNewDM.Text = "New";
            this.buttonNewDM.UseVisualStyleBackColor = true;
            this.buttonNewDM.Click += new System.EventHandler(this.buttonNewDM_Click);
            // 
            // dateTimePickerHiringDateDM
            // 
            this.dateTimePickerHiringDateDM.Location = new System.Drawing.Point(180, 195);
            this.dateTimePickerHiringDateDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerHiringDateDM.Name = "dateTimePickerHiringDateDM";
            this.dateTimePickerHiringDateDM.Size = new System.Drawing.Size(216, 22);
            this.dateTimePickerHiringDateDM.TabIndex = 10;
            // 
            // textBoxNameDM
            // 
            this.textBoxNameDM.Location = new System.Drawing.Point(180, 98);
            this.textBoxNameDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameDM.Name = "textBoxNameDM";
            this.textBoxNameDM.Size = new System.Drawing.Size(216, 22);
            this.textBoxNameDM.TabIndex = 6;
            // 
            // textBoxCodeDM
            // 
            this.textBoxCodeDM.Location = new System.Drawing.Point(180, 52);
            this.textBoxCodeDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCodeDM.Name = "textBoxCodeDM";
            this.textBoxCodeDM.Size = new System.Drawing.Size(216, 22);
            this.textBoxCodeDM.TabIndex = 5;
            this.textBoxCodeDM.TextChanged += new System.EventHandler(this.textBoxCodeDM_TextChanged);
            // 
            // labelSpecialty
            // 
            this.labelSpecialty.AutoSize = true;
            this.labelSpecialty.Location = new System.Drawing.Point(29, 242);
            this.labelSpecialty.Name = "labelSpecialty";
            this.labelSpecialty.Size = new System.Drawing.Size(63, 16);
            this.labelSpecialty.TabIndex = 4;
            this.labelSpecialty.Text = "Specialty";
            // 
            // labelHiringDateDM
            // 
            this.labelHiringDateDM.AutoSize = true;
            this.labelHiringDateDM.Location = new System.Drawing.Point(29, 195);
            this.labelHiringDateDM.Name = "labelHiringDateDM";
            this.labelHiringDateDM.Size = new System.Drawing.Size(74, 16);
            this.labelHiringDateDM.TabIndex = 3;
            this.labelHiringDateDM.Text = "Hiring Date";
            // 
            // labelTelephoneDM
            // 
            this.labelTelephoneDM.AutoSize = true;
            this.labelTelephoneDM.Location = new System.Drawing.Point(29, 145);
            this.labelTelephoneDM.Name = "labelTelephoneDM";
            this.labelTelephoneDM.Size = new System.Drawing.Size(73, 16);
            this.labelTelephoneDM.TabIndex = 2;
            this.labelTelephoneDM.Text = "Telephone";
            // 
            // labelNameDM
            // 
            this.labelNameDM.AutoSize = true;
            this.labelNameDM.Location = new System.Drawing.Point(29, 98);
            this.labelNameDM.Name = "labelNameDM";
            this.labelNameDM.Size = new System.Drawing.Size(44, 16);
            this.labelNameDM.TabIndex = 1;
            this.labelNameDM.Text = "Name";
            // 
            // labelCodeDM
            // 
            this.labelCodeDM.AutoSize = true;
            this.labelCodeDM.Location = new System.Drawing.Point(29, 57);
            this.labelCodeDM.Name = "labelCodeDM";
            this.labelCodeDM.Size = new System.Drawing.Size(40, 16);
            this.labelCodeDM.TabIndex = 0;
            this.labelCodeDM.Text = "Code";
            // 
            // DoctorManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 325);
            this.Controls.Add(this.groupBoxDM);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoctorManagementForm";
            this.Text = "DoctorManagementForm";
            this.groupBoxDM.ResumeLayout(false);
            this.groupBoxDM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDM;
        private System.Windows.Forms.Label labelSpecialty;
        private System.Windows.Forms.Label labelHiringDateDM;
        private System.Windows.Forms.Label labelTelephoneDM;
        private System.Windows.Forms.Label labelNameDM;
        private System.Windows.Forms.Label labelCodeDM;
        private System.Windows.Forms.TextBox textBoxNameDM;
        private System.Windows.Forms.TextBox textBoxCodeDM;
        private System.Windows.Forms.Button buttonExitDM;
        private System.Windows.Forms.Button buttonDeleteDM;
        private System.Windows.Forms.Button buttonEditDM;
        private System.Windows.Forms.Button buttonAddDM;
        private System.Windows.Forms.Button buttonSearchDM;
        private System.Windows.Forms.Button buttonNewDM;
        private System.Windows.Forms.DateTimePicker dateTimePickerHiringDateDM;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
        private System.Windows.Forms.ComboBox comboBoxSpecialty;
    }
}