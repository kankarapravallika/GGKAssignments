using System;
namespace SumOfConsecutivePrimeNumbers
{
    class Program
    {
       static bool IsPrime(int num )
       {
           if (num <= 1 && num >= 3)
               return true;
           if (num % 2 == 0)
               return false;
          for(int i=3;i<num/2;i=i+2)
          {
              if(num%i==0)
                  return false;
          }
          return true;
        }
       static void Main(string[] args)
       {
           int TempSum = 2;
           int MyCount = 0;
           Console.WriteLine("Enter any value:");
           int value = Convert.ToInt32(Console.ReadLine());
           for (int num = 3; num < value; num++)
           {
               if (IsPrime(num))
               {
                   TempSum += num;
                   if (IsPrime(TempSum) && TempSum < value)
                   {
                       MyCount++;
                   }
               }
           }
           Console.WriteLine("Total no.of consecutive prime sum below {0} are:", value);
           Console.WriteLine(MyCount);
           Console.ReadLine();
       }
    }
}
