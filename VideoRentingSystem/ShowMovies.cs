using System;
using System.Windows.Forms;

namespace VideoRentingSystem
{
    public partial class ShowMovies : Form
    {
        public ShowMovies()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMovie updateMovie = new UpdateMovie(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            updateMovie.ShowDialog();
            FillDataGrid();

        }

        void FillDataGrid()
        {
            dataGridView1.DataSource = new Database().GetAllMovies();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AvailableCopies = new Database().CheckAvaliableCopies(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));

            if (AvailableCopies > 0)
            {
                IssueMovie issueMovie = new IssueMovie(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                issueMovie.ShowDialog();
            }
            else
            {
                MessageBox.Show("No copy available to issue");
            }

        }
    }
}
