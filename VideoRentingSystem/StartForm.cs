using System;
using System.Windows.Forms;

namespace VideoRentingSystem
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new CreateCustomer()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void showAllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ShowCustomers()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void newMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new CreateMovie()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void showAllMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ShowMovies()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void issueMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ShowMovies()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void returnMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ReturnMovie()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void bestCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new BestCustomers()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void bestSellingMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new BestSellingMovies()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
