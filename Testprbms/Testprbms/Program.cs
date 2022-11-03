using System;

namespace Testprbms
{
   

   
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("entre a no:");
                int n = int.Parse(Console.ReadLine());
                Factor(n);
                Factorial(n);
                reverseno(n);
                PrimeOrNot(n);
                Fibonacic(n);
                Pallindrom(n);


            }

            //Factor of no

            public static void Factor(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            //Factorial of Given no
            public static void Factorial(int n)//3
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine($"Factorial of {n} is {fact}");
            }


            //Reverse the Given No
            public static void reverseno(int n)
            {
                int rev = 0, rem;
                while (n != 0)
                {
                    rem = n % 10;
                    rev = rev * 10 + rem;
                    n = n / 10;
                }
                Console.WriteLine("reverse no is :" + rev);

            }


            //prime Or not Program
            public static void PrimeOrNot(int n)
            {
                int isprime = 0;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isprime++;
                    }
                }
                if (isprime != 0)
                {
                    Console.WriteLine("No is not prime");
                }
                else
                {
                    Console.WriteLine("No is Prime");
                }

            }

            //Fibonini Series

            // out=5
            // 0 1 1 2 3 
            public static void Fibonacic(int n)
            {
                int n1 = 0, n2 = 1, n3;
                Console.Write(n1 + "" + n2);
                for (int i = 2; i < n; i++)
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + "");
                    n1 = n2;
                    n2 = n3;
                }

            }


            //Pallindrom or not

            public static void Pallindrom(int n)
            {
                int org = n;
                int rev = 0, rem;

                while (n != 0)
                {
                    rem = n % 10;
                    rev = rev * 10 + rem;
                    n = n / 10;
                }
                if (rev == org)
                {
                    Console.WriteLine("No is Pallindrom");
                }
                else
                {
                    Console.WriteLine("No is Not Pallindrom");
                }
            }
        }
    }
