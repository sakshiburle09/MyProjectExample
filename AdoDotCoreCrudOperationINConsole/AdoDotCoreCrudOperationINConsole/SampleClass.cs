using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotCoreCrudOperationINConsole
{
    internal class SampleClass
    {
        public static void Main(string[] args)
        {

            // Console.WriteLine("Connection Sucessful");
            try
            {
                string ConnectionString = "Server=DESKTOP-IFP4QPL; Database = employeedb; Integrated Security=True";
                //calling GetAllEmployees
                GetAllEmployees(ConnectionString);
                //Calling GetEmployeesByID
                int EmployeeId = 1;
                GetEmployeeByID(ConnectionString, EmployeeId);
                //Calling CreateEmployeeWithAddress
                Console.WriteLine("Enter the first name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter the last name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter the email id:");
                string email = Console.ReadLine();
                Console.WriteLine("Enter the street name:");
                string street = Console.ReadLine();
                Console.WriteLine("Enter the city name:");
                string city = Console.ReadLine();
                Console.WriteLine("Enter the state name:");
                string state = Console.ReadLine();
                Console.WriteLine("Enter the postal code:");
                string postalCode = Console.ReadLine();
                createEmpolyeeWithAddress(ConnectionString, firstName, lastName, email, street, city, state, postalCode);
                //calling UpdateEmployeeWithAddress
                int employeeID = 3;
                Console.WriteLine("Enter the first name:");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter the last name:");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter the email id:");
                email = Console.ReadLine();
                Console.WriteLine("Enter the street name:");
                street = Console.ReadLine();
                Console.WriteLine("Enter the city name:");
                city = Console.ReadLine();
                Console.WriteLine("Enter the state name:");
                state = Console.ReadLine();
                Console.WriteLine("Enter the postal code:");
                postalCode = Console.ReadLine();
                int addressID = 3;
                UpdateEmployeeWithAddress(ConnectionString, employeeID, firstName, lastName, email, street, city, state, postalCode, addressID);
                //calling
                employeeID = 3;
                deleteemployee(ConnectionString, employeeID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong:{ex.Message}");
            }
        }
        public static void GetAllEmployees(string connectionString)
        {
            Console.WriteLine("GetAllEmployees stored procedure called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetAllEmployees", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"EmployeeID:{reader["EmployeeID"]},Firstname:{reader["Firstname"]}, Lastname:{reader["Lastname"]},Email:{reader["Email"]}");
                    Console.WriteLine($"Address:{reader["Street"]},{reader["City"]},{reader["State"]},PostalCode:{reader["postalCode"]}\n");
                }
                reader.Close();
                connection.Close();
            }
        }

        public static void GetEmployeeByID(string connectionString, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("GetEmployeeByID stored procedure called");
                SqlCommand command = new SqlCommand("GetEmployeeByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                //add parameters foe EmployeeID
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Employee:{reader["FirstName"]},{reader["LastName"]},Email:{reader["Email"]}");
                    Console.WriteLine($"Address:{reader["Street"]},{reader["City"]},{reader["State"]},{reader["PostalCode"]}");
                }
                reader.Close();
                connection.Close();
            }
        }
        public static void createEmpolyeeWithAddress(string connectionString, string firstName, string lastName, string email, string street, string city, string state, string postalCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("createEmpolyeeWithAddress stored procedure called");
                SqlCommand command = new SqlCommand("createEmpolyeeWithAddress", connection);
                command.CommandType=CommandType.StoredProcedure;
                //Add parameter for Employee and Address
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Street", street);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@State", state);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Address created successfully.");
                connection.Close() ;
            }
        }
        public static void UpdateEmployeeWithAddress(string connectionString, int employeeID, string firstName, string lastName, string email, string street, string city, string state, string postalCode, int addressID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("UpdateEmployeeWithAddress stored procedure called");
                SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;
                //Add parameters for employee and address
                command.Parameters.AddWithValue("@EmployeeID ", employeeID);
                command.Parameters.AddWithValue("@FirstName ", firstName);
                command.Parameters.AddWithValue("@LastName ", lastName);
                command.Parameters.AddWithValue("@Email ", email);
                command.Parameters.AddWithValue("@Street ", street);
                command.Parameters.AddWithValue("@City ", city);
                command.Parameters.AddWithValue("@State ", state);
                command.Parameters.AddWithValue("@PostalCode ", postalCode);
                command.Parameters.AddWithValue("@AddressID", addressID);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and AddressUpdated successfully.");
                connection.Close();
            }
            }
        static void deleteemployee(string connectionString, int employeeid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Delete Employee stored procedure called");
                SqlCommand command = new SqlCommand("deleteemployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@employeeid", employeeid);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Employee and their address deleted successfully");
                }
                else
                {
                    Console.WriteLine("employee not found");
                }
                connection.Close();
            }

        }


    }
}
