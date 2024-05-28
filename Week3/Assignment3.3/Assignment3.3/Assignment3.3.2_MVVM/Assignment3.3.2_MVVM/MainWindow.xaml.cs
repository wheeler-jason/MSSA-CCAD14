using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Assignment3._3._2_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// TODO: Use commands for button actions
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new StudentViewModel();
            DataContext = _viewModel;
        }

        private async void addStudent_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student();

            if (String.IsNullOrEmpty(studentId.Text) || String.IsNullOrEmpty(firstName.Text) ||
                String.IsNullOrEmpty(lastName.Text) || String.IsNullOrEmpty(address.Text) ||
                String.IsNullOrEmpty(month.Text) || String.IsNullOrEmpty(gpa.Text))
            {
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            student.StudentId = studentId.Text;
            student.FirstName = firstName.Text;
            student.LastName = lastName.Text;
            student.Address = address.Text;

            if (!Enum.TryParse(month.Text, true, out AdmissionMonth monthOfAdmission))
            {
                MessageBox.Show("Invalid month of admission value", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            student.MonthOfAdmission = monthOfAdmission;

            if (!double.TryParse(gpa.Text, out double gpaValue))
            {
                MessageBox.Show("Invalid GPA value", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            student.GPA = gpaValue;

            // Add student in the background using async programming techniques
            await Task.Run(() => AddStudentInBackground(student));
        }

        private void AddStudentInBackground(Student student)
        {
            // Use Dispatcher to update UI thread
            Dispatcher.Invoke(() =>
            {
                _viewModel.StudentList.Add(student);
                // Clear text boxes after adding student
                studentId.Text = "";
                firstName.Text = "";
                lastName.Text = "";
                address.Text = "";
                month.Text = "";
                gpa.Text = "";
            });
        }

        private void DeleteSelectedStudent_Click(object sender, RoutedEventArgs e)
        {
            if (studentListView.SelectedItem != null)
            {
                var selectedStudent = studentListView.SelectedItem as Student;
                _viewModel.StudentList.Remove(selectedStudent);
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}