using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type A

            //Ex.Checking Entered Number 

            //Console.Write("Enter a Number : ");
            //int Num = int.Parse(Console.ReadLine());
            //int Divisors = 0;

            //for (int i = 1; i <= Num; i++)
            //{
            //    if (Num % i == 0)
            //    {
            //        Divisors++;
            //    }
            //}
            //if (Divisors == 2)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($" => {Num} Is A Prime Number");
            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($" => {Num} Isn't A Prime Number");
            //}


            //Type B

            //Ex.Another Method For Checking Entered Number 

            //Console.Write("Enter a Number : ");
            //int Num = int.Parse(Console.ReadLine());
            //bool Prime = true;

            //for (int i = 2; i <= Num / 2; i++)
            //{
            //    if (Num % i == 0)
            //    {
            //        Prime = false;
            //        break;
            //    }
            //}
            //if (Prime)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($" => {Num} Is A Prime Number");
            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($" => {Num} Isn't A Prime Number");
            //}


            //Type C

            //Ex.Prime Numbers Between 1 and 100 

            //Console.WriteLine("Prime Numbers Between 1 and 100 : ");
            //bool Prime = true;

            //for (int i = 2; i <= 100; i++)
            //{
            //    for (int l = 2; l <= 100; l++)
            //    {
            //        if (i != l && i % l == 0)
            //        {
            //            Prime = false;
            //            break;
            //        }
            //    }
            //    if (Prime)
            //    {
            //        //Console.Write(i + " ");
            //        Console.Write("\t" + i);
            //    }
            //    Prime = true;
            //}


            //Type D

            //Ex.Prime Numbers Between XX and XX

            Console.Write("Enter The Start Number: ");
            int StartNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the End Number : ");
            int EndNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"The Prime Numbers Between {StartNumber} and {EndNumber} are : \n ");

            for (int i = StartNumber; i <= EndNumber; i++)
            {
                int Divisors = 0;
                for (int l = 2; l <= i / 2; l++)
                {
                    if (i % l == 0)
                    {
                        Divisors++;
                        break;
                    }
                }

                if (Divisors == 0 && i != 1)
                {
                    //Console.Write(i + " ");
                    Console.Write(" {0} \t ", i);
                }
            }

            Console.ReadKey();
        }
    }
}
