using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacySeries
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "str123";
            //string b = string.Empty;
            //int val;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (Char.IsDigit(a[i]))
            //        b += a[i];
            //}

            //if (b.Length > 0)
            //    val = int.Parse(b);
            //Console.ReadLine();
            #region Print reverse array
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.ReadLine();
            #endregion
            #region Reverse Int
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
            #endregion

            #region Palendrom No
            //Console.WriteLine("Enter Number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int rem, sum = 0;
            //int temp = num;
            //while(num>0)
            //{
            //    rem = num % 10;
            //    num = num / 10;
            //    sum = sum * 10 + rem;
            //}
            //Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            //if (temp == sum) //checking whether the reversed number is equal to entered number    
            //{
            //    Console.WriteLine("\n Number is Palindrome \n\n");
            //}
            //else
            //{
            //    Console.WriteLine("\n Number is not a palindrome \n\n");
            //}
            //Console.ReadLine();
            #endregion

            #region Reverce String
            //string str = "";
            //string reverse = "";
            //int length = 0;
            //Console.WriteLine("Enter String");
            //str = Console.ReadLine();
            //length = str.Length - 1;
            //while (length>=0)
            //{
            //    reverse = reverse + str[length];
            //    length--;
            //}
            //Console.WriteLine(reverse);
            //Console.ReadKey();
            #endregion

            #region Fibonacy Number
            //Console.WriteLine("Enter Number");
            //int len = Convert.ToInt16(Console.ReadLine());
            //int a = 0;
            //int b = 1;
            //int c = 0;
            //for (int i = 0; i < len; i++)
            //{
            //    c = a + b;
            //    Console.WriteLine(c);
            //    a = b;
            //    b = c;
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
