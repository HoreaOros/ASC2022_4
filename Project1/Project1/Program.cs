using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pad = 8;
            string set = "abcdefgh";
            for (int n = 0; n < 256; n++)
            {
                ShowPad(n, pad, set);
            }
            
        }

        private static void ShowPad(int n, int pad, string set)
        {
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                stack.Push(n % 2);
                n = n / 2;
            }

            int z = pad - stack.Count;

            while (z > 0)
            {
                stack.Push(0);
                z--;
            }

            for (int j = 0; j < pad; j++)
            {
                if (stack.Pop() == 1)
                {
                    Console.Write(set[j]);
                }
            }

            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop());
            //}
            Console.WriteLine();
        }
    }
}
