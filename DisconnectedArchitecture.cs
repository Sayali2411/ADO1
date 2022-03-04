using System;
using System.Data;
using System.Data.SqlClient;
namespace ADO1
{
    class DisconnectedArchitecture
    {
        static void Main(String[] args)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source= .\\SQLEXPRESS; Initial Catalog=Testing; Integrated Security= True"))
            {
                try
                {
                   connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("EmpId, EmpName FROM Emp", connection);
                    DataSet dsEmp = new DataSet();
                    DataTable dtEmp = dsEmp.Tables[0];
                    adapter.Fill(dtEmp);
                    foreach (DataRow row in dtEmp.Rows)
                    {
                        Console.WriteLine(row[0] + "" + row[1] + "" + row[2]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            Console.ReadLine();
        }
    }
}