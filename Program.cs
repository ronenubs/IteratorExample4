using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo theZoo = new Zoo();
            
            theZoo.AddMammal("Whale");
            theZoo.AddMammal("Carabao");

            theZoo.AddBird("Penguin");
            theZoo.AddBird("Eagle");

            //foreach(string name in theZoo)
            //{
            //    Console.Write(name + " ");
            //}

            //Console.WriteLine();

            foreach(string name in theZoo.Birds)
            {
                Console.Write(name + " ");
            }

            Console.ReadLine();
        }
    }
}
