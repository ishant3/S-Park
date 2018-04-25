using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Npgsql;

namespace S_Park_Android
{
   public class Database_Connection
    {
       public string ConnectionString = "Server=10.0.0.1; Port=5432; User Id= postgres; Password=postgres; Database=postgres";
      public  string Id = "";
       public string Status;
        List<string> dataitems = new List<string>();

        public List<string> MyConnection()
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("Select * from public.Parking_Space",connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                for(int i=0;reader.Read();i++)
                {
                    dataitems.Add("Id: "+reader[0].ToString()+ "and Status: "+reader[1].ToString());

                }
                connection.Close();
                return dataitems;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}