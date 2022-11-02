using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dog:Animal
    {
        public override void GetVoice()
        {
            Console.WriteLine("Гав");
        }
    }
}
