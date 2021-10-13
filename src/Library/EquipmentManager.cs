using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public static class EquipmentManager
    {
        private static List<Equipment> equipmentCatalog = new List<Equipment>();

        public static void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            equipmentCatalog.Add(new Equipment(description, hourlyCost));
        }
        
        public static Equipment EquipmentAt(int index)
        {
            return equipmentCatalog[index] as Equipment;
        }

        public static Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }
    }
}