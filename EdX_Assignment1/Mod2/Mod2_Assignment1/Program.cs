using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            char c= 'X';
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(c);
                    c = c == 'O' ? 'X' : 'O';
                }
                Console.WriteLine();
                c = c == 'O' ? 'X' : 'O';
            }
            
        }
    }
}
