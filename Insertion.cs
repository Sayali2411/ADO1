using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO1
{
    class Insertion
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the employee id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the employee name");
                string name = Console.ReadLine();
                Console.WriteLine("enter the salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the mobile number");
                string phone = Console.ReadLine();
                SqlConnection connection = new SqlConnection("Data Source= .\\SQLEXPRESS; Initial Catalog=Testing; Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO EMP(EmpId,EmpName,Salary,Phone)VALUES(@EmpId,@EmpName,@Salary,@Phone )", connection);
                command.Parameters.AddWithValue("@empId", id);
                command.Parameters.AddWithValue("@empName", name);
                command.Parameters.AddWithValue("@eSalary", salary);
                command.Parameters.AddWithValue("@Phone", phone);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Details saved successfully");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Details saved successfully");
        }
    }
}





