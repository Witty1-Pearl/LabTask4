using System;

namespace ParkingCustomers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCustomers;

            Console.WriteLine("Please enter number of customers");
            numOfCustomers = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numOfCustomers; i++)
            {
                Console.WriteLine("Please enter the number of hours customer {0} parked", i);
               
               double hours = Convert.ToDouble(Console.ReadLine());
               
                Customers cust = new Customers(hours);

                Console.WriteLine("Customer {0} charges are: {1:C2}",i,cust.CalculateCharges());
            }

            Console.ReadLine();
        }
    }
}
