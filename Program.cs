using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace cSharp_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ex 1
            float sum = 0;
            float average = 0;
            int isEven = 0;
            int isOdd = 0;

            //ArrayType 'int'[] ArrayName 'a' = new [ArraySize]
            int[] a = { 1, 5, 7, 9, 10, 1 };
            int first = a[0], second = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i]; //To sum numbers in side the array
                Console.WriteLine();
                if (a[i] % 2 == 0)
                {
                    isEven++;
                }
                else
                {
                    isOdd++;
                }

                if (a[i] > first)  //Second largers number
                {
                    second = first;
                    first = a[i];
                }
                else if (a[i] > second && a[i] != first)
                {
                    second = a[i];
                }
                int[] unique = a.Distinct().ToArray();

            }
            average = (sum / a.Length);
            Console.WriteLine("The total of the array: " + sum);
            Console.WriteLine("The average of the array is: " + average);
            Console.WriteLine("Smallest element: " + a.Min());
            Console.WriteLine("Smallest element: " + a.Max());
            Console.WriteLine("Number of even: " + isEven);
            Console.WriteLine("Number of odd: " + isOdd);
            Console.WriteLine("Second largest element is: " + second);

                
         




            //Console.Writeline("");

            //Console.Write("\n Sort elements of array in ascending order: ");



        }
    }

}
