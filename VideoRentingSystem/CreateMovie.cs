using System;
using System.Windows.Forms;

namespace VideoRentingSystem
{
    public partial class CreateMovie : Form
    {
        public CreateMovie()
        {
            InitializeComponent();
        }

        private void CreateMovie_Load(object sender, EventArgs e)
        {

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
                database.AddMovie(Rating.Text, Title.Text, Year.Text, Rental.ToString(), Copies.Text, Plot.Text, Genre.Text);

                MessageBox.Show("Movie Added");
            }
        }
    }
}
