using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class EquipmentCatalog
    {
        private static List<Equipment> catalog = new List<Equipment>();
        public EquipmentCatalog()
        {
            catalog = new List<Equipment>();
        }

        public List<Equipment> Catalog {get;}

        public void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            Catalog.Add(new Equipment(description, hourlyCost));
        }

        public Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in Catalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }
        public Equipment EquipmentAt(int index)
        {
            return Catalog[index] as Equipment;
        }
    }
}