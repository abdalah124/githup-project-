using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataBaseAccess;

namespace Data_Base_Mouse_Devlober_project.Create_Data_Base
{
    public partial class frmCreateDB: Form
    {
        public frmCreateDB()
        {
            InitializeComponent();
        }

        void CreateDB(String DB)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            String query = $" Create database {DB}";
            SqlCommand commande = new SqlCommand(query, connection);

           

            try
            {

                connection.Open();
                SqlDataReader reader = commande.ExecuteReader();

                MessageBox.Show($"DataBase {DB} Created Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }
        private void frmCreateDB_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDB(textBox1.Text);
        }
    }
}
