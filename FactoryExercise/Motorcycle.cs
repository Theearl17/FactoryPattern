﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise
{
    internal class Motorcycle : IVehicle
    {
        // Members //
        public Motorcycle() 
        { 
        
        }

        public void Drive()
        {
            Console.WriteLine(" The Motorcycle is revving up!");
            Console.WriteLine("wom-wom-wom-wom!");
        }
    }
}
