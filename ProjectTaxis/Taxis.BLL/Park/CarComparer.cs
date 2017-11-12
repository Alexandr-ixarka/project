using ProjectTaxis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis.BLL
{
    public class CarComparer : EqualityComparer<Car>
    {

        public override bool Equals(Car b1, Car b2)
        {
            return b1.Name == b2.Name;
        }


        public override int GetHashCode(Car car)
        {
            return car.Name.GetHashCode();
        }
    }
}
