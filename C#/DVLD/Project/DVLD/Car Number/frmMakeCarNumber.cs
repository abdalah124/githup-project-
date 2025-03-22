using DVLD_Buisness;
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
using DVLD_DataAccess;

namespace DVLD.Car_Number
{
    public partial class frmMakeCarNumber : Form
    {
      private  int _PersonID = -1;
        private string _CarNumber = "";

        public frmMakeCarNumber()
        {

            InitializeComponent();

        }

        public frmMakeCarNumber(int PersonID,string CarNumber)
        {

            InitializeComponent();
            PersonID = ctrlPersonCardWithFilter1.PersonID;
            CarNumber = lblCarNo.Text;
            

        }


        public static bool Add( int PersonID, string CarNumber)
        {
            

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  People  
                                set CarNumber = @CarNumber

                                    where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CarNumber", CarNumber);

            

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

                

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }



        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            

            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {






                tpLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];

            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100, 1000);

            Random Random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string randomString = "";
            for (int i = 0; i < 3; i++)
            {
                randomString += chars[random.Next(chars.Length)];
            }

            lblCarNo.Text = randomString + "-" + randomNumber.ToString();
            button1.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Add(ctrlPersonCardWithFilter1.PersonID,lblCarNo.Text);
            if(Add(ctrlPersonCardWithFilter1.PersonID, lblCarNo.Text))
            {
                MessageBox.Show("Car Number is Save Successfully", "Saved  Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show( "The Car Number Doesn't Save" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            
        }
    }
        
         
    }

    

    
    

