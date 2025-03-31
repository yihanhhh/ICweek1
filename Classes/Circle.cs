using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape, IShape
    {
        private int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public override int GetArea()
        {
            return(int) 3.14 * radius * radius;
        }
    }

}
