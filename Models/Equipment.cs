using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ostad_assignment_1.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string TotalNo { get; set; } 
    }

    public class EquipmentHelper 
    {
        public EquipmentHelper() 
        { 
        }

        public static List<Equipment> AllEquipmentList()
        {
            var equiplist = new List<Equipment>();
            Random randm = new Random();
            var minVal = 10;

            for (int i = 0; i <= 20; i++)
            { 
                Equipment equipment = new Equipment();
                equipment.EquipmentId = i+1;
                equipment.EquipmentName = "Equipment_"+ i.ToString();
                equipment.TotalNo = randm.Next(minVal+i).ToString("D2"); 
                
                equiplist.Add(equipment);
            }
            return equiplist;
        }
    }

}