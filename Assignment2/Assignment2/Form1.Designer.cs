﻿namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apointmentManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllPart1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAppointmentByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAPatientsAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementSystemToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementSystemToolStripMenuItem
            // 
            this.managementSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorManagementToolStripMenuItem,
            this.patientManagementToolStripMenuItem,
            this.apointmentManagmentToolStripMenuItem});
            this.managementSystemToolStripMenuItem.Name = "managementSystemToolStripMenuItem";
            this.managementSystemToolStripMenuItem.Size = new System.Drawing.Size(195, 29);
            this.managementSystemToolStripMenuItem.Text = "Management System";
            // 
            // doctorManagementToolStripMenuItem
            // 
            this.doctorManagementToolStripMenuItem.Name = "doctorManagementToolStripMenuItem";
            this.doctorManagementToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
            this.doctorManagementToolStripMenuItem.Text = "Doctor Management";
            // 
            // patientManagementToolStripMenuItem
            // 
            this.patientManagementToolStripMenuItem.Name = "patientManagementToolStripMenuItem";
            this.patientManagementToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
            this.patientManagementToolStripMenuItem.Text = "Patient Management";
            // 
            // apointmentManagmentToolStripMenuItem
            // 
            this.apointmentManagmentToolStripMenuItem.Name = "apointmentManagmentToolStripMenuItem";
            this.apointmentManagmentToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
            this.apointmentManagmentToolStripMenuItem.Text = "Apointment Managment";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllPart1ToolStripMenuItem,
            this.searchAppointmentByDateToolStripMenuItem,
            this.showAPatientsAppointmentsToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // showAllPart1ToolStripMenuItem
            // 
            this.showAllPart1ToolStripMenuItem.Name = "showAllPart1ToolStripMenuItem";
            this.showAllPart1ToolStripMenuItem.Size = new System.Drawing.Size(360, 34);
            this.showAllPart1ToolStripMenuItem.Text = "Show All";
            // 
            // searchAppointmentByDateToolStripMenuItem
            // 
            this.searchAppointmentByDateToolStripMenuItem.Name = "searchAppointmentByDateToolStripMenuItem";
            this.searchAppointmentByDateToolStripMenuItem.Size = new System.Drawing.Size(360, 34);
            this.searchAppointmentByDateToolStripMenuItem.Text = "Search appointment by date";
            // 
            // showAPatientsAppointmentsToolStripMenuItem
            // 
            this.showAPatientsAppointmentsToolStripMenuItem.Name = "showAPatientsAppointmentsToolStripMenuItem";
            this.showAPatientsAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(360, 34);
            this.showAPatientsAppointmentsToolStripMenuItem.Text = "Show a patient\'s appointments";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apointmentManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllPart1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAppointmentByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAPatientsAppointmentsToolStripMenuItem;
    }
}

