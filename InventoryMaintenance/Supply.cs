using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Supply : InvItem
    {
        public string Manufacturer { get; set; }

        // Nadia Cowins
        public Supply() { }

        // Nadia Cowins
        public Supply(int itemNo, string description, decimal price, string manufacturer) : base(itemNo, description, price)
        {
            Manufacturer = manufacturer;
        }

        // Nadia Cowins
        public override string GetDisplayText()
        {
            return $"{ItemNo}    {Manufacturer} {Description} ({Price:c})";
        }   
    }
}
