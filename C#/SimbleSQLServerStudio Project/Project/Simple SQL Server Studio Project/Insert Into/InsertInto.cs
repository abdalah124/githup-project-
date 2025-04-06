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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Data_Base_Mouse_Devlober_project.Insert_Into
{
    public partial class InsertInto: Form
    {
        private string _DB;
        private string C1;
        private string C2;
        private string C3;
        private string C4;
        private string C5;
        private string C6;
        private string C7;
        private string C8;
        private string S1;
        private string S2;
        private string S3;
        private string S4;
        private string S5;
        private string S6;
        private string S7;
        private string S8;
        private string S9;
       
        public InsertInto()
        {
            InitializeComponent();
        }

        void selectDB(String DB)
        {

            _DB = DB;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            String query = $" Use {DB}";
            SqlCommand commande = new SqlCommand(query, connection);



            try
            {

                connection.Open();
                SqlDataReader reader = commande.ExecuteReader();

                MessageBox.Show($"DataBase {DB} Selected Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }
        void _InsetrIntoTable(String Table)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            String query = $@" use {_DB}
                                 insert into  {Table}
                                 values({S1}{TbValue1.Text}{S1}{C1}{S2}{TbValue2.Text}{S2}{C2}{S3}{TbValue3.Text}{S3}{C3}{S4}{TbValue4.Text}{S4}{C4}{S5}{TbValue5.Text}{S5}{C5}{S6}{TbValue6.Text}{S6}{C6}{S7}{TbValue7.Text}{S7}{C7}{S8}{TbValue8.Text}{S8}{C8}{S9}{TbValue9.Text}{S9})";
            SqlCommand commande = new SqlCommand(query, connection);

           

            try
            {
              

                connection.Open();
                SqlDataReader reader = commande.ExecuteReader();

                MessageBox.Show($"Values Inserted Successfully in Table {Table} in Data Base {_DB} ");
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }

        public void CheckintOrString()
        {
            int Out;

            if (int.TryParse(TbValue1.Text, out Out) || TbValue1.Text == string.Empty) { S1 = ""; } else { S1 = "'"; }
            if (int.TryParse(TbValue2.Text, out Out) || TbValue2.Text == string.Empty) { S2 = ""; } else { S2 = "'"; }
            if (int.TryParse(TbValue3.Text, out Out) || TbValue3.Text == string.Empty) { S3 = ""; } else { S3 = "'"; }
            if (int.TryParse(TbValue4.Text, out Out) || TbValue4.Text == string.Empty) { S4 = ""; } else { S4 = "'"; }
            if (int.TryParse(TbValue5.Text, out Out) || TbValue5.Text == string.Empty) { S5 = ""; } else { S5 = "'"; }
            if (int.TryParse(TbValue6.Text, out Out) || TbValue6.Text == string.Empty) { S6 = ""; } else { S6 = "'"; }
            if (int.TryParse(TbValue7.Text, out Out) || TbValue7.Text == string.Empty) { S7 = ""; } else { S7 = "'"; }
            if (int.TryParse(TbValue8.Text, out Out) || TbValue8.Text == string.Empty) { S8 = ""; } else { S8 = "'"; }
            if (int.TryParse(TbValue9.Text, out Out) || TbValue9.Text == string.Empty) { S9 = ""; } else { S9 = "'"; }
        }

        private void InsertInto_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectDB(textBox4.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                C1 = "";
                C2 = "";
                C3 = "";
                C4 = "";
                C5 = "";
                C6 = "";
                C7 = "";
                C8 = "";
                lblValue1.Visible = true;
                lblValue2.Visible = default;
                lblValue3.Visible = default;
                lblValue4.Visible = default;
                lblValue5.Visible = default;
                lblValue6.Visible = default;
                lblValue7.Visible = default;
                lblValue8.Visible = default;
                lblValue9.Visible = default;
                TbValue1.Visible = true;
                TbValue2.Visible = default;
                TbValue3.Visible = default;
                TbValue4.Visible = default;
                TbValue5.Visible = default;
                TbValue6.Visible = default;
                TbValue7.Visible = default;
                TbValue8.Visible = default;
                TbValue9.Visible = default;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                C1 = ",";
                C2 = "";
                C3 = "";
                C4 = "";
                C5 = "";
                C6 = "";
                C7 = "";
                C8 = "";
                lblValue1.Visible = true;
                lblValue2.Visible = true;
                lblValue3.Visible = default;
                lblValue4.Visible = default;
                lblValue5.Visible = default;
                lblValue6.Visible = default;
                lblValue7.Visible = default;
                lblValue8.Visible = default;
                lblValue9.Visible = default;
                TbValue1.Visible = true;
                TbValue2.Visible = true;
                TbValue3.Visible = default;
                TbValue4.Visible = default;
                TbValue5.Visible = default;
                TbValue6.Visible = default;
                TbValue7.Visible = default;
                TbValue8.Visible = default;
                TbValue9.Visible = default;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                C1 = ",";
                C2 = ",";
                C3 = "";
                C4 = "";
                C5 = "";
                C6 = "";
                C7 = "";
                C8 = "";
                lblValue1.Visible = true;
                lblValue2.Visible = true;
                lblValue3.Visible = true;
                lblValue4.Visible = default;
                lblValue5.Visible = default;
                lblValue6.Visible = default;
                lblValue7.Visible = default;
                lblValue8.Visible = default;
                lblValue9.Visible = default;
                TbValue1.Visible = true;
                TbValue2.Visible = true;
                TbValue3.Visible = true;
                TbValue4.Visible = default;
                TbValue5.Visible = default;
                TbValue6.Visible = default;
                TbValue7.Visible = default;
                TbValue8.Visible = default;
                TbValue9.Visible = default;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                C1 = ",";
                C2 = ",";
                C3 = ",";
                C4 = "";
                C5 = "";
                C6 = "";
                C7 = "";
                C8 = "";
                lblValue1.Visible = true;
                lblValue2.Visible = true;
                lblValue3.Visible = true;
                lblValue4.Visible = true;
                lblValue5.Visible = default;
                lblValue6.Visible = default;
                lblValue7.Visible = default;
                lblValue8.Visible = default;
                lblValue9.Visible = default;
                TbValue1.Visible = true;
                TbValue2.Visible = true;
                TbValue3.Visible = true;
                TbValue4.Visible = true;
                TbValue5.Visible = default;
                TbValue6.Visible = default;
                TbValue7.Visible = default;
                TbValue8.Visible = default;
                TbValue9.Visible = default;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                C1 = ",";
                C2 = ",";
                C3 = ",";
                C4 = ",";
                C5 = "";
                C6 = "";
                C7 = "";
                C8 = "";
                lblValue1.Visible = true;
                lblValue2.Visible = true;
                lblValue3.Visible = true;
                lblValue4.Visible = true;
                lblValue5.Visible = true;
                lblValue6.Visible = default;
                lblValue7.Visible = default;
                lblValue8.Visible = default;
                lblValue9.Visible = default;
                TbValue1.Visible = true;
                TbValue2.Visible = true;
                TbValue3.Visible = true;
                TbValue4.Visible = true;
                TbValue5.Visible = true;
                TbValue6.Visible = default;
                TbValue7.Visible = default;
                TbValue8.Visible = default;
                TbValue9.Visible = default;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                C1 = ",";
                C2 = ",";
                C3 = ",";
                C4 = ",";
                C5 = ",";
                C6 = "";
                C7 = "";
                C8 = "";
                lblValue1.Visible = true;
                lblValue2.Visible = true;
                lblValue3.Visible = true;
                lblValue4.Visible = true;
                lblValue5.Visible = true;
                lblValue6.Visible = true;
                lblValue7.Visible = default;
                lblValue8.Visible = default;
                lblValue9.Visible = default;
                TbValue1.Visible = true;
                TbValue2.Visible = true;
                TbValue3.Visible = true;
                TbValue4.Visible = true;
                TbValue5.Visible = true;
                TbValue6.Visible = true;
                TbValue7.Visible = default;
                TbValue8.Visible = default;
                TbValue9.Visible = default;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                C1 = ",";
                C2 = ",";
                C3 = ",";
                C4 = ",";
                C5 = ",";
                C6 = ",";
                C7 = "";
                C8 = "";
                lblValue1.Visible = true;
                lblValue2.Visible = true;
                lblValue3.Visible = true;
                lblValue4.Visible = true;
                lblValue5.Visible = true;
                lblValue6.Visible = true;
                lblValue7.Visible = true;
                lblValue8.Visible = default;
                lblValue9.Visible = default;
                TbValue1.Visible = true;
                TbValue2.Visible = true;
                TbValue3.Visible = true;
                TbValue4.Visible = true;
                TbValue5.Visible = true;
                TbValue6.Visible = true;
                TbValue7.Visible = true;
                TbValue8.Visible = default;
                TbValue9.Visible = default;
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                C1 = ",";
                C2 = ",";
                C3 = ",";
                C4 = ",";
                C5 = ",";
                C6 = ",";
                C7 = ",";
                C8 = "";
                lblValue1.Visible = true;
                lblValue2.Visible = true;
                lblValue3.Visible = true;
                lblValue4.Visible = true;
                lblValue5.Visible = true;
                lblValue6.Visible = true;
                lblValue7.Visible = true;
                lblValue8.Visible = true;
                lblValue9.Visible = default;
                TbValue1.Visible = true;
                TbValue2.Visible = true;
                TbValue3.Visible = true;
                TbValue4.Visible = true;
                TbValue5.Visible = true;
                TbValue6.Visible = true;
                TbValue7.Visible = true;
                TbValue8.Visible = true;
                TbValue9.Visible = default;
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                C1 = ",";
                C2 = ",";
                C3 = ",";
                C4 = ",";
                C5 = ",";
                C6 = ",";
                C7 = ",";
                C8 = ",";
                lblValue1.Visible = true;
                lblValue2.Visible = true;
                lblValue3.Visible = true;
                lblValue4.Visible = true;
                lblValue5.Visible = true;
                lblValue6.Visible = true;
                lblValue7.Visible = true;
                lblValue8.Visible = true;
                lblValue9.Visible = true;
                TbValue1.Visible = true;
                TbValue2.Visible = true;
                TbValue3.Visible = true;
                TbValue4.Visible = true;
                TbValue5.Visible = true;
                TbValue6.Visible = true;
                TbValue7.Visible = true;
                TbValue8.Visible = true;
                TbValue9.Visible = true;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             CheckintOrString();
            _InsetrIntoTable(textBox1.Text);
            
        }
    }
}
