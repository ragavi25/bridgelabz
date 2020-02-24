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
        public SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Fundoo;Integrated Security=True");
        
        public void AddEmployee(Employees employee)
        {
            SqlCommand command = new SqlCommand("spAddEmployee", Connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FirstName", employee.FirstName);
            command.Parameters.AddWithValue("@LastName", employee.LastName);
            command.Parameters.AddWithValue("@Email", employee.Email);
            command.Parameters.AddWithValue("@PassWord", employee.Password);
            command.Parameters.AddWithValue("@Mobile", employee.Mobile);

            Connection.Open();
            int i=command.ExecuteNonQuery();
            Connection.Close();
            if (i > 0)
            {
                Console.WriteLine("Added");
            }
           
        }

        public void UpdateEmployee(Employees employee)
        {
            SqlCommand command = new SqlCommand("spUpdateemployee ", Connection);
            command.CommandType = CommandType.StoredProcedure;
           

            command.Parameters.AddWithValue("@FirstName", employee.FirstName);
            command.Parameters.AddWithValue("@LastName", employee.LastName);
            command.Parameters.AddWithValue("@email", employee.Email);
            command.Parameters.AddWithValue("@password", employee.Password);
            command.Parameters.AddWithValue("@Mobile", employee.Mobile);

            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();

            Console.WriteLine("Upadated");
        }   
        public IEnumerable<Employees> GetAllEmployee()
        {

            List<Employees> employees = new List<Employees>();

            SqlCommand command = new SqlCommand("spGetAllemployee", Connection);
            command.CommandType = CommandType.StoredProcedure;
            Connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Employees employee = new Employees();
                employee.FirstName = dataReader["FirstName"].ToString();
                employee.LastName = dataReader["LastName"].ToString();
                employee.Email = dataReader["Email"].ToString();
                employee.Password = dataReader["PassWord"].ToString();
                employee.Mobile = dataReader["Mobile"].ToString();
                employees.Add(employee);

            }
            Connection.Close();

            return employees;
        }

        public void DeleteEmployee(int userId)
        {
            SqlCommand cmd = new SqlCommand("spDeleteEmployee", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", userId);

           Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public bool LoginEmployee(string email, string password)
        {
            SqlCommand cmd = new SqlCommand("spGetAllemployee", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                Connection.Open();
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    if (Equals(data["PassWord"].ToString(),password))
                    {
                        if (Equals(data["Email"].ToString(), email))
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

