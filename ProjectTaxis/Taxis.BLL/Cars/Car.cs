using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxis.BLL.Enums;

namespace ProjectTaxis
{
  abstract public class Car
    {
        public string Name { get; set; }
        public double Price { get; private set; }
        public DateTime ReleaseYear { get; set; }
        public EngineType EngineType { get; set; }
        public int MaxSpeed { get; set; }
        public int Consumption { get; set; }

    }
}
