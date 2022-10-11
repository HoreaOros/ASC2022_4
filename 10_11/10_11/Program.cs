using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 256;
            int pad = 8;

            string str = "abcdefgh";
            
            for (int i = 0; i < 256; i++)
            {
                ShowPad(i, pad, str);
            } 
        }

        private static void ShowPad(int no, int pad, string str)
        {
            Stack<int> stack = new Stack<int>();
            while (no != 0)
            {
                stack.Push(no % 2);
                no = no / 2;
            }
            int z;
            z = pad - stack.Count;
            for (int i = 0; i < z; i++)
            {
                stack.Push(0);
            }

            //for (int j = 0; j < pad; j++)
            //{
            //    if (stack.Pop() == 1)
            //    {
            //        Console.Write(str[j]);
            //    }
            //}
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
