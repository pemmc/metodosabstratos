using System;
using System.Collections.Generic;
using System.Globalization;

using metodosabstratos.Entities;
using metodosabstratos.Entities.Enums;

namespace metodosabstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> minhaLista = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("Shape #" + i.ToString());

                Console.WriteLine("Rectangle or Circle (r/c)? ");

                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");

                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    minhaLista.Add(new Rectangle(width, height, color));

                }

                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    minhaLista.Add(new Circle(radius, color));
                }

                Console.WriteLine();

                Console.WriteLine("Shape Areas:");

                foreach (Shape shape in minhaLista)
                {

                    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));

                }


            }


        }
    }
}
