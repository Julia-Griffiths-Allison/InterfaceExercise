using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string Motor { get; set; }
        public string Wheels { get; set; }
        public string Windows { get; set; }
        public string Radio { get; set; }
    }
}
