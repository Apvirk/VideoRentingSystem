using System.Windows.Forms;

namespace VideoRentingSystem
{
    public partial class BestSellingMovies : Form
    {
        public BestSellingMovies()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Database().GetTopMovies();
        }
    }
}
