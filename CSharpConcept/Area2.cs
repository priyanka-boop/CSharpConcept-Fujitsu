using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Area2
    {
        public static double AreaOfCircle(int r)
        {
            double output = 3.14 * r * r;
            return output;
        }
        public static double AreaOfSquare(double s)
        {
            return s * s;
        }
        public static double AreaOfTrapezium(double h, double a, double b)
        {
            return (1 / 2) * h * (a + b);
        }
        public static double VolumeOfSphere(double r)
        {
            return (4 / 3) * 3.14 * r * r * r;
        }

        static void Main(String[] args)
        {
            double res = Area2.AreaOfCircle(5);
            Console.WriteLine(res);


            double res1 = Area2.AreaOfSquare(40.2);
            Console.WriteLine(res1);

            double res2 = Area2.AreaOfTrapezium(5.0, 2.0, 3.0);
            Console.WriteLine(res2);

            double res3 = Area2.VolumeOfSphere(25.6);
            Console.WriteLine(res3);
        }
    }
}