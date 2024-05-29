using System.ComponentModel;
using System.Windows.Forms;

namespace Assignment4._1._1;

public partial class Form1 : Form
{
    private Dictionary<string, Person> addressBook = new Dictionary<string, Person>();
    public Form1()
    {
        InitializeComponent();
        BindData();
        // Attach the event handler for the Enter event
        txtSearch.Enter += TxtSearch_Enter;
    }

    // This function is called at the initial form setup and
    // every time we update the address book so changes will reflect in the UI
    private void BindData()
    {
        var bindingList = new BindingList<Person>(addressBook.Values.ToList());
        var source = new BindingSource(bindingList, null);
        dataGridView1.DataSource = source;

        // Hide the FullName column
        if (dataGridView1.Columns["FullName"] != null)
        {
            dataGridView1.Columns["FullName"].Visible = false;
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var person = new Person
        {
            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            Phone = txtPhone.Text,
            Address = txtAddress.Text
        };

        addressBook[person.FullName] = person;
        BindData();

        // Reset textboxes to empty strings
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
        txtPhone.Text = string.Empty;
        txtAddress.Text = string.Empty;

        // Clear any selection in the DataGridView
        dataGridView1.ClearSelection();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            var fullName = dataGridView1.SelectedRows[0].Cells["FullName"].Value.ToString();
            var result = MessageBox.Show($"Are you sure you want to delete {fullName}?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                addressBook.Remove(fullName);
                BindData();
            }
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var fullName = txtSearch.Text;
        if (addressBook.TryGetValue(fullName, out var person))
        {
            // Highlight the row of the found person
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["FullName"].Value.ToString() == fullName)
                {
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }

            // Display the details of the found person in a messagebox
            MessageBox.Show($"Name: {person.FullName}\nPhone: {person.Phone}\nAddress: {person.Address}", "Person Found");
        }
        else
        {
            MessageBox.Show("Person not found.");
        }
    }

    private void TxtSearch_Enter(object sender, EventArgs e)
    {
        // Clear the text box when it receives focus
        txtSearch.Text = string.Empty;
    }
}

