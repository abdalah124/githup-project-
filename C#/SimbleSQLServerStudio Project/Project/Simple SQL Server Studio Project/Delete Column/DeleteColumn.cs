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
using System.Data.Common;

namespace Data_Base_Mouse_Devlober_project.Delete_Column
{
    public partial class DeleteColumn: Form
    {
        public DeleteColumn()
        {
            InitializeComponent();
        }
        void _DeleteColumn(String Table,string DB)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            String query = $@" use {DB}
                                 Alter Table {Table} 
                                  Drop Column {textBox1.Text}";
            SqlCommand commande = new SqlCommand(query, connection);



            try
            {


                connection.Open();
                SqlDataReader reader = commande.ExecuteReader();

                MessageBox.Show($"Column {textBox1.Text} Deleted Successfully in Table {Table} in Data Base {DB} ");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


        }
        private void DeleteColumn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Want To Delete This Column", "Are You Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _DeleteColumn(textBox3.Text, textBox2.Text);
            }
        }
    }
}
