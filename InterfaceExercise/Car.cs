using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string Hatchback { get; set; }
        public string InteriorSize { get; set; }
        public string Slogan { get; set; }
        public string Name { get; set; }
        public string Motor { get; set; }
        public string Wheels { get; set; }
        public string Windows { get; set; }
        public string Radio { get; set; }
    }
}
