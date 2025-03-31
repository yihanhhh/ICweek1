using System;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {

        public static Shape AddColour(Shape s)
        {
            s.Colour = "Red";

            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
            s.Colour = "Blue";

            return s;
        }

        public static Shape RandomColour(Shape s)
        {

            Random random = new Random();
            string[] colours = { "Yellow", "Red", "Blue", "Green", "Orange" };


            int randomIndex = random.Next(5);


            s.Colour = colours[randomIndex];

            return s;

        }
    }
}
