using System;
using System.Windows.Forms;

namespace VideoRentingSystem
{
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(FirstName.Text == "" || LastName.Text == "" || Address.Text == "" || PhoneNo.Text == "")
            {
                MessageBox.Show("All fields are mandatory.");
            }
            else
            {
                Database database = new Database();
                database.AddCustomer(FirstName.Text, LastName.Text, Address.Text, PhoneNo.Text);
                MessageBox.Show("Customer added successfully");
            }
        }
    }
}
