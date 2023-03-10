using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLabE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double positiveRadius = 100;
            double negativeRadius = -100;
            double zeroRadius = 0;


            try
            {
                Circle positiveCircle = new Circle(positiveRadius); // object 1 with positive radius
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            try
            {
                Circle negativeCircle = new Circle(negativeRadius); // object 2 with negative radius
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine($"The radius " + ex.Radius + "is invalid" );
                Console.WriteLine("Oh no! Something bad happened, but we can still go on. ");
            }


            try
            {
                Circle zeroCircle = new Circle(zeroRadius); // object 3 with zero
            }
            catch (Exception)
            {

                Console.WriteLine("Radius is 0");
            } 

            Console.ReadKey();
        }
    }
}
