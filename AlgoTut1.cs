using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace AlgoTut
{
    class AlgoTut1
    {
        public void ArrayTest()
        {
            int[] array = new int[] { 1, 2, 3 };
            printArray1(array);
            array[1] = 10;
            printArray1(array);
            try
            {
                array[3] = 10;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            int[,] theArray = { { 1, 2 }, { 2, 3 }, { 3, 4 } };
            Console.WriteLine($"A multi-dimensional array length:{theArray.Length}");
            int[][] b = {
               new int[]{1,2,3},
               new int[]{4,12,1,6,3,2},
               new int[]{7,9,1,4},
           };
            Console.WriteLine($"The Jagged array lenght: {b.Length}");
            Console.WriteLine($"The nested array lenght: {b[1].Length}");

            //a[0, 0] = 10;
            b[0][0] = 10;
            printArray2(theArray);
            printArray2(b);
            UniqueInOrder("AAAABBBCCcDAABBB");
            //UniqueInOrder(43234);// == ['A', 'B', 'C', 'D', 'A', 'B']
            // UniqueInOrder("ABBCcAD");   //      == ['A', 'B', 'C', 'c', 'A', 'D']

            UniqueInOrder(new string[] { "A", "B", "B", "C", "c", "A", "D" });
            UniqueInOrder(new string[] { "A", "A", "A", "A", "B", "B", "B", "C", "C", "D", "A", "A", "B", "B", "B" });
            UniqueInOrder(new int[] { 1, 2, 2, 3, 3 }); //      == [1,2,3]
        }
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> strings = new List<T>();
            Console.WriteLine(iterable.Count());
            //iterable = iterable.Distinct();
            strings.Add(iterable.FirstOrDefault());
                    Console.Write(" " + iterable.FirstOrDefault());
            foreach (var item in iterable)
            {
                if (!item.Equals(strings.Last()))
                {
                    strings.Add(item);
                    Console.Write(" " + item);
                }
            }
            Console.WriteLine("");
            return strings;
        }
        void printArray1(int[] toBePrinted)
        {
            int len = toBePrinted.Length;
            Console.WriteLine(" ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(toBePrinted[i] + " ");
            }
            Console.WriteLine(" ");
        }
        void printArray2(int[,] toBePrinted)
        {
            int len = toBePrinted.Length;

            var query = from item in toBePrinted.Cast<int>()
                        select item;
            Console.WriteLine(" ");
            foreach (var item in query)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
        }
        void printArray2(int[][] toBePrinted)
        {
            var query = from item in toBePrinted.Cast<int[]>()
                        select item;
            Console.WriteLine(" ");
            foreach (var item in query)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(1 * Int32.Parse("2"));
        }
    }
}