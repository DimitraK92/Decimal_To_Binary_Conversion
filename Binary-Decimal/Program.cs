using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> binaryNumber = ConvertDecToBinary(256);


            binaryNumber.ForEach(Console.Write);
            Console.WriteLine("\n");
            Console.ReadKey();
           

        }

        static List <int> ConvertDecToBinary (int number)
        {
            
            List<int> binaryFormat = new List<int>();            
        
            while (number != 0) 
            {
                

                if (number % 2 == 0)
                {                   
                    binaryFormat.Add(0);
                    
                }
                else
                {
                    binaryFormat.Add(1);
                    
                }
                number /= 2;            

            }

            binaryFormat.Reverse();
            return binaryFormat;

        }
    }
}
