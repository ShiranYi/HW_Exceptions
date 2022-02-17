using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions
{
    internal class Garage : IGarage
    {
        private int counter;
        public Car[] Cars { get; set; }
        public string[] CarTypes { get; set; }

        public Garage(string[] carTypes)
        {
            CarTypes = carTypes;
            Cars = new Car[10];
        }

        public void AddCar(Car c)
        {
            if (c == null)
                throw new CarNullException("Car Null");
            if (!CarTypes.Contains(c.Brand))
                throw new WrongGarageException("Wrong Garage");
            if (Cars.Contains(c))
                throw new CarAlreadyHereException("Car Already Here");
            if (c.TotalLost)
                throw new WeDoNotFixTotalLostException("We Do Not Fix Total Lost");
            if (!c.NeedsRepair)
                throw new RepairMismatchException("Repair Mismatch");
            Cars[counter++] = c;
        }

        public void FixCar(Car c)
        {
            if (c == null)
                throw new CarNullException("Car Null");
            if (!c.NeedsRepair)
                throw new RepairMismatchException("Repair Mismatch");
            if (!Cars.Contains(c))
                throw new CarNotInGarageException("Car Not In Garage");
            c.NeedsRepair = false;

        }

        public void TakeOutCar(Car c)
        {
            if (c == null)
                throw new CarNullException("Car Null");
            if (c.NeedsRepair)
                throw new CarNotReadyException("Car Not Ready");
            if (!Cars.Contains(c))
                throw new CarNotInGarageException("Car Not In Garage");
            int index = Array.IndexOf(CarTypes, c);
            Cars[index] = null;
            for (int i = index; i < Cars.Length - 1; i++)
            {
                Cars[i] = Cars[i + 1];
                Cars[i + 1] = null;
            }
            counter--;
        }
    }
}
