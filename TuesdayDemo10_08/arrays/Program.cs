using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring 
            int[] myArray = new int[5];
            //intitializing 
            for(int i=0; i<myArray.Length; i++)
            {
                myArray[i] = i + 10;
            }

            // treversing
            Console.WriteLine("print array elements");
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }
    }
}
