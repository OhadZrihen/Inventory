using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryEntities
{
    public class Production
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Place { get; set; }
        public string? Description { get; set; }
        public DateTime? DateOut { get; set; }
        public DateTime? DaTeIN { get; set; }
        public int? EmployeeId { get; set; }

    }
    public class ProductionItemsList
    {
        List<Item> Items;
        public int ? EmployeeId { get; set; }
        public int ? ProductionId { get; set; }
        public void add(Item item)
        {
            Items.Add(item);    
        }
        public void Remove(Item item)
        {
            if(Items.Contains(item))
                Items.Remove(item);
        }


    }
}
