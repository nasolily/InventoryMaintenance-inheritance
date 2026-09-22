using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // The colon indicates inheritance; Plant class inherits all properties and methods from InvItem class and can add its own properties and behaviors
    public class Plant : InvItem
    {
        // Nadia Cowins - default constructor
        public string Size { get; set; }

        // Nadia Cowins - parameter constructor
        public Plant() : base() { }

        public Plant(
            int itemNo, string description, decimal price, string size) : base(itemNo, description, price)
        {
            Size = size;
        }

        // Nadia Cowins
        public override string GetDisplayText()
        {
            return $"{ItemNo}    {Size} {Description} ({Price:c})";
        }

    }
}
