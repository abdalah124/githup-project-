using DataBaseAccess;
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

namespace Data_Base_Mouse_Devlober_project.Select_All_From_Table
{
    public partial class SelectAllFromTable: Form
    {
        public SelectAllFromTable()
        {
            InitializeComponent();
        }

        public static DataTable GetAllInfo(string DB, string Table)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = $@" use {DB}
                            SELECT * FROM {Table}";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();

                

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
           

            return dt;

        }

        public void GetData()
        {
            dataGridView1.DataSource = GetAllInfo(TbSelectDB.Text,TbTable.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void SelectAllFromTable_Load(object sender, EventArgs e)
        {

        }
    }
}
