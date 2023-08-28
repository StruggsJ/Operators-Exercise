using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;


            if (a == 17 && b == 4)
            {
                
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}. ");
                
            }

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double circleArea = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {Math.Round(circleArea)}");
            Console.ReadKey();

        }

        public static double AreaOfCircle(double radius)
        {
            double area = (Math.PI * radius * radius);
            return area;
        }
    }

}