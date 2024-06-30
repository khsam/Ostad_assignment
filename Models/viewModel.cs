using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ostad_assignment_1.Models
{
    public class viewModel
    {
    }

    public class DeviceAssignModel {

        public DeviceAssignModel()
        {
            Equip = new Equipment();
        }

        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public string EquipmentAssigned { get; set; }
        public Equipment Equip { get; set; }
    }
}