using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    /// <summary>
    /// Exercise 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Uses ordered generic dynamic array
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            OrderedDynamicArray<int> orderedDynamicArray = new OrderedDynamicArray<int>();

            Prostokat prostokat1 = new Prostokat(3, 4); //12
            Prostokat prostokat2 = new Prostokat(5, 2); //10
            Prostokat prostokat3 = new Prostokat(1, 11); //11

            OrderedDynamicArray<Prostokat> tablicaProstokatow = new OrderedDynamicArray<Prostokat>();
            //Console.WriteLine(prostokat1.CompareTo(null));
            //Console.WriteLine(prostokat1.CompareTo(prostokat2)); 
            //Console.WriteLine(prostokat1.CompareTo(prostokat3));
            tablicaProstokatow.Add(prostokat1);
            tablicaProstokatow.Add(prostokat2);
            tablicaProstokatow.Add(prostokat3);

            Console.WriteLine(tablicaProstokatow);

            Console.WriteLine(orderedDynamicArray);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
