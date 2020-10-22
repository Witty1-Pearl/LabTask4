using System;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1;
            int value2 ;
            int value3;
            int value4;
            int value5;
            int value6;
            int Minimum1;
            int Minimum2;
            
            
            Console.Write("please enter first number: ");
            value1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("please enter second number: ");
            value2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("please enter third number: ");
            value3 = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("please enter fourth number: ");
            value4 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("please enter fifth number: ");
            value5 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("please enter sixth number: ");
            value6 = Convert.ToInt32(Console.ReadLine());
            
            Minimum1 =Math.Min(value1, Math.Min(value2, value3));
            Minimum2 =Math.Min(value4, Math.Min(value5, value6));
            Console.WriteLine($"The minimum of the Six numbers is {Minimum1}");
   
        }
   }
}   