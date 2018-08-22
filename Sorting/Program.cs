using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            DataProcessor Data = new DataProcessor();
            int[] arrayOfNumbers = { 10, 44, 1, 5, 8, 11, 0, 76 };
            Data.Print(arrayOfNumbers);
            Console.ReadLine();
        }
        //interface definition
        interface IDataSortable
            {
            // interface members
            // Read data from console
            void Read();
            // Sort the data
            int[] Sort(int[] arrayToSort);
            // Print results to the console
            void Print(int[] arrayToPrint);
            }
        //realizing the interface
        public class DataProcessor : IDataSortable
        {

            //ublic void Print(T[] printingArray)
            //{
            //    foreach (T value in printingArray)
            //    {
            //        Console.Write(" {0}", value);
            //    }
            //    Console.WriteLine("\n");
            //}

            //public abstract T[] Sort(T[] sortingArray);
            public void Print(int[] arrayToPrint)
            {
                foreach (int dataValue in arrayToPrint)
                {
                    Console.Write(": {0}", dataValue);
                }
                Console.WriteLine("\n");
                //throw new NotImplementedException();
            }

            public void Read()
            {
                throw new NotImplementedException();
            }

            public int[] Sort(int[] arrayToSort)
            {
                throw new NotImplementedException();
            }
        }
    }      
}
