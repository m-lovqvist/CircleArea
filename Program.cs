namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Circle circle2= new Circle(6);

            circle.GetArea();
            circle2.GetArea();
        }
    }
}