using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise
{
    internal class ThreeWheeler : IVehicle
    {
    public ThreeWheeler() 
        { 
        }
    public void Drive () 
        {
            Console.WriteLine(" Let's beat the traffic!");
        }
    
    }
}
