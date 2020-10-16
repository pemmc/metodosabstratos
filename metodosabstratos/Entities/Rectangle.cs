using System;
using metodosabstratos.Entities.Enums;

namespace metodosabstratos.Entities
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        //Criando o construtor do retangulo
        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;

        }

        public override double Area()
        {

            return Width * Height;

        }
    }
}
