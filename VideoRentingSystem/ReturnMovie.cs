using System;
using System.Windows.Forms;

namespace VideoRentingSystem
{
    public partial class ReturnMovie : Form
    {
        public ReturnMovie()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Database().GetAllPendingRentals();
        }

        private void returnMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to return this movie?", "Return Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                Database database = new Database();
                database.ReturnRental(Date, dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("Movie Returned");
                dataGridView1.DataSource = new Database().GetAllPendingRentals();
            }
        }
    }
}
