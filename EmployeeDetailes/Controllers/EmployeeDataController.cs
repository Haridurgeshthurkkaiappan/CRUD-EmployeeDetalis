using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDetalis.Model;
using EmployeeDetalis.Business;
using EmployeeDetalis.Repository;


namespace EmployeeDetailes.Controllers
{
    public class EmployeeDataController : Controller
    {
        public EmployeeDetailsBusiness obj;

        public EmployeeDataController()
        {
            obj = new EmployeeDetailsBusiness();
        }

        // GET: EmployeeDataController
        public ActionResult List()
        {
            return View("EmployeeList",new List<EmployeeDetailsModel>(obj.ReadEmployeeDetails()) );
        }

        // GET: EmployeeDataController/Details/5
        public ActionResult Details(int id)
        {
            var result = obj.ReadEmployeeDetails(id);

            return View("EmployeeDetails", result);
        }

        // GET: EmployeeDataController/Create
        public ActionResult Create()
        {
            return View("CreateEmployee",new EmployeeDetailsModel() );
        }

        // POST: EmployeeDataController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeDetailsModel Data)
        {
            try
            {
                obj.InsertEmployeeDetails(Data);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeDataController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = obj.ReadEmployeeDetails(id);
            return View("EditEmployeeData", result);
        }

        // POST: EmployeeDataController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeDetailsModel Data)
        {
            try
            {
                int ID = id;
                obj.PutEmployeeDetails(Data);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeDataController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = obj.ReadEmployeeDetails(id);

            return View("DeleteEmployeeData", result);
        }

        // POST: EmployeeDataController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int id)
        {
            try
            {
            
                obj.DeleteEmployeeDetails(id);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
