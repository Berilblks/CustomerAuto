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
    }
}
