using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chease
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[8, 8];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int a = 0; a < arr.GetLength(1); a++)
                {
                    if(i%2!=0)
                        if(a%2!=0)
                            Console.Write("## ");
                        else
                            Console.Write("   ");
                        
                    else if(i%2==0)
                        if(a%2==0)
                            Console.Write("## ");
                        else
                            Console.Write("   ");
                }
                Console.WriteLine();
            }
;        
        }
    }
}
