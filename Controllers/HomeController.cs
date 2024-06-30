using ostad_assignment_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ostad_assignment_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var empList = Employe.TotalEmployeeCount();
            var equipmentList=EquipmentHelper.AllEquipmentList();

            List<DeviceAssignModel> DivAssigndModel =new List<DeviceAssignModel>();

            foreach (var emp in empList) 
            {
                DeviceAssignModel devModel = new DeviceAssignModel { 
                    EmpId=emp.EmployeeId,
                    EmpName=emp.EmployeeName,
                    EmpDesignation=emp.EmpDesignation,
                    EquipmentAssigned= "Equipment_" + emp.EmployeeId.ToString(),
                    //Equip.EquipmentName=
                };
                DivAssigndModel.Add(devModel);

            }
            return View(DivAssigndModel);
        }

       
    }
}