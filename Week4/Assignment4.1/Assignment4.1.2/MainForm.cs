namespace Assignment4._1._2
{
    public partial class MainForm : Form
    {
        double firstNumber = 0;
        string operation = "";
        Math math = new Math();
        double result = 0;

        // this flag will track if we already completed an operation
        // if true, we want to start a new operation
        bool isOperationPerformed = false;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Number Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }
        #endregion

        private void buttonDot_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += ".";
        }

        private void buttonCLR_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            result = 0;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(displayTextBox.Text);
            switch(operation)
            {
                case "+":
                    result = math.Add(firstNumber, secondNumber);
                    displayTextBox.Text = result.ToString();
                    break;
                case "-":
                    result = math.Subtract(firstNumber, secondNumber);
                    displayTextBox.Text = result.ToString();
                    break;
                case "*":
                    result = math.Multiply(firstNumber, secondNumber);
                    displayTextBox.Text = result.ToString();
                    break;
                case "/":
                    if(secondNumber == 0)
                    {
                        MessageBox.Show("You cannot divide by 0.");
                        result = 0;
                        displayTextBox.Text = "0";
                        return;
                    } 
                    else
                    {
                        result = math.Divide(firstNumber, secondNumber);
                        displayTextBox.Text = result.ToString();
                    }
                    break;
                default:
                    MessageBox.Show("Uh oh. Something went wrong.");
                    break;
            }
            isOperationPerformed = true;
        }

        #region Operator Buttons
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            firstNumber = Convert.ToDouble(displayTextBox.Text);
            displayTextBox.Text = "0";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            firstNumber = Convert.ToDouble(displayTextBox.Text);
            displayTextBox.Text = "0";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            firstNumber = Convert.ToDouble(displayTextBox.Text);
            displayTextBox.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            firstNumber = Convert.ToDouble(displayTextBox.Text);
            displayTextBox.Text = "0";
        }
        #endregion

    }
}
