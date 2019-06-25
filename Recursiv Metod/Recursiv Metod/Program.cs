using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursiv_Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine(SumofDigits(2354));
            // Console.WriteLine(EvenNumber(6));
            // Console.WriteLine(AtoBNumber(4,8 ));
            // Console.WriteLine(AtoBNumber(4, 10));
            //Console.WriteLine(Sum(3));
            // Console.WriteLine(PowSum(5));
            //Console.WriteLine(Multi(4));
            // Console.WriteLine(MultiDigits(245));
            // Console.WriteLine(Number(524792));
            //Console.WriteLine(Number(15));
        }
        //Task 1
        //static int SumofDigits(int number)

        //    { if (number /10== 0) return number;
        //        return number % 10 + SumofDigits(number / 10);
        //    }

        //Task 4

        //    static void PowNumber(int n, int degree=1)
        //{
        //    Print(Math.Pow(n, degree));

        //   if (degree <= 9)  PowNumber(n, ++degree);

        //}
        //Task 5 ??
        //static int EvenNumber(int n)
        //{

        //    if (n % 2 == 0)
        //    { return n+ EvenNumber(n - 2); }
        //    else if (n % 2 == 1)
        //    { return n -1 + EvenNumber(n - 2); }
        //    else return 1;


        //Task7
        //static int AtoBNumber(int A, int B)
        // {
        //    if (A<= B && B != 0) return A + AtoBNumber(++A, B);
        //    return 0;
        //}

        //Task 8
        //static int AtoBNumber(int A, int B)
        //{
        //    if (A % 3 == 0) return A;
        //    else if (B >= A) return AtoBNumber(++A, B);
        //    return 0;

        //}
        // Task 9 
        //static double Sum(int N)

        //{ if(1/N==1) return 1.0;
        //    return 1.0/N+ Sum(--N);
        //}

        //Task 10  N2 + (N + 1)2 + (N + 2)2 + … + (2·N)2

        //static double PowSum(double N)
        //{
        //    if (N == 1.0) return 1.0;
        //    return N*N + PowSum(--N);
        //}

        //Task 11 1.1 · 1.2 · 1.3 · …

        //static double Multi(int N)
        //{
        //    double i = 1.0 + N * 0.1;
        //    if (N==1) return 1.1;
        //    return  i* Multi(--N);

        //}
        //Task 16 
        //static double MultiDigits(int N)
        //{
        //    if (N / 10 == 0) return N;
        //    return N % 10 *MultiDigits(N/ 10);
        //}
        // Task 18 ?
        //static int Number(int N)
        //{     int i= N % 10;
        //    if (N / 10 == 0 && i > 4 && i % 2 == 1) return N;
        //    else if (i > 4 && i % 2 == 1)
        //        return N%10 + Number(N / 10);
        //    else return 0;

        //}
        //Task 22 ?
       static int Number(int N)
        {
          int i = N / 2;

           if (i == 1) return 0;
           return  i+N/i+ Number(N/--i);
                }

   } }










