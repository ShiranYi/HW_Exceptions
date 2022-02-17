using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions
{
    internal interface IGarage
    {
        public void AddCar(Car c);
        public void TakeOutCar(Car c);
        public void FixCar(Car c);
    }
}
