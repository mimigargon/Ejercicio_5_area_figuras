using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_area_figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            do
            {
                Console.WriteLine("¿Qué área quieres calcular? Triangulo: 1. Cuadrado: 2. Círculo: 3. Finalizar: 0.");
                 num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Introduce la altura del triángulo:");
                        double triangleHeight = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la base del triángulo:");
                        double triangleBase = double.Parse(Console.ReadLine());
                        Console.WriteLine("La base del triangulo es de {0} cm cuadrados", triangleArea(triangleHeight, triangleBase));
                        break;

                    case 2:
                        Console.WriteLine("Introduce un lado del cuadrado:");
                        double squareSide = double.Parse(Console.ReadLine());
                        Console.WriteLine("La base del cuadrado es de {0} cm cuadrados", squareArea(squareSide));
                        break;

                    case 3:
                        Console.WriteLine("Introduce el radio del círculo:");
                        double radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("El área del círculo es de {0} cm cuadrados", circleArea(radius));
                        break;
                }

            } while (num != 0);

           
        }

        public static double triangleArea(double h, double b)
        {
            double result = 0;
            result = h * b / 2;
            return result;
        }

        public static double squareArea(double side)
        {
            double result = 0;
            result = side * side;
            return result;
        }

        public static double circleArea(double r)
        {
            double result = 0;
            double squaredRadius = 0;
            const double pi = 3.1416;
            const int exponent = 2;

            squaredRadius = Math.Pow(r, exponent);

            result = pi * squaredRadius;

            return result;
            
        }
    }
}
