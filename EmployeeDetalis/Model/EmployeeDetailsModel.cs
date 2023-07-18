using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Data.SqlClient;

namespace EmployeeDetalis.Model

{
   public class EmployeeDetailsModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public long phonenumber { get; set; }
        public DateTime DOB { get; set; }
    }
}
