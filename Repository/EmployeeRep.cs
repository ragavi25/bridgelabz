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
       /* private  UserContext context;
        private readonly IConfiguration iconfiguration; 
        public EmployeeRep(UserContext userContext,IConfiguration configuration)
        {
            this.context = userContext;
            this.iconfiguration = configuration;
        }
        public EmployeeRep(UserContext context)
        {
            this.context = context;
            if (context.employees.Count()== 0)
            {
                context.employees.AddRange(
                    new Employees
                    {
                        Id = 1,
                        FirstName = "Ragavi",
                        LastName = "Rajendran",
                        Email = "raghavimr@gmail.com",
                        UserName = "RAGAVI",
                        Password = "214235",
                        Mobile = "232576854",
                        Address = "DSGDSFJHNSGFSFH"
                    },
                    new Employees
                    {
                        Id = 2,
                        FirstName = "RAMYA",
                        LastName = "VANCHI",
                        Email = "ramya@gmail.com",
                        UserName = "ramya",
                        Password = "w54dfg",
                        Mobile = "3255638",
                        Address = "FBGFH"
                    }
                    );
                context.SaveChanges();
            }
        }

        public Employees Employees { get; private set; }

       // public IEnumerable<Employees> GetEmployees()
       // {
         //   return context.employees.ToList();
        //}
        public bool TryGetEmployee(int id,out Employees employees)
        {
            employees = context.employees.Find(id);
            return (employees != null);
           
        }
        public async Task<int> AddEmployeeAsync(Employees employees)
        {
            int rowAffected = 0;
            context.employees.Add(Employees);
            rowAffected = await context.SaveChangesAsync();
            return rowAffected;
        }*/
        public SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Database=EmployeeManagements;IntegratedSecurity=true");
        public IEnumerable<Employees> GetEmployees()
        {
            List<Employees> employees = new List<Employees>();

            SqlCommand command = new SqlCommand("spGetAllEmployee ", Connection);
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
                employee.Mobile = dataReader["Moblie"].ToString();
                employee.Address = dataReader["Address"].ToString();
                employees.Add(employee);

            }
            Connection.Close();

            return employees;
        }
        public void AddEmployee(Employees employee)
        {

            SqlCommand command = new SqlCommand("spAddEmployee ", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", employee.Id);
            command.Parameters.AddWithValue("@FirstName", employee.FirstName);
            command.Parameters.AddWithValue("@LastName", employee.LastName);
            command.Parameters.AddWithValue("@Email", employee.Email);
            command.Parameters.AddWithValue("@UserName", employee.UserName);
            command.Parameters.AddWithValue("@PassWord", employee.Password);
            command.Parameters.AddWithValue("@Mobile", employee.Mobile);
            command.Parameters.AddWithValue("@Address", employee.Address);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public void UpdateEmployee(Employees employee)
        {
            SqlCommand command = new SqlCommand("spUpdateEmployee ", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", employee.Id);
            command.Parameters.AddWithValue("@FirstName", employee.FirstName);
            command.Parameters.AddWithValue("@LastName", employee.LastName);
            command.Parameters.AddWithValue("@Email", employee.Email);
            command.Parameters.AddWithValue("@UserName", employee.UserName);
            command.Parameters.AddWithValue("@PassWord", employee.Password);
            command.Parameters.AddWithValue("@Mobile", employee.Mobile);
            command.Parameters.AddWithValue("@Address", employee.Address);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public Employees GetEmployeeData(int id)
        {
            
            Employees employee = new Employees();
            SqlCommand command = new SqlCommand("SELECT * FROM EmployeeModel WHERE ID=" + id, Connection);
            Connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                employee.Id = Convert.ToInt32(dataReader["Id"]);
                employee.FirstName = dataReader["FirstName"].ToString();
                employee.LastName = dataReader["LastName"].ToString();
                employee.Email = dataReader["Email"].ToString();
                employee.UserName = dataReader["UserName"].ToString();
                employee.Password = dataReader["PassWord"].ToString();
                employee.Mobile = dataReader["Moblie"].ToString();
                employee.Address = dataReader["Address"].ToString();
            }
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            SqlCommand command = new SqlCommand("spDeleteEmployee ", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public bool Login(Employees employees)
        {
            throw new NotImplementedException();
        }
    }
    }

