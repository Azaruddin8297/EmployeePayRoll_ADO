using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayroll
{
    public class EmployeeRepo
    {
        public static string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PayrollService;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionstring);

        public bool AddEmployee(EmpModel Model)
        {
            try
            {
                using (this.connection)
                {
                    string sql = "INSERT INTO EmployeeDetail(EmployeeName ,PhoneNumber, Address, Department,Gender) values " +
                        "(@EmployeeName ,@PhoneNumber, @Address, @Department,@Gender)";
                    SqlCommand command = new SqlCommand(sql, this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", Model.EmployeeName);
                    command.Parameters.AddWithValue("@PhoneNumber", Model.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", Model.Address);
                    command.Parameters.AddWithValue("@Department", Model.Department);
                    command.Parameters.AddWithValue("@Gender", Model.Gender);
                    command.Parameters.AddWithValue("@BasicPay", Model.BasicPay);
                    command.Parameters.AddWithValue("@Deductions", Model.Deductions);
                    command.Parameters.AddWithValue("@TexablePay", Model.TexablePay);
                    command.Parameters.AddWithValue("@Tax", Model.Tax);
                    command.Parameters.AddWithValue("@NetPay", Model.NetPay);
                    command.Parameters.AddWithValue("@StartDate", DateTime.Now);
                    command.Parameters.AddWithValue("@City", Model.City);
                    command.Parameters.AddWithValue("@Country", Model.Country);

                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }   
                    return false;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { this.connection.Close(); }
            return false;
        }
    }
}
