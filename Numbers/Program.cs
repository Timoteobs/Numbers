using System;
using System.Globalization;

namespace Numbers {
    class Program {

        static double Pi = 3.14;
        static void Main(string[] args) {
            Console.Write("Entre com o valor do raio: ");
            double ray = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circuference = GenerateCircumference(ray);
            double volume = Volume(ray);

            Console.WriteLine("Circuferencia: " + circuference.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double GenerateCircumference(double ray) {
            return 2.0 * Pi * ray;
        }

        static double Volume(double ray) {
            return 4.0 / 3.0 * Pi * Math.Pow(ray, 3.0);
        }
    }
}
