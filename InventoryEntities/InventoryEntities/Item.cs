using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryEntities
{
    public abstract class Item
    {
        public int Id {  get; set; }
        public string? Name { get; set; }
        public string? Family { get; set; }
        public string? Category { get; set; }
        public int ProductionId { get; set; }
        public int EmployeeId { get; set; }
        public bool IsActive = true;
        public DateTime Out { get; set; }
        public DateTime IN { get; set; }
        
    }
    public class SimpleItem : Item
    {
        public string? Model { get; set; }
    }
    public class GroupItems : Item
    {
        public List<Item> Group { get; set; }
        public void Add(Item item)
        {
            Group.Add(item);
        }
        public void Remove(Item item)
        {
            if (Group.Contains(item))
                Group.Remove(item);
        }
    }

    public class Family
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items = new List<Item>();
        public void Add(Item item)
        {
            Items.Add(item);
        }
        public void remove(Item item)
        {
            if (Items.Contains(item))
                Items.Remove(item);
        }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Family> Families = new List<Family>();
        public void Add(Family family)
        {
            Families.Add(family);
        }
        public void remove(Family family)
        {
            if (Families.Contains(family))
                Families.Remove(family);
        }
    }
}
