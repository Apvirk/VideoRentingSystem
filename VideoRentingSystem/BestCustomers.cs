using System.Windows.Forms;

namespace VideoRentingSystem
{
    public partial class BestCustomers : Form
    {
        public BestCustomers()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Database().GetBestCustomers();
        }
    }
}
