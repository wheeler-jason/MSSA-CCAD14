namespace Assignment4._2
{
    partial class TeacherForm
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
            label1 = new Label();
            txtStudentId = new TextBox();
            label2 = new Label();
            txtStudentName = new TextBox();
            label3 = new Label();
            txtGPA = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(122, 6);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(170, 27);
            txtStudentId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 41);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Student Name:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(122, 38);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(170, 27);
            txtStudentName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 72);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "GPA:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(122, 69);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(170, 27);
            txtGPA.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(122, 102);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(115, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(177, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Selected Student";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(298, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(490, 432);
            dataGridView1.TabIndex = 8;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(115, 201);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(177, 29);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export list to file";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExport);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtGPA);
            Controls.Add(label3);
            Controls.Add(txtStudentName);
            Controls.Add(label2);
            Controls.Add(txtStudentId);
            Controls.Add(label1);
            Name = "TeacherForm";
            Text = "Teacher Role";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentId;
        private Label label2;
        private TextBox txtStudentName;
        private Label label3;
        private TextBox txtGPA;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Button btnExport;
    }
}