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

namespace Data_Base_Mouse_Devlober_project.Delete_Table
{
    public partial class DeleteTable: Form
    {
        public DeleteTable()
        {
            InitializeComponent();
        }

        void _DeleteTable(String Table,string DB)
        {



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            String query = $@"use {DB}
                              Drop Table {Table}";
            SqlCommand commande = new SqlCommand(query, connection);



            try
            {

                connection.Open();
                SqlDataReader reader = commande.ExecuteReader();

                MessageBox.Show("Tabel Deleted Successfully", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


        }

        private void Delete_Table_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Want To Delete This Table", "Are You Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _DeleteTable(textBox1.Text,textBox2.Text);
            }
        }
    }
}
