using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests LastIndexOf and AllIndexesOf methods
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // build test dynamic array
            UnorderedIntDynamicArray unorderedIntDynamicArray = new UnorderedIntDynamicArray();
            unorderedIntDynamicArray.Add(1);
            unorderedIntDynamicArray.Add(2);
            unorderedIntDynamicArray.Add(3);
            unorderedIntDynamicArray.Add(2);
            unorderedIntDynamicArray.Add(10);
            //unorderedIntDynamicArray.Remove(2);

            Console.WriteLine(unorderedIntDynamicArray);

            // test LastIndexOf with one item in dynamic array
            Console.WriteLine(unorderedIntDynamicArray.LastIndexOf(3));

            // test LastIndexOf with multiple items in the dynamic array
            Console.WriteLine(unorderedIntDynamicArray.LastIndexOf(2));

            // test LastIndexOf with item not in dynamic array
            Console.WriteLine(unorderedIntDynamicArray.LastIndexOf(4));
            // test AllIndexesOf with one item in dynamic array
            Console.WriteLine(unorderedIntDynamicArray.AllIndexesOf(2));

            // test AllIndexesOf with multiple items in dynamic array


            // test AllIndexesOf with item not in dynamic array


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
