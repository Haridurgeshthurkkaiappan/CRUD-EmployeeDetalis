using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

using EmployeeDetalis.Model;
using EmployeeDetalis.Repository;

namespace EmployeeDetalis.Business
{
   public class EmployeeDetailsBusiness
    {
        public readonly string connectionString;



        public EmployeeDetailsBusiness()
        {
            connectionString = @"Data source=DESKTOP-UCPA9BN;Initial catalog=EmployeeDetails;User Id=sa;Password=Anaiyaan@123";
        }

        public void InsertSP(EmployeeDetailsModel emp)
        {
           
            try
            {



                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"   exec EmployeeDetailsinsert '{emp.Name}', '{emp.address}',{emp.age},{emp.phonenumber},'{emp.DOB}'");

                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<EmployeeDetailsModel> Read()
        {
            try
            {
                List<EmployeeDetailsModel> constrain = new List<EmployeeDetailsModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<EmployeeDetailsModel>("exec listEmployeeDetails").ToList();
                connection.Close();
                foreach (var cons in constrain)
                {


                    Console.WriteLine($"ID-->{cons.ID}\tName-->{cons.Name}\tAddress-->{cons.address}\tAGE-->{cons.age}\tPHONENUMBER-->{cons.phonenumber}\tDOB-->{cons.DOB}");
                }

                return constrain;


            }

            catch (SqlException er)
            {
                throw;
            }
            catch (Exception r)
            {
                throw r;
            }
        }

    }
}
