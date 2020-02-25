// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=Controller.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeManagement.Repository
{
    /// <summary>
    /// Purpose:use interface Repository
    /// </summary>
    public class EmployeeRep :IUserRepository
    {
        /// <summary>
        ///  purpose:Sqlcoonection using connecting the database.
        /// </summary>
        public SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Fundoo;Integrated Security=True");
        /// <summary>
        /// Purpose:Add the employee.
        /// </summary>
        /// <param name="employee"></param>
        public void AddEmployee(Employees employee)
        {
            ///// Sqlcommand used for get the database query.
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
        /// <summary>
        /// Purpose:Update the employee
        /// </summary>
        /// <param name="employee"></param>
        public void UpdateEmployee(Employees employee)
        {
            /////Sqlcommand used for get the database query.
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
        /// <summary>
        ///     Purpose:User to get the all employee.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employees> GetAllEmployee()
        {
            ////Sqlcommand used for get the database query.
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
        /// <summary>
        /// Purpose:Delete the employee.
        /// </summary>
        /// <param name="userId"></param>
        public void DeleteEmployee(int userId)
        {
            ////Sqlcommand used for get the database query.
            SqlCommand cmd = new SqlCommand("spDeleteEmployee", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", userId);
           Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        /// <summary>
        /// purpose:employee used for login purpose.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool LoginEmployee(string email, string password)
        {
            ////Sqlcommand used for get the database query.
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

