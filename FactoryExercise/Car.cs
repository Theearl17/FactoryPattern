using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise
{
    public class Car : IVehicle
    {
        public string Name { get; set; }
        public int MilesPerHour { get; set; }
        public int Doors{ get; set; }
       

        public void Drive()
        {
            Console.WriteLine("The car is driving slow in the fast lane, typical!");
        }
    }
}
