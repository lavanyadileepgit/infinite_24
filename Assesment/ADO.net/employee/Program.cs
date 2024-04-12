using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Program
        {
            static void Main()
            {
                string connectionString = "Data Source=ICS-LT-FQW1ZD3;Initial Catalog=employeemanagement;Integrated Security=True"; 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("addemployee", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        Console.Write("Enter name: ");
                        string Name = Console.ReadLine();
                        Console.Write("Enter salary: ");
                        string salary = Console.ReadLine();
                        Console.Write("Enter employee type: ");
                        string type = Console.ReadLine();

                        command.Parameters.AddWithValue("@name", Name);
                        command.Parameters.AddWithValue("@empsal", salary);
                        command.Parameters.AddWithValue("@emptype",type );

                        command.ExecuteNonQuery();
                    Console.WriteLine();
                        Console.WriteLine("Employee added successfully : )");
                    }

                    connection.Close();
                }
            Console.WriteLine();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Employee_Details", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Empno\tEmpName\t\tEmpsal\tEmptype");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Empno"]}\t{reader["EmpName"],-15}\t{reader["Empsal"]}\t{reader["Emptype"]}");
                    }
                }

                connection.Close();
            }



            Console.ReadLine(); 
            }
        }
    }


