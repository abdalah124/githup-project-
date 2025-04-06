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
using System.Diagnostics;
using System.Linq.Expressions;

namespace Data_Base_Mouse_Devlober_project.Create_Tabl
{
    public partial class CreateTable: Form
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
        private string N1="";
        private string N2="";
        private string N3="";
        private string N4="";
        private string N5="";
        private string N6="";
        private string N7="";
        private string N8="";
        private string N9="";
       
        public CreateTable()
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

        void _CreateTable(String Table)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            String query = $@" 
                                use {_DB}
                                 Create Table {Table}(
                               {textBox2.Text}  {textBox3.Text} {N1}{C1}
                               {textBox6.Text}  {textBox5.Text} {N2}{C2}
                               {textBox8.Text}  {textBox7.Text} {N3}{C3}
                               {textBox10.Text}  {textBox9.Text} {N4}{C4}
                               {textBox12.Text}  {textBox11.Text} {N5}{C5}
                               {textBox14.Text}  {textBox13.Text} {N6}{C6}
                               {textBox16.Text}  {textBox15.Text} {N7}{C7}
                               {textBox18.Text}  {textBox17.Text} {N8}{C8}
                               {textBox20.Text}  {textBox19.Text} {N9}
                                

                                  )";
            SqlCommand commande = new SqlCommand(query, connection);



            try
            {

                connection.Open();
                SqlDataReader reader = commande.ExecuteReader();

                MessageBox.Show($"Talbe {Table} Created Successfully in Data Base {_DB} ");
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }

