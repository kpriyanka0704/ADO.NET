namespace WindowsFormsApp1
{
    partial class Student1
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
            this.btnShowStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPer = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.StudentPer = new System.Windows.Forms.Label();
            this.StudentBranch = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.StudentRollno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowStudent
            // 
            this.btnShowStudent.Location = new System.Drawing.Point(812, 509);
            this.btnShowStudent.Name = "btnShowStudent";
            this.btnShowStudent.Size = new System.Drawing.Size(184, 27);
            this.btnShowStudent.TabIndex = 41;
            this.btnShowStudent.Text = "Show All Student";
            this.btnShowStudent.UseVisualStyleBackColor = true;
            this.btnShowStudent.Click += new System.EventHandler(this.btnShowStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(563, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(590, 322);
            this.dataGridView1.TabIndex = 40;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(515, 482);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(368, 482);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(220, 482);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(76, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPer
            // 
            this.txtPer.Location = new System.Drawing.Point(252, 354);
            this.txtPer.Name = "txtPer";
            this.txtPer.Size = new System.Drawing.Size(216, 26);
            this.txtPer.TabIndex = 35;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(252, 282);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(216, 26);
            this.txtBranch.TabIndex = 34;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(252, 210);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 26);
            this.txtName.TabIndex = 33;
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(252, 139);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(216, 26);
            this.txtRollNo.TabIndex = 32;
            // 
            // StudentPer
            // 
            this.StudentPer.AutoSize = true;
            this.StudentPer.Location = new System.Drawing.Point(90, 354);
            this.StudentPer.Name = "StudentPer";
            this.StudentPer.Size = new System.Drawing.Size(91, 20);
            this.StudentPer.TabIndex = 31;
            this.StudentPer.Text = "Percentage";
            // 
            // StudentBranch
            // 
            this.StudentBranch.AutoSize = true;
            this.StudentBranch.Location = new System.Drawing.Point(90, 282);
            this.StudentBranch.Name = "StudentBranch";
            this.StudentBranch.Size = new System.Drawing.Size(60, 20);
            this.StudentBranch.TabIndex = 30;
            this.StudentBranch.Text = "Branch";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(90, 210);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(51, 20);
            this.StudentName.TabIndex = 29;
            this.StudentName.Text = "Name";
            // 
            // StudentRollno
            // 
            this.StudentRollno.AutoSize = true;
            this.StudentRollno.Location = new System.Drawing.Point(90, 139);
            this.StudentRollno.Name = "StudentRollno";
            this.StudentRollno.Size = new System.Drawing.Size(117, 20);
            this.StudentRollno.TabIndex = 28;
            this.StudentRollno.Text = "Student RollNo";
            // 
            // Student1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 659);
            this.Controls.Add(this.btnShowStudent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPer);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.StudentPer);
            this.Controls.Add(this.StudentBranch);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.StudentRollno);
            this.Name = "Student1";
            this.Text = "Student1";
            this.Load += new System.EventHandler(this.Student1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPer;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Label StudentPer;
        private System.Windows.Forms.Label StudentBranch;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label StudentRollno;
    }
}