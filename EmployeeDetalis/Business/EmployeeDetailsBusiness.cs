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

        public void InsertEmployeeDetails(EmployeeDetailsModel emp)
        {
           
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"   exec EmployeeDetailsinsert '{emp.Name}', '{emp.address}',{emp.age},{emp.phonenumber},'{emp.DOB}'");

                con.Close();

            }
            catch (SqlException ex)
            {
                throw ;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public EmployeeDetailsModel ReadEmployeeDetails(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                var connection = new SqlConnection(connectionString);
                con.Open();
                var Employee = connection.QueryFirst <EmployeeDetailsModel>($" exec listEmployeeDetails {id} ");
                con.Close();



                return Employee;


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

        public List<EmployeeDetailsModel> ReadEmployeeDetails()
        {
            try
            {
                List<EmployeeDetailsModel> constrain = new List<EmployeeDetailsModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<EmployeeDetailsModel>(" select * from EmployeeDetails ").ToList();
                connection.Close();
                
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

        public void PutEmployeeDetails(EmployeeDetailsModel emp)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" exec EmployeeDetailsUpdate '{emp.Name}',{emp.address},{emp.age},{emp.phonenumber},'{emp.DOB.ToString("MM-dd-yyyy")}',{emp.ID}");
                con.Close();
            }
            catch (SqlException eu)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DeleteEmployeeDetails(int id)
        {
            try
            {


                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"  exec EmployeeDetailsDelete { id}");

                con.Close();

            }
            catch (SqlException ed)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
