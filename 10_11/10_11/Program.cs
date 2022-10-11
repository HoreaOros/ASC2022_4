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



            for (int i = 0; i < 256; i++)
            {
                ShowPad(i, pad);
            }
            
        }

        private static void ShowPad(int no, int pad)
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
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
