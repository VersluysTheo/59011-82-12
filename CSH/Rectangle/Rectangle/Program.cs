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
            Cercle cercle1 = new(10);
            cercle1.AfficherCercle();
            Parallelepipede para1 = new(4, 5, 16);
            para1.AfficherPara();
            Pyramide pyramide1 = new(8, 10);
            pyramide1.AfficherPyra();
            Sphere sphere1 = new(10);
            sphere1.AfficherSphere();
        }
    }
}