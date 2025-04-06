using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;




namespace DataBaseAccess
{
   

    public  class clsDataAccessSettings
    {
         


        public static string ConnectionString = $"Server=.;Database=master;User Id=sa;Password=sa123456;";


        public static DataTable GetTableInfo(string Table,string DB)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = $@"use {DB}
                              select * from {Table}";

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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

    } 

  

        
        
}


    

