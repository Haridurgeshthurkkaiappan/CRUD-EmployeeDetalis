using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

using EmployeeDetalis.Model;
using EmployeeDetalis.Business;

namespace EmployeeDetalis.Repository
{
   public class EmployeeDetailsMenu
    {
       



            public EmployeeDetailsModel Employeeregisterinfo()
            {
                EmployeeDetailsModel emp = new EmployeeDetailsModel();

                Console.WriteLine("Enter NAME");
                emp.Name = Console.ReadLine();
                Console.WriteLine("Enter ADDRESS ");
                emp.address = Console.ReadLine();
                Console.WriteLine("Enter  AGE ");
                emp.age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter PHONENUMBER ");
                emp.phonenumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter DOB ");
                emp.DOB = Convert.ToDateTime(Console.ReadLine());

                return emp;
            }

            public void doit()
            {




                int a = 0;
                do
                {
                    Console.WriteLine("choose the option");
                    Console.WriteLine("0.exit");
                    Console.WriteLine("1.LIST");
                    Console.WriteLine("2.INSERT");


                    Console.WriteLine("enter the option");
                    a = Convert.ToInt32(Console.ReadLine());

                 EmployeeDetailsMenu obj1 = new EmployeeDetailsMenu();
                EmployeeDetailsBusiness obj = new EmployeeDetailsBusiness();

                    switch (a)
                    {
                        case 0:
                            Console.WriteLine("exiting");
                            break;
                        case 1:
                            obj.Read();
                            break;

                        case 2:
                            var detail = obj1.Employeeregisterinfo();
                            obj.InsertSP(detail);
                            break;

                        default:
                            Console.WriteLine("you entered the invalid option");
                            break;



                    }
                } while (a != 0);


            }
        }
    }

