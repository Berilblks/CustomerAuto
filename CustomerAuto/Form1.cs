using System.Data;
using System.Data.SqlClient;

namespace CustomerAuto
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LENOVO-BERIL;Initial Catalog=projelerVT;Integrated Security=True;Encrypt=False");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataView();
            dataGridView1.ClearSelection();
            textBoxCustomerID.Text = "0";
        }

        private void dataView()
        {
            try
            {
                string query = "SELECT * FROM Costumers";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred, ErrorCode:H001\n " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            textBoxCustomerID.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            textBoxIncome.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
            textBoxLoan.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
            textBoxAdress.Text = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();

        }
    }
}
