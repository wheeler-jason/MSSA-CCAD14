namespace Assignment4._1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 9);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(13, 63);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(13, 122);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 183);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(132, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(172, 27);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(132, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(172, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(132, 119);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(172, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(132, 180);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(172, 27);
            txtAddress.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 247);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(172, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Person";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(310, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(731, 617);
            dataGridView1.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 412);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(291, 27);
            txtSearch.TabIndex = 13;
            txtSearch.Text = "Enter name to search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 445);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 641);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Form1";
            Text = "Address Book";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblAddress;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
    }

   
}
