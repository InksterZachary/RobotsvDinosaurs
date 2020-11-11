using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs_Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battleOne = new Battlefield();
            battleOne.Run();
            Console.ReadLine();
        }
    }
}
