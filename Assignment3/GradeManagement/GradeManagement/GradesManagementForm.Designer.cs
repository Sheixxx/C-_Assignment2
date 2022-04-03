namespace GradeManagement
{
    partial class GradesManagementForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxNameFamily = new System.Windows.Forms.TextBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelNameFamily = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonModifyGrade = new System.Windows.Forms.Button();
            this.buttonAddGrade = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxID);
            this.groupBox1.Controls.Add(this.comboBoxCourse);
            this.groupBox1.Controls.Add(this.textBoxGrade);
            this.groupBox1.Controls.Add(this.textBoxNameFamily);
            this.groupBox1.Controls.Add(this.labelGrade);
            this.groupBox1.Controls.Add(this.labelCourse);
            this.groupBox1.Controls.Add(this.labelNameFamily);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(505, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBoxID
            // 
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(256, 56);
            this.comboBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(136, 28);
            this.comboBoxID.TabIndex = 5;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(256, 180);
            this.comboBoxCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(220, 28);
            this.comboBoxCourse.TabIndex = 9;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(256, 245);
            this.textBoxGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(220, 26);
            this.textBoxGrade.TabIndex = 5;
            // 
            // textBoxNameFamily
            // 
            this.textBoxNameFamily.Location = new System.Drawing.Point(256, 120);
            this.textBoxNameFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNameFamily.Name = "textBoxNameFamily";
            this.textBoxNameFamily.Size = new System.Drawing.Size(220, 26);
            this.textBoxNameFamily.TabIndex = 4;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(66, 252);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(54, 20);
            this.labelGrade.TabIndex = 3;
            this.labelGrade.Text = "Grade";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(66, 190);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(60, 20);
            this.labelCourse.TabIndex = 2;
            this.labelCourse.Text = "Course";
            // 
            // labelNameFamily
            // 
            this.labelNameFamily.AutoSize = true;
            this.labelNameFamily.Location = new System.Drawing.Point(66, 128);
            this.labelNameFamily.Name = "labelNameFamily";
            this.labelNameFamily.Size = new System.Drawing.Size(131, 20);
            this.labelNameFamily.TabIndex = 1;
            this.labelNameFamily.Text = "Name and Family";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(66, 66);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.buttonPreview);
            this.groupBox2.Controls.Add(this.buttonModifyGrade);
            this.groupBox2.Controls.Add(this.buttonAddGrade);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Location = new System.Drawing.Point(603, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(284, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(142, 245);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(128, 48);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(142, 190);
            this.buttonPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(128, 48);
            this.buttonPreview.TabIndex = 3;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            // 
            // buttonModifyGrade
            // 
            this.buttonModifyGrade.Location = new System.Drawing.Point(142, 135);
            this.buttonModifyGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModifyGrade.Name = "buttonModifyGrade";
            this.buttonModifyGrade.Size = new System.Drawing.Size(128, 48);
            this.buttonModifyGrade.TabIndex = 2;
            this.buttonModifyGrade.Text = "Modify Grade";
            this.buttonModifyGrade.UseVisualStyleBackColor = true;
            this.buttonModifyGrade.Click += new System.EventHandler(this.buttonModifyGrade_Click);
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.Location = new System.Drawing.Point(142, 80);
            this.buttonAddGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddGrade.Name = "buttonAddGrade";
            this.buttonAddGrade.Size = new System.Drawing.Size(128, 48);
            this.buttonAddGrade.TabIndex = 1;
            this.buttonAddGrade.Text = "Add Grade";
            this.buttonAddGrade.UseVisualStyleBackColor = true;
            this.buttonAddGrade.Click += new System.EventHandler(this.buttonAddGrade_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(142, 25);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(128, 48);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 358);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 190);
            this.dataGridView1.TabIndex = 8;
            // 
            // GradesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GradesManagementForm";
            this.Text = "GradesManagementForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelNameFamily;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonModifyGrade;
        private System.Windows.Forms.Button buttonAddGrade;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.TextBox textBoxNameFamily;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.ComboBox comboBoxCourse;
    }
}