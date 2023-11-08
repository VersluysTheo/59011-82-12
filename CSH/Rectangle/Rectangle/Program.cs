namespace Rectangle
{
    class Program
    {
        static void Main()
        {
            Rectangle rectangle1 = new(4, 5);
            rectangle1.AfficherRectangle();
            Triangle triangle1 = new(8, 10);
            triangle1.AfficherTriangle();
        }
    }
}