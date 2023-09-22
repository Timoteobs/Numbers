using System;
using System.Globalization;

namespace Numbers {
    class Program {
        static void Main(string[] args) {
           
            Console.Write("Entre com o valor do raio: ");
            double ray = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circuference = Calculator.GenerateCircumference(ray);
            double volume = Calculator.Volume(ray);

            Console.WriteLine("Circuferencia: " + circuference.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
