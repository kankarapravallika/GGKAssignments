using System;
using System.Text;
namespace AddingTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            string FirstNum = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string SecondNum = Console.ReadLine();
            StringBuilder sum = new StringBuilder();
            int FirstNumLen = FirstNum.Length;
            int SecondNumLen = SecondNum.Length;
            int Flag = 0;
            int MaxLen = (FirstNumLen > SecondNumLen) ? FirstNumLen : SecondNumLen;
            int carry = 0;
            if (FirstNumLen > SecondNumLen)
            {
                int temp = FirstNumLen - SecondNumLen;
                for (int i = 0; i < temp; i++)
                {
                    SecondNum = '0' + SecondNum;
                }
            }
            else
            {
                int temp = SecondNumLen - FirstNumLen;
                for (int i = 0; i < temp; i++)
                {
                    FirstNum = '0' + FirstNum;
                }
            }
             for (int j = 0; j < MaxLen; j++)
            {
                if (FirstNum[j] < 48 || FirstNum[j] > 57)
                {
                    Flag = 1;
                }
                else if (SecondNum[j] < 48 || SecondNum[j] > 57)
                {
                    Flag = 1;
                }
                else { }
            }
            if (Flag == 0)
            {
                for (int i = MaxLen - 1; i >= 0; i--)
                {
                    int value = (carry + FirstNum[i] - 48 + SecondNum[i] - 48) % 10;
                    sum.Append(value);
                    carry = (carry + FirstNum[i] - 48 + SecondNum[i] - 48) / 10;
                }
                if (carry != 0)
                {
                    sum.Append(carry);
                }
                char[] ArrayOfSum = sum.ToString().ToCharArray();
                Array.Reverse(ArrayOfSum);
                Console.WriteLine(ArrayOfSum);
            }
            else
            {
                Console.WriteLine("Entered numbers are not an integers");
            }
            Console.ReadLine();
        }
    }
}
