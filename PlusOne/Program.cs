using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    internal class Program
    {
        public static  int[] PlusOne(int[] digits)
        {
            int[] result = new int[digits.Length];
            
            bool sign = true;
            for (int i = digits.Length-1; i >= 0; i--) 
            {
                if (sign) {
                    if (digits[i] < 9)
                    {
                        result[i ] = digits[i ] + 1;
                        sign = false;
                    }
                    else 
                    {
                        { result[i] = 0; }
                    }
                } else { result[i] = digits[i]; }

                
            }
            if (!sign) return result;
           
            return new int[] { 1 }.Concat(result).ToArray() ;
        }
        static void Main(string[] args)
        {
 //           Console.WriteLine("{"+String.Join(", ",PlusOne(new int[] { 4, 3, 2, 2 }))+"}");
  //          Console.WriteLine("{" + String.Join(", ", PlusOne(new int[] { 9 })) + "}");
            Console.WriteLine("{" + String.Join(", ", PlusOne(new int[] { 9,9 })) + "}");
            Console.ReadLine();
        }
    }
}
