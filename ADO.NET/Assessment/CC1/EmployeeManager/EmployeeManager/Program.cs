using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=ICS-LT-7X2B693\\SQLEXPRESS;Database=Employeemanagement;User Id=sa;Password=Sky@9531;";

            Console.WriteLine("Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Employee Salary:");
            decimal empSal = 0;
            while (!decimal.TryParse(Console.ReadLine(), out empSal) || empSal < 25000)
            {
                Console.WriteLine("Invalid input. Please enter a salary greater than or equal to 25000:");
            }

            Console.WriteLine("Employee Type (F -> Full-time, P -> Part-time):");
            char empType = ' ';
            while (!char.TryParse(Console.ReadLine(), out empType) || (empType != 'F' && empType != 'P'))
            {
                Console.WriteLine("Invalid input");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand("AddEmployee", connection))
                    {
                        insertCommand.CommandType = CommandType.StoredProcedure;

                        insertCommand.Parameters.AddWithValue("@EmpName", empName);
                        insertCommand.Parameters.AddWithValue("@EmpSal", empSal);
                        insertCommand.Parameters.AddWithValue("@EmpType", empType);

                        int newEmpNo = (int)insertCommand.ExecuteScalar();
                        Console.WriteLine($"New employee added with EmpNo: {newEmpNo}");
                    }

                    using (SqlCommand selectCommand = new SqlCommand("SELECT * FROM Employee_Details", connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            Console.WriteLine("Employee Details:");
                            Console.WriteLine("EmpNo\tEmpName\tEmpSal\tEmpType");
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["EmpNo"]}\t{reader["EmpName"]}\t{reader["EmpSal"]}\t{reader["EmpType"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
