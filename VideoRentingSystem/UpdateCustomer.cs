using System;
using System.Data;
using System.Windows.Forms;

namespace VideoRentingSystem
{
    public partial class UpdateCustomer : Form
    {
        private string Id;

        public UpdateCustomer()
        {
            InitializeComponent();
        }

        public UpdateCustomer(string Id)
        {
            this.Id = Id;
            InitializeComponent();
            DataTable table = new Database().GetCustomer(Id);
            FirstName.Text = table.Rows[0]["FirstName"].ToString();
            LastName.Text = table.Rows[0]["LastName"].ToString();
            Address.Text = table.Rows[0]["Address"].ToString();
            PhoneNo.Text = table.Rows[0]["Phone"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == "" || LastName.Text == "" || Address.Text == "" || PhoneNo.Text == "")
            {
                MessageBox.Show("All fields are mandatory.");
            }
            else
            {
                Database database = new Database();
                database.UpdateCustomer(FirstName.Text, LastName.Text, Address.Text, PhoneNo.Text, Id);
                MessageBox.Show("Customer updated successfully");
                Dispose();
            }
        }
    }
}
