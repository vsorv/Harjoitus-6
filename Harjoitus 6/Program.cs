using Harjoitus_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance 
{
    internal class Program
    {

        static void Main(string[] args)
        { // Species, Size, Danger, CanSwim.
            Animal animal = new Animal("Dog", "Medium", "Low-High", "Yes");
            animal.PrintInformation();
        }
    }
}