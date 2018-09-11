using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            DataProcessor Data = new DataProcessor();
            DefaultSorter SortArrayByDefault = new DefaultSorter();
            int[] arrayOfNumbers = { 10, 44, 1, 5, 8, 11, 0, 76 };
            Console.WriteLine("Array before sorting");
            Data.Print(arrayOfNumbers);
            Console.WriteLine("Sorted array");
            Data.Print(SortArrayByDefault.Sort(arrayOfNumbers));
            Console.ReadLine();
        }
 
        public class DataProcessor /*: IDataSorter*/
        {       
            public void Print(int[] arrayToPrint)
            {
                //Print positions using for
                for (int count = 0; count < arrayToPrint.Length; count++)
                {
                    Console.Write("{0,4}",count);
                }
                //next line
                Console.WriteLine();
                //Print a line using while
                int  counter = 0;
                while (counter < arrayToPrint.Length*4)
                {
                    Console.Write("-");
                    counter++;
                }
                //next line
                Console.WriteLine();
                //print array using foreach
                foreach (int dataValue in arrayToPrint)
                {                
                    Console.Write("{0,4}", dataValue);
                }
                Console.WriteLine();
                //Print a line using do while
                //init the countert
                counter = arrayToPrint.Length * 4;
                do
                {
                    Console.Write("=");
                    counter--;
                }
                while (counter != 0); //do it till counter is not nul
                //next line
                Console.WriteLine();
            }
 
        }
    }      
}
