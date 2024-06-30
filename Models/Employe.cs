using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ostad_assignment_1.Models
{
    public class Employe
    {

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmpDesignation { get; set; }


        public static List<Employe> TotalEmployeeCount()
        {
            List<Employe> result = new List<Employe>();

            for (int i = 0; i < 9; i++)
            {
                Employe emp = new Employe();
                emp.EmployeeId =  i;
                emp.EmployeeName = "Name_" + emp.EmployeeId.ToString();
                emp.EmpDesignation = "Executive_" + emp.EmployeeId;

                result.Add(emp);
            }

            return result;
        }

    }
}