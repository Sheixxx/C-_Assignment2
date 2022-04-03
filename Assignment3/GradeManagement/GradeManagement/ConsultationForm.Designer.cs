namespace GradeManagement
{
    partial class ConsultationForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCourse = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxAverageClass = new System.Windows.Forms.TextBox();
            this.labelAverageClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(323, 20);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(50, 16);
            this.labelCourse.TabIndex = 1;
            this.labelCourse.Text = "Course";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(426, 12);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCourse.TabIndex = 2;
            // 
            // textBoxAverageClass
            // 
            this.textBoxAverageClass.Location = new System.Drawing.Point(688, 416);
            this.textBoxAverageClass.Name = "textBoxAverageClass";
            this.textBoxAverageClass.Size = new System.Drawing.Size(100, 22);
            this.textBoxAverageClass.TabIndex = 3;
            // 
            // labelAverageClass
            // 
            this.labelAverageClass.AutoSize = true;
            this.labelAverageClass.Location = new System.Drawing.Point(507, 422);
            this.labelAverageClass.Name = "labelAverageClass";
            this.labelAverageClass.Size = new System.Drawing.Size(131, 16);
            this.labelAverageClass.TabIndex = 4;
            this.labelAverageClass.Text = "Average of the Class";
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAverageClass);
            this.Controls.Add(this.textBoxAverageClass);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultationForm";
            this.Text = "Consultation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.TextBox textBoxAverageClass;
        private System.Windows.Forms.Label labelAverageClass;
    }
}