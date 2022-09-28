using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public string SoccerMomCar {get; set;  }
        public string ThirdRow { get; set; }
        public string Slogan { get; set; }
        public string Name { get; set; }
        public string Motor { get; set; }
        public string Wheels { get; set; }
        public string Windows { get; set; }
        public string Radio { get; set; }
    }
}
