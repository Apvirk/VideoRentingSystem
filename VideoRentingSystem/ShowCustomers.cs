using System;
using System.Windows.Forms;

namespace VideoRentingSystem
{
    public partial class ShowCustomers : Form
    {
        public ShowCustomers()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Database().GetAllCustomers();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            updateCustomer.ShowDialog();
            dataGridView1.DataSource = new Database().GetAllCustomers();
        }
    }
}
