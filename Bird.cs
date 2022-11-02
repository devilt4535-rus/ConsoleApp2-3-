using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bird : Animal
    {
            public void Fly()
            {
                Console.WriteLine("Летит");
            }
        public override void GetVoice()
        {
            Console.WriteLine("Чирикает");
        }
    }
}