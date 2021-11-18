using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
            static string Sum(string string1, string string2)
            {
             if (string1.Length > string2.Length)
            {
                string a = string1;
                string1 = string2;
                string2 = a;
            }

            string str = " ";

            int b = string1.Length, n2 = string2.Length;

            char[] ch = string1.ToCharArray();
            Array.Reverse(ch);
            string1 = new string(ch);
            char[] ch1 = string2.ToCharArray();
            Array.Reverse(ch1);
            string2 = new string(ch1);

            int carry = 0;
            for (int i = 0; i < b; i++)
            {
                int sum = ((int)(string1[i] - '0') +
                        (int)(string2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');

                carry = sum / 10;
            }

            for (int i = b; i < n2; i++)
            {
                int sum = ((int)(string2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            if (carry > 0)
                str += (char)(carry + '0');

            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            str = new string(ch2);

            return str;
        }

        static void Main(string[] args)
        {
                string numberString1 = "13351351516515151513513513513135135131321315313513135135156456484946543546546546";
                string numberString2 = "956648941648315468484646894645483515645648494";
                Console.WriteLine(Sum(numberString1, numberString2));
                Console.ReadLine();
        }
    }
}
