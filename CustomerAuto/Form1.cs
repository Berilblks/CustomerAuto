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
                MessageBox.Show("An error occurred while database connection, ErrorCode:H001\n " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            textBoxCustomerID.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            textBoxIncome.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
            textBoxAdress.Text = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();

            string text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
            if (text.Equals("True"))
                textBoxLoan.Text = "Suitable";
            else
                textBoxLoan.Text = "Not Suitable";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Costumers (Name,Surname,MonthlyIncome," + " SuitableLoan, Adress) " +
                                                        "VALUES (@P1, @P2, @P3, @P4, @P5)", connection);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxName.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxSurname.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxIncome.Text);
                if (Convert.ToInt32(textBoxIncome.Text) >= 10000)
                {
                    sqlCommand.Parameters.AddWithValue("@P4", 1);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@P4", 0);
                }
                sqlCommand.Parameters.AddWithValue("@P5", textBoxAdress.Text);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the record, ErrorCode:H002\n " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            dataView();
            clear();
        }

        private void clear()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxIncome.Clear();
            textBoxLoan.Clear();
            textBoxAdress.Clear();
            textBoxCustomerID.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonCustomerDelete_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerID.Text.Equals("0"))
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Costumers WHERE CustomerID=@P1", connection);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxCustomerID.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while delete the customer, ErrorCode:H003\n " + ex.Message);
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }
            }
            dataView();
            clear();
        }
    }
}
