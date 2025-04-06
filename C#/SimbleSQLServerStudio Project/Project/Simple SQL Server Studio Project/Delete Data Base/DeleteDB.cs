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

namespace Data_Base_Mouse_Devlober_project.Delete_Data_Base
{
    public partial class DeleteDB: Form
    {
        public DeleteDB()
        {
            InitializeComponent();
        }

        void _DeleteDB(String DB)
        {

           

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            String query = $" Drop database {DB}";
            SqlCommand commande = new SqlCommand(query, connection);



            try
            {

                connection.Open();
                SqlDataReader reader = commande.ExecuteReader();

                MessageBox.Show("Data Base Deleted Successfully", "Deleted Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


        }


        private void DeleteDB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Want To Delete This Data Base", "Are You Sure",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _DeleteDB(textBox1.Text);
            }
            
           
        }
    }
}
