using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._2
{
    public partial class TeacherForm : Form
    {
        List<Student> students = new();
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Test for valid Student ID input
            string studentId = txtStudentId.Text;
            if (string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Please enter a valid student ID.");
                return;
            }

            // Test for valid GPA input
            double gpa;
            if (!double.TryParse(txtGPA.Text, out gpa))
            {
                MessageBox.Show("Please enter a valid GPA.");
                return;
            }

            // Create student object
            Student student = new Student
            {
                StudentId = studentId,
                Name = txtStudentName.Text,
                GPA = gpa
            };

            // Add student to the students list
            students.Add(student);

            // Reset the DataGridView data source
            dataGridView1.DataSource = null;
            // Set the DataGridView to the updated list
            dataGridView1.DataSource = students;

            // Clear the input text boxes
            txtStudentId.Text = "";
            txtStudentName.Text = "";
            txtGPA.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedStudentId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var selectedStudentName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                var result = MessageBox.Show($"Are you sure you want to delete {selectedStudentName}?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    foreach (var student in students)
                    {
                        if (student.StudentId == selectedStudentId)
                        {
                            students.Remove(student);
                            break;
                        }
                    }
                    // Reset the DataGridView data source
                    dataGridView1.DataSource = null;
                    // Set the DataGridView to the updated list
                    dataGridView1.DataSource = students;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(students.Count > 0)
            {
                try
                {
                    using (var sw = new StreamWriter(@"C:\test\students.txt"))
                    {
                        sw.WriteLine("StudentId,Name,GPA");
                        foreach (var student in students)
                        {
                            sw.WriteLine(student.ToString());
                        }
                    }
                    MessageBox.Show("Students list exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while exporting the students list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"There are no students to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
