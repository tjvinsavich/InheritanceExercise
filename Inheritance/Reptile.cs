using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public string ScaleColors { get; set; }
        public double TailLength { get; set; }
        public bool IsSunBathing { get; set; }

        public void slitherAbout()
        {
            Console.WriteLine("OOoo, there goes that slithery, scurrily guy!");
        }


    }
}
