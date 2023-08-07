using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDetalis.Business;
using EmployeeDetalis.Model;
using EmployeeDetalis.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        public EmployeeDetailsBusiness obj;

        public EmployeeDetailsController()
        {
            obj = new EmployeeDetailsBusiness();
        }

        [HttpGet]
        public IEnumerable<EmployeeDetailsModel> Get()
        {
            return obj.ReadEmployeeDetails();
        }

        [HttpGet("{id}")]
        public EmployeeDetailsModel Get(int id)
        {
            return obj.ReadEmployeeDetails(id); 
        }

   
        [HttpPost]
        public void Post([FromBody] EmployeeDetailsModel value)
        {

            obj.InsertEmployeeDetails(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EmployeeDetailsModel value)
        {
            value.ID = id;
            obj.PutEmployeeDetails(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            obj.DeleteEmployeeDetails(id);
        }

    }
}
