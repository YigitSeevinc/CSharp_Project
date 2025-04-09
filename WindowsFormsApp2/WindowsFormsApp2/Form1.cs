using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=serverName;Initial Catalog=databaseName;Integrated Security=True";
            string query = "SELECT * FROM tableName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
        }
    }
}




/*using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=serverName;Initial Catalog=databaseName;Integrated Security=True";
            string query = "SELECT * FROM tableName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
        }
    }
}*/
