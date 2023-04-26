namespace WindowsFormsApp1
{
    partial class Student
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
            this.btnShowStudent.Location = new System.Drawing.Point(800, 501);
            this.btnShowStudent.Name = "btnShowStudent";
            this.btnShowStudent.Size = new System.Drawing.Size(184, 27);
            this.btnShowStudent.TabIndex = 27;
            this.btnShowStudent.Text = "Show All Student";
            this.btnShowStudent.UseVisualStyleBackColor = true;
            this.btnShowStudent.Click += new System.EventHandler(this.btnShowStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(590, 322);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(356, 474);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(208, 474);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(64, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPer
            // 
            this.txtPer.Location = new System.Drawing.Point(240, 346);
            this.txtPer.Name = "txtPer";
            this.txtPer.Size = new System.Drawing.Size(216, 26);
            this.txtPer.TabIndex = 21;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(240, 274);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(216, 26);
            this.txtBranch.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(240, 202);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 26);
            this.txtName.TabIndex = 19;
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(240, 131);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(216, 26);
            this.txtRollNo.TabIndex = 18;
            // 
            // StudentPer
            // 
            this.StudentPer.AutoSize = true;
            this.StudentPer.Location = new System.Drawing.Point(78, 346);
            this.StudentPer.Name = "StudentPer";
            this.StudentPer.Size = new System.Drawing.Size(91, 20);
            this.StudentPer.TabIndex = 17;
            this.StudentPer.Text = "Percentage";
            // 
            // StudentBranch
            // 
            this.StudentBranch.AutoSize = true;
            this.StudentBranch.Location = new System.Drawing.Point(78, 274);
            this.StudentBranch.Name = "StudentBranch";
            this.StudentBranch.Size = new System.Drawing.Size(60, 20);
            this.StudentBranch.TabIndex = 16;
            this.StudentBranch.Text = "Branch";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(78, 202);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(51, 20);
            this.StudentName.TabIndex = 15;
            this.StudentName.Text = "Name";
            // 
            // StudentRollno
            // 
            this.StudentRollno.AutoSize = true;
            this.StudentRollno.Location = new System.Drawing.Point(78, 131);
            this.StudentRollno.Name = "StudentRollno";
            this.StudentRollno.Size = new System.Drawing.Size(117, 20);
            this.StudentRollno.TabIndex = 14;
            this.StudentRollno.Text = "Student RollNo";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 642);
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
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
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