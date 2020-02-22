using EmployeeManagement.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeManagement.Repository
{
    public class EmployeeRep :IUserRepository
    {
        public SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Database=EmployeeManagements;IntegratedSecurity=true");
        
        public void AddEmployee(Employees employee)
        {
            SqlCommand command = new SqlCommand("spAddEmployee", Connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@userId", employee.Id);
            command.Parameters.AddWithValue("@FirstName", employee.FirstName);
            command.Parameters.AddWithValue("@LastName", employee.LastName);
            command.Parameters.AddWithValue("@email", employee.Email);
            command.Parameters.AddWithValue("@UserName", employee.UserName);
            command.Parameters.AddWithValue("@password", employee.Password);
            command.Parameters.AddWithValue("@Mobile", employee.Mobile);
            command.Parameters.AddWithValue("@address", employee.Address);

            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public void UpdateEmployee(Employees employee)
        {
            SqlCommand command = new SqlCommand("spUpdateemployee ", Connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@userId", employee.Id);
            command.Parameters.AddWithValue("@FirstName", employee.FirstName);
            command.Parameters.AddWithValue("@LastName", employee.LastName);
            command.Parameters.AddWithValue("@email", employee.Email);
            command.Parameters.AddWithValue("@UserName", employee.UserName);
            command.Parameters.AddWithValue("@password", employee.Password);
            command.Parameters.AddWithValue("@Mobile", employee.Mobile);
            command.Parameters.AddWithValue("@address", employee.Address);

            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();

            Console.WriteLine("Upadated");
        }   
        public IEnumerable<Employees> GetAllEmployee()
        {

            List<Employees> employees = new List<Employees>();

            SqlCommand command = new SqlCommand("spGetAllemployee ", Connection);
            command.CommandType = CommandType.StoredProcedure;
            Connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Employees employee = new Employees();
                employee.Id = Convert.ToInt32(dataReader["Id"]);
                employee.FirstName = dataReader["FirstName"].ToString();
                employee.LastName = dataReader["LastName"].ToString();
                employee.Email = dataReader["Email"].ToString();
                employee.UserName = dataReader["UserName"].ToString();
                employee.Password = dataReader["PassWord"].ToString();
                employee.Mobile = dataReader["Mobile"].ToString();
                employee.Address = dataReader["Address"].ToString();
                employees.Add(employee);

            }
            Connection.Close();

            return employees;
        }

        public void DeleteEmployee(int? userId)
        {
            SqlCommand cmd = new SqlCommand("spDeleteEmployee", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@userId", userId);

           Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public bool LoginEmployee(string username, string password)
        {
            SqlCommand cmd = new SqlCommand("spGetAllemployee", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                Connection.Open();
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    if (Equals(data["PassWord"].ToString(),password))
                    {
                        if (Equals(data["UserName"].ToString(), username))
                        {
                            return true;
                        }
                    }
                }

                Connection.Close();
               return false;
            
        }
    }
    }

