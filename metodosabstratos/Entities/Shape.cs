using metodosabstratos.Entities.Enums;

namespace metodosabstratos.Entities
{

    public abstract class Shape
    {

        //usando o enum Color
        public Color Color { get; set; }

        /*
         * estou obrigando a informar uma cor na criacao
        public Shape()
        {

            //construtor padrão

        }
        */

        protected Shape(Color color)
        {

            Color = color;

        }


        //Método abstrato sem a implementacao
        //Por ser o método abstrato a classe tb será!
        public abstract double Area();
         
    }
}
