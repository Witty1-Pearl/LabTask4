using System;

namespace Hypothenus
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1; // first side of triangle

            double side2; // second side of triangle

        

            Console.Write( "Enter side 1 (negative to quit): " );

            side1 = Convert.ToDouble( Console.ReadLine() );

            

            while ( side1 > 0 )

        {

        Console.Write( "Enter side 2: " );

        side2 = Convert.ToDouble( Console.ReadLine() );

        

        Console.WriteLine( "Hypotenuse is: {0}", Hypotenuse( side1, side2 ));

        

        

        Console.Write( "Enter side 1 (negative to quit): ");

        side1 = Convert.ToDouble( Console.ReadLine() );

        } // end while

        } // end Main

        

        // calculate hypotenuse given lengths of two sides

        public static double Hypotenuse( double side1, double side2 )

        {
                double hypotenuseSquared = Math.Pow( side1, 2 ) +

                Math.Pow( side2, 2 );

                

                return Math.Sqrt( hypotenuseSquared );

        }
    }
}
