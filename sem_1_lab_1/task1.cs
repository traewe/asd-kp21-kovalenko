using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            /* case 1 x = 1 y = 2 z = 3
             * case 2 x = 2 y = 1 z = 3
             * case 3 x = -12 y = 24 z = 0
             * case 4 x = 1 y = 1 z = 124
             */
            double x, y, z, a, b;
            Console.WriteLine("Enter value for x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for z: ");
            z = Convert.ToDouble(Console.ReadLine());
            if (y == 0 || Math.Pow(x, 3) + 5 * Math.Pow(y, -z) + Math.Pow(z, 2) <= 0 || y == Math.Pow(Math.Abs(Math.Pow(x, 3)), 0.5))
            {
                Console.WriteLine("Помилка");
            }
            else
            {
                a = (y - Math.Pow(Math.Abs(Math.Pow(x, 3)), 0.5)) / Math.Pow((Math.Pow(x, 3) + 5 * Math.Pow(y, -z) + Math.Pow(z, 2)), 0.5);
                b = Math.Sin(Math.Pow(a, -x)) + y;
                Console.WriteLine("a = " + Math.Round(a, 4));
                Console.WriteLine("b = " + Math.Round(b, 4));
            }
            /* case 1 a = 0.3068 b = 1.8823
             * case 2 a = -0.3898 b = 1.2931
             * case 3 "Помилка"
             * case 4 "Помилка" 
             */
        }
    }
}