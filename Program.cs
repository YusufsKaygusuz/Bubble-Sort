using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] {12,8,27,2,6,19,10 };

            for(int i =0; i<Numbers.Length - 1; i++)
            {
                for (int j = 1; j < Numbers.Length - i; j++)
                {
                    if(Numbers[j]< Numbers[j-1])
                    {
                        int temp = Numbers[j - 1];
                        Numbers[j - 1] = Numbers[j];
                        Numbers[j] = temp;
                    }
                }
            }

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
