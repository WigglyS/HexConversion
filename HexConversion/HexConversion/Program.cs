using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            long input;
            Console.WriteLine("Enter a line to convert to Hex :");
            Int64.TryParse(Console.ReadLine(), out input);

            //converting the long from the parse to an int i need
            int num = (int)input;

            //list for the character of the hex number
            List<char> hexNum = new List<char>();
   
            while (num != 0)
            {
                //since hexadecimal is base 16 need to modulus by the input number
                int temp = num % 16;
          
                if (temp < 10)
                {
                    //converts the int into the corrosponding char then adds it to the list
                    int charIndex = temp + 48;
                    char charConversion = (char)charIndex;
                    hexNum.Add(charConversion);
                }
                else
                {
                    //if the num is above 10 then it needs to go to a,b,c etc so the 55 converts the number to the corrosponding char 
                    int charIndex = temp + 55;
                    char charConversion = (char)charIndex;
                    hexNum.Add(charConversion);
                }
 
                num /= 16;

            }

            //the digits come in reverse order in this algorithim so i need to reverse it
            hexNum.Reverse();

            //display the character on the hex number
            foreach (char digit in hexNum)
            {
                Console.Write(digit);
            }

            Console.ReadKey();

        }
    }
}
