using System;
using System.Text;
namespace ASCIIConversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            byte[] a = Encoding.ASCII.GetBytes(s);         
            Console.Write("ASCII numbers before prime check:");
            int[] b = new int[s.Length];
            for (int i = 0; i < s.Length - 1; i++)
            {
                b[i]=(a[i]+a[i+1])/2;
                Console.Write("  " + b[i]);
            }
            char[] ch = new char[s.Length - 1];
            Console.Write("\nASCII numbers after prime check:");
            for (int i = 0, c = 0; i < s.Length - 1; i++)
            {
                for (int j = 2; j < b[i]; j++)
                {
                    if (b[i] % j != 0)
                        c = 1;
                    else
                    {
                        c = 0;
                        break;
                    }
                }
                if (c == 1)
                    ++b[i];
            }
            for (int i = 0; i < s.Length - 1; i++)
            {
               Console.Write("  "+b[i]);
            }
            for (int i = 0; i < s.Length - 1; i++)
            {
                ch[i] = (char)b[i];                    
            }
            string s2 = new string(ch);
            Console.Write("\nThe final result is:"+s2);
            Console.ReadKey(); 
        }
    }
}

