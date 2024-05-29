namespace Assignment4._2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Grab the username and password that was entered
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if it was the teacher that logged in
            if (username == "Teacher" && password == "Admin")
            {
                // Hide this current form
                this.Hide();

                // Show new form - the view after you login
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.FormClosed += (s, args) => this.Close(); // Close login form when teacher form is closed
                teacherForm.ShowDialog();
            }
            else
            {
                // If login fails, show error and clear the text boxes 
                MessageBox.Show("Invalid username or password.");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
