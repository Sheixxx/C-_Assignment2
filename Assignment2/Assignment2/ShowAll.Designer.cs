namespace Assignment2
{
    partial class ShowAll
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
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.radioButtonDoctors = new System.Windows.Forms.RadioButton();
            this.radioButtonPatient = new System.Windows.Forms.RadioButton();
            this.radioButtonAppointment = new System.Windows.Forms.RadioButton();
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.groupBoxChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.Controls.Add(this.radioButtonAppointment);
            this.groupBoxChoice.Controls.Add(this.radioButtonPatient);
            this.groupBoxChoice.Controls.Add(this.radioButtonDoctors);
            this.groupBoxChoice.Location = new System.Drawing.Point(27, 48);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(743, 100);
            this.groupBoxChoice.TabIndex = 0;
            this.groupBoxChoice.TabStop = false;
            this.groupBoxChoice.Text = "Choice";
            // 
            // radioButtonDoctors
            // 
            this.radioButtonDoctors.AutoSize = true;
            this.radioButtonDoctors.Location = new System.Drawing.Point(6, 42);
            this.radioButtonDoctors.Name = "radioButtonDoctors";
            this.radioButtonDoctors.Size = new System.Drawing.Size(114, 20);
            this.radioButtonDoctors.TabIndex = 0;
            this.radioButtonDoctors.TabStop = true;
            this.radioButtonDoctors.Text = "All the Doctors";
            this.radioButtonDoctors.UseVisualStyleBackColor = true;
            this.radioButtonDoctors.CheckedChanged += new System.EventHandler(this.radioButtonDoctors_CheckedChanged);
            // 
            // radioButtonPatient
            // 
            this.radioButtonPatient.AutoSize = true;
            this.radioButtonPatient.Location = new System.Drawing.Point(286, 42);
            this.radioButtonPatient.Name = "radioButtonPatient";
            this.radioButtonPatient.Size = new System.Drawing.Size(115, 20);
            this.radioButtonPatient.TabIndex = 1;
            this.radioButtonPatient.TabStop = true;
            this.radioButtonPatient.Text = "All the Patients";
            this.radioButtonPatient.UseVisualStyleBackColor = true;
            this.radioButtonPatient.CheckedChanged += new System.EventHandler(this.radioButtonPatient_CheckedChanged);
            // 
            // radioButtonAppointment
            // 
            this.radioButtonAppointment.AutoSize = true;
            this.radioButtonAppointment.Location = new System.Drawing.Point(565, 42);
            this.radioButtonAppointment.Name = "radioButtonAppointment";
            this.radioButtonAppointment.Size = new System.Drawing.Size(149, 20);
            this.radioButtonAppointment.TabIndex = 2;
            this.radioButtonAppointment.TabStop = true;
            this.radioButtonAppointment.Text = "All the Appointments";
            this.radioButtonAppointment.UseVisualStyleBackColor = true;
            this.radioButtonAppointment.CheckedChanged += new System.EventHandler(this.radioButtonAppointment_CheckedChanged);
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.AllowUserToAddRows = false;
            this.dataGridViewTables.AllowUserToDeleteRows = false;
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Location = new System.Drawing.Point(27, 164);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.ReadOnly = true;
            this.dataGridViewTables.RowHeadersWidth = 51;
            this.dataGridViewTables.RowTemplate.Height = 24;
            this.dataGridViewTables.Size = new System.Drawing.Size(743, 259);
            this.dataGridViewTables.TabIndex = 1;
            // 
            // ShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTables);
            this.Controls.Add(this.groupBoxChoice);
            this.Name = "ShowAll";
            this.Text = "ShowAll";
            this.groupBoxChoice.ResumeLayout(false);
            this.groupBoxChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChoice;
        private System.Windows.Forms.RadioButton radioButtonAppointment;
        private System.Windows.Forms.RadioButton radioButtonPatient;
        private System.Windows.Forms.RadioButton radioButtonDoctors;
        private System.Windows.Forms.DataGridView dataGridViewTables;
    }
}