using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO1
{
    class Program
    {
        static void Main(String[] args)
        {
            SqlDataReader reader = null;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=. ; Initial Catalog=EMPMGMTDB; Integrated Security=True";
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT empid, empName FROM Employee", connection);


            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
                Console.WriteLine(reader[1]);
           }
            reader.Close();
            connection.Close();
            Console.ReadLine();
        }
    }
}

        










        