using System;
using System.Data;
using System.Windows.Forms;

namespace VideoRentingSystem
{
    public partial class UpdateMovie : Form
    {
        private string Id;

        public UpdateMovie()
        {
            InitializeComponent();
        }

        public UpdateMovie(string Id)
        {
            this.Id = Id;
            InitializeComponent();
            DataTable table = new Database().GetMovie(Id);
            Rating.Text = table.Rows[0]["Rating"].ToString();
            Title.Text = table.Rows[0]["Title"].ToString();
            Year.Text = table.Rows[0]["Year"].ToString();
            Copies.Text = table.Rows[0]["Copies"].ToString();
            Plot.Text = table.Rows[0]["Plot"].ToString();
            Genre.Text = table.Rows[0]["Genre"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Y, C;

            if (Rating.Text == "" || Title.Text == "" || Year.Text == "" || Copies.Text == "" || Plot.Text == "" || Genre.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else if (!int.TryParse(Year.Text, out Y) || !(int.TryParse(Copies.Text, out C)))
            {
                MessageBox.Show("Year and Copies must be a valid integer");
            }
            else
            {
                int Rental = 0;
                if ((DateTime.Now.Year - Y) > 5)
                {
                    Rental = 2;
                }
                else
                {
                    Rental = 5;
                }

                Database database = new Database();
                database.UpdateMovie(Rating.Text, Title.Text, Year.Text, Rental.ToString(), Copies.Text, Plot.Text, Genre.Text, Id);

                MessageBox.Show("Movie Updated");
                Dispose();
            }
        }
    }
}