        private void CreateTable_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _CreateTable(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            selectDB(textBox4.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(comboBox1.SelectedIndex == 0)
            {
                C1 = "";
                C2 = "";
                C3 = "";
                C4 = "";
                C5 = "";
                C6 = "";
                C7 = "";
                C8 = "";
                textBox5.Visible = default;
                textBox6.Visible = default;
                textBox7.Visible = default;
                textBox8.Visible = default;
                textBox9.Visible = default;
                textBox10.Visible = default;
                textBox11.Visible = default;
                textBox12.Visible = default;
                textBox13.Visible = default;
                textBox14.Visible = default;
                textBox15.Visible = default;
                textBox16.Visible = default;
                textBox17.Visible = default;
                textBox18.Visible = default;
                textBox19.Visible = default;
                textBox20.Visible = default;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = default;
                label7.Visible = default;
                label10.Visible = default;
                label9.Visible = default;
                label12.Visible = default;
                label11.Visible = default;
                label14.Visible = default;
                label13.Visible = default;
                label16.Visible = default;
                label15.Visible = default;
                label18.Visible = default;
                label17.Visible = default;
                label20.Visible = default;
                label19.Visible = default;
                label22.Visible = default;
                label21.Visible = default;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                radioButton1.Visible = default;
                radioButton2.Visible = default;
                radioButton20.Visible = default;
                radioButton19.Visible = default;
                radioButton6.Visible = default;
                radioButton5.Visible = default;
                radioButton8.Visible = default;
                radioButton7.Visible = default;
                radioButton10.Visible = default;
                radioButton9.Visible = default;
                radioButton12.Visible = default;
                radioButton11.Visible = default;
                radioButton16.Visible = default;
                radioButton15.Visible = default;
                radioButton18.Visible = default;
                radioButton17.Visible = default;
                groupBox10.Visible =true;
                groupBox1.Visible = default;
                groupBox3.Visible = default;
                groupBox2.Visible = default;
                groupBox5.Visible = default;
                groupBox4.Visible = default;
                groupBox8.Visible = default;
                groupBox7.Visible = default;
                groupBox9.Visible = default;


            }

          else if(comboBox1.SelectedIndex == 1)
            {
                C1 = ",";
                C2 = "";
                C3 = "";
                C4 = "";
                C5 = "";
                C6 = "";
                C7 = "";
                C8 = "";

                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = default;
                textBox8.Visible = default;
                textBox9.Visible = default;
                textBox10.Visible = default;
                textBox11.Visible = default;
                textBox12.Visible = default;
                textBox13.Visible = default;
                textBox14.Visible = default;
                textBox15.Visible = default;
                textBox16.Visible = default;
                textBox17.Visible = default;
                textBox18.Visible = default;
                textBox19.Visible = default;
                textBox20.Visible = default;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label10.Visible = default;
                label9.Visible = default;
                label12.Visible = default;
                label11.Visible = default;
                label14.Visible = default;
                label13.Visible = default;
                label16.Visible = default;
                label15.Visible = default;
                label18.Visible = default;
                label17.Visible = default;
                label20.Visible = default;
                label19.Visible = default;
                label22.Visible = default;
                label21.Visible = default;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton20.Visible = default;
                radioButton19.Visible = default;
                radioButton6.Visible = default;
                radioButton5.Visible = default;
                radioButton8.Visible = default;
                radioButton7.Visible = default;
                radioButton10.Visible = default;
                radioButton9.Visible = default;
                radioButton12.Visible = default;
                radioButton11.Visible = default;
                radioButton16.Visible = default;
                radioButton15.Visible = default;
                radioButton18.Visible = default;
                radioButton17.Visible = default;
                groupBox10.Visible = true;
                groupBox1.Visible = true;
                groupBox3.Visible = default;
                groupBox2.Visible = default;
                groupBox5.Visible = default;
                groupBox4.Visible = default;
                groupBox8.Visible = default;
                groupBox7.Visible = default;
                groupBox9.Visible = default;

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
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = default;
                textBox10.Visible = default;
                textBox11.Visible = default;
                textBox12.Visible = default;
                textBox13.Visible = default;
                textBox14.Visible = default;
                textBox15.Visible = default;
                textBox16.Visible = default;
                textBox17.Visible = default;
                textBox18.Visible = default;
                textBox19.Visible = default;
                textBox20.Visible = default;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
                label12.Visible = default;
                label11.Visible = default;
                label14.Visible = default;
                label13.Visible = default;
                label16.Visible = default;
                label15.Visible = default;
                label18.Visible = default;
                label17.Visible = default;
                label20.Visible = default;
                label19.Visible = default;
                label22.Visible = default;
                label21.Visible = default;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton20.Visible = true;
                radioButton19.Visible = true;
                radioButton6.Visible = default;
                radioButton5.Visible = default;
                radioButton8.Visible = default;
                radioButton7.Visible = default;
                radioButton10.Visible = default;
                radioButton9.Visible = default;
                radioButton12.Visible = default;
                radioButton11.Visible = default;
                radioButton16.Visible = default;
                radioButton15.Visible = default;
                radioButton18.Visible = default;
                radioButton17.Visible = default;
                groupBox10.Visible = true;
                groupBox1.Visible = true;
                groupBox3.Visible = true;
                groupBox2.Visible = default;
                groupBox5.Visible = default;
                groupBox4.Visible = default;
                groupBox8.Visible = default;
                groupBox7.Visible = default;
                groupBox9.Visible = default;
            }
          else if(comboBox1.SelectedIndex == 3)
            {
                C1 = ",";
                C2 = ",";
                C3 = ",";
                C4 = "";
                C5 = "";
                C6 = "";
                C7 = "";
                C8 = "";
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = default;
                textBox12.Visible = default;
                textBox13.Visible = default;
                textBox14.Visible = default;
                textBox15.Visible = default;
                textBox16.Visible = default;
                textBox17.Visible = default;
                textBox18.Visible = default;
                textBox19.Visible = default;
                textBox20.Visible = default;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label14.Visible = default;
                label13.Visible = default;
                label16.Visible = default;
                label15.Visible = default;
                label18.Visible = default;
                label17.Visible = default;
                label20.Visible = default;
                label19.Visible = default;
                label22.Visible = default;
                label21.Visible = default;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton20.Visible = true;
                radioButton19.Visible = true;
                radioButton6.Visible = true;
                radioButton5.Visible = true;
                radioButton8.Visible = default;
                radioButton7.Visible = default;
                radioButton10.Visible = default;
                radioButton9.Visible = default;
                radioButton12.Visible = default;
                radioButton11.Visible = default;
                radioButton16.Visible = default;
                radioButton15.Visible = default;
                radioButton18.Visible = default;
                radioButton17.Visible = default;
                groupBox10.Visible = true;
                groupBox1.Visible = true;
                groupBox3.Visible = true;
                groupBox2.Visible = true;
                groupBox5.Visible = default;
                groupBox4.Visible = default;
                groupBox8.Visible = default;
                groupBox7.Visible = default;
                groupBox9.Visible = default;
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
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = default;
                textBox14.Visible = default;
                textBox15.Visible = default;
                textBox16.Visible = default;
                textBox17.Visible = default;
                textBox18.Visible = default;
                textBox19.Visible = default;
                textBox20.Visible = default;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label16.Visible = default;
                label15.Visible = default;
                label18.Visible = default;
                label17.Visible = default;
                label20.Visible = default;
                label19.Visible = default;
                label22.Visible = default;
                label21.Visible = default;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton20.Visible = true;
                radioButton19.Visible = true;
                radioButton6.Visible = true;
                radioButton5.Visible = true;
                radioButton8.Visible = true;
                radioButton7.Visible = true;
                radioButton10.Visible = default;
                radioButton9.Visible = default;
                radioButton12.Visible = default;
                radioButton11.Visible = default;
                radioButton16.Visible = default;
                radioButton15.Visible = default;
                radioButton18.Visible = default;
                radioButton17.Visible = default;
                groupBox10.Visible = true;
                groupBox1.Visible = true;
                groupBox3.Visible = true;
                groupBox2.Visible = true;
                groupBox5.Visible = true;
                groupBox4.Visible = default;
                groupBox8.Visible = default;
                groupBox7.Visible = default;
                groupBox9.Visible = default;
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
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = default;
                textBox16.Visible = default;
                textBox17.Visible = default;
                textBox18.Visible = default;
                textBox19.Visible = default;
                textBox20.Visible = default;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label16.Visible = true;
                label15.Visible = true;
                label18.Visible = default;
                label17.Visible = default;
                label20.Visible = default;
                label19.Visible = default;
                label22.Visible = default;
                label21.Visible = default;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton20.Visible = true;
                radioButton19.Visible = true;
                radioButton6.Visible = true;
                radioButton5.Visible = true;
                radioButton8.Visible = true;
                radioButton7.Visible = true;
                radioButton10.Visible = true;
                radioButton9.Visible = true;
                radioButton12.Visible = default;
                radioButton11.Visible = default;
                radioButton16.Visible = default;
                radioButton15.Visible = default;
                radioButton18.Visible = default;
                radioButton17.Visible = default;
                groupBox10.Visible = true;
                groupBox1.Visible = true;
                groupBox3.Visible = true;
                groupBox2.Visible = true;
                groupBox5.Visible = true;
                groupBox4.Visible = true;
                groupBox8.Visible = default;
                groupBox7.Visible = default;
                groupBox9.Visible = default;

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
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = default;
                textBox18.Visible = default;
                textBox19.Visible = default;
                textBox20.Visible = default;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label16.Visible = true;
                label15.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
                label20.Visible = default;
                label19.Visible = default;
                label22.Visible = default;
                label21.Visible = default;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton20.Visible = true;
                radioButton19.Visible = true;
                radioButton6.Visible = true;
                radioButton5.Visible = true;
                radioButton8.Visible = true;
                radioButton7.Visible = true;
                radioButton10.Visible = true;
                radioButton9.Visible = true;
                radioButton12.Visible = true;
                radioButton11.Visible = true;
                radioButton16.Visible = default;
                radioButton15.Visible = default;
                radioButton18.Visible = default;
                radioButton17.Visible = default;
                groupBox10.Visible = true;
                groupBox1.Visible = true;
                groupBox3.Visible = true;
                groupBox2.Visible = true;
                groupBox5.Visible = true;
                groupBox4.Visible = true;
                groupBox8.Visible = true;
                groupBox7.Visible = default;
                groupBox9.Visible = default;

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
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;
                textBox19.Visible = default;
                textBox20.Visible = default;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label16.Visible = true;
                label15.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
                label20.Visible = true;
                label19.Visible = true;
                label22.Visible = default;
                label21.Visible = default;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton20.Visible = true;
                radioButton19.Visible = true;
                radioButton6.Visible = true;
                radioButton5.Visible = true;
                radioButton8.Visible = true;
                radioButton7.Visible = true;
                radioButton10.Visible = true;
                radioButton9.Visible = true;
                radioButton12.Visible = true;
                radioButton11.Visible = true;
                radioButton16.Visible = true;
                radioButton15.Visible = true;
                radioButton18.Visible = default;
                radioButton17.Visible = default;
                groupBox10.Visible = true;
                groupBox1.Visible = true;
                groupBox3.Visible = true;
                groupBox2.Visible = true;
                groupBox5.Visible = true;
                groupBox4.Visible = true;
                groupBox8.Visible = true;
                groupBox7.Visible = true;
                groupBox9.Visible = default;

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

                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;
                textBox19.Visible = true;
                textBox20.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label16.Visible = true;
                label15.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
                label20.Visible = true;
                label19.Visible = true;
                label22.Visible = true;
                label21.Visible = true;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton20.Visible = true;
                radioButton19.Visible = true;
                radioButton6.Visible = true;
                radioButton5.Visible = true;
                radioButton8.Visible = true;
                radioButton7.Visible = true;
                radioButton10.Visible = true;
                radioButton9.Visible = true;
                radioButton12.Visible = true;
                radioButton11.Visible = true;
                radioButton16.Visible = true;
                radioButton15.Visible = true;
                radioButton18.Visible = true;
                radioButton17.Visible = true;
                groupBox10.Visible = true;
                groupBox1.Visible = true;
                groupBox3.Visible = true;
                groupBox2.Visible = true;
                groupBox5.Visible = true;
                groupBox4.Visible = true;
                groupBox8.Visible = true;
                groupBox7.Visible = true;
                groupBox9.Visible = true;

            }
        }

      
      

       

       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            N2 = "Not Null";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            N1 = "Null";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            N1 = "Not Null";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            N2 = "Null";
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            N3 = "Null";
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            N3 = "Not Null";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            N4 = "Null";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            N4 = "Not Null";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            N5 = "Null";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            N5 = "Not Null";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            N6 = "Null";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            N6 = "Not Null";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            N7 = "Null";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            N7 = "Not Null";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            N8 = "Null";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            N8 = "Not Null";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            N9 = "Null";
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            N9 = "Not Null";
        }
    }
}
