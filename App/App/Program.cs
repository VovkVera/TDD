using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalcLib;
//Simple example for Harvard students at course Computer Science

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the other side");
            Calculator.Add(2,3);
            Console.ReadKey();
        }
    }

    class Calculator
    {
        public static void Add(int x, int y)
        {
            
            MyCalc c = new MyCalc();
            int z = c.Sum(x, y); //metod Sum Covered by unit Test
            Console.WriteLine($" Sum {x} and {y} is {z}");//string interpolation
        }
    }
}
