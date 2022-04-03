namespace GradeManagement
{
    partial class StudentManagerForm
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
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxFamily = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelFamily = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSuivSuiv = new System.Windows.Forms.Button();
            this.buttonSuiv = new System.Windows.Forms.Button();
            this.buttonPred = new System.Windows.Forms.Button();
            this.buttonPredPred = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBox1.Controls.Add(this.textBoxFamily);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.labelBirthDate);
            this.groupBox1.Controls.Add(this.labelFamily);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(239, 238);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(231, 22);
            this.dateTimePickerBirthDate.TabIndex = 7;
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.Location = new System.Drawing.Point(239, 171);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.Size = new System.Drawing.Size(231, 22);
            this.textBoxFamily.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(239, 112);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(231, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(239, 49);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(231, 22);
            this.textBoxID.TabIndex = 4;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(59, 244);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(65, 16);
            this.labelBirthDate.TabIndex = 3;
            this.labelBirthDate.Text = "Birth Date";
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Location = new System.Drawing.Point(59, 177);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(47, 16);
            this.labelFamily.TabIndex = 2;
            this.labelFamily.Text = "Family";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(59, 115);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(59, 55);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 16);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonModify);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Location = new System.Drawing.Point(588, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 308);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(24, 231);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(152, 36);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(24, 189);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 36);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(24, 147);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(152, 36);
            this.buttonModify.TabIndex = 7;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(24, 105);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 36);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(24, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(152, 36);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(24, 21);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(152, 36);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSuivSuiv);
            this.groupBox3.Controls.Add(this.buttonSuiv);
            this.groupBox3.Controls.Add(this.buttonPred);
            this.groupBox3.Controls.Add(this.buttonPredPred);
            this.groupBox3.Location = new System.Drawing.Point(12, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 112);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // buttonSuivSuiv
            // 
            this.buttonSuivSuiv.Location = new System.Drawing.Point(595, 30);
            this.buttonSuivSuiv.Name = "buttonSuivSuiv";
            this.buttonSuivSuiv.Size = new System.Drawing.Size(152, 58);
            this.buttonSuivSuiv.TabIndex = 3;
            this.buttonSuivSuiv.Text = ">>";
            this.buttonSuivSuiv.UseVisualStyleBackColor = true;
            // 
            // buttonSuiv
            // 
            this.buttonSuiv.Location = new System.Drawing.Point(405, 30);
            this.buttonSuiv.Name = "buttonSuiv";
            this.buttonSuiv.Size = new System.Drawing.Size(152, 58);
            this.buttonSuiv.TabIndex = 2;
            this.buttonSuiv.Text = ">";
            this.buttonSuiv.UseVisualStyleBackColor = true;
            // 
            // buttonPred
            // 
            this.buttonPred.Location = new System.Drawing.Point(212, 30);
            this.buttonPred.Name = "buttonPred";
            this.buttonPred.Size = new System.Drawing.Size(152, 58);
            this.buttonPred.TabIndex = 1;
            this.buttonPred.Text = "<";
            this.buttonPred.UseVisualStyleBackColor = true;
            // 
            // buttonPredPred
            // 
            this.buttonPredPred.Location = new System.Drawing.Point(26, 30);
            this.buttonPredPred.Name = "buttonPredPred";
            this.buttonPredPred.Size = new System.Drawing.Size(152, 58);
            this.buttonPredPred.TabIndex = 0;
            this.buttonPredPred.Text = "<<";
            this.buttonPredPred.UseVisualStyleBackColor = true;
            // 
            // StudentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentManagerForm";
            this.Text = "StudentManagerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.TextBox textBoxFamily;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSuivSuiv;
        private System.Windows.Forms.Button buttonSuiv;
        private System.Windows.Forms.Button buttonPred;
        private System.Windows.Forms.Button buttonPredPred;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonNew;
    }
}