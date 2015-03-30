using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlamsProblem
{
    class Program
    {

        static Stack<Int64> Result;

        static void Main(string[] args)
        {
            Console.Title = "Ulam's Problem";
            Console.BufferWidth = 10000;
            Console.BufferHeight = 100;

            for (Int64 i = 0; i < Int64.MaxValue; i++)
            {
                Result = new Stack<Int64>();

                Iter(i);

                StringBuilder Sb = new StringBuilder();      
                int Iterations = Result.Count;
                Int64 Max = 0;

                while (Result.Count > 0)
                {
                    Int64 C = Result.Pop();
                    if (C > Max)
                    {
                        Max = C;
                    }
                    Sb.Append(C + " ");
                }

                Console.Write(
                    string.Format(
                        "{0,-16} {1,7} {2,20} ",
                        i.ToString("#,##0"), 
                        Iterations.ToString("#,##0"), 
                        Max.ToString("#,##0")
                        )
                    );

                Console.WriteLine(Sb.ToString());
            }
        }

        static int Iter(Int64 N)
        {
            Result.Push(N);
            if (N > 1)
            {
                if (N % 2 == 0)
                {
                    return Iter(N / 2);
                }
                else
                {
                    return Iter((N * 3) + 1);
                }
            }
            else
            {
                return 0;
            }
        }



    }
}
