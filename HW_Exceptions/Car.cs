using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions
{
    internal class Car
    {
        public string Brand { get; set; }
        public bool TotalLost { get; set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totalLost, bool needsRepair)
        {
            Brand = brand;
            TotalLost = totalLost;
            NeedsRepair = needsRepair;
            if (totalLost && !needsRepair)
                throw new RepairMismatchException("Repair Mismatch");
        }
    }

}
