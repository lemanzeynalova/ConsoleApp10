using ConsoleApp10;

namespace ConsoleApp10
{
    internal class Area
    {
        //cevrenin sahesi
        public static double CircleArea(double radius)
        {
            double pi = 3;
            return pi * radius * radius;
        }
        //duzbucaqlinin sahesi
        public static double RectangleArea(double length, double width)
        {
            return length * width;
        }
        //duzbucaqli paralelpipedin tam sethinin sahesi
        public static double ParallelepipedSurfaceArea(double length, double width, double height)
        {
            return 2 * (length * width + length * height + width * height);
        }
        // // Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi
        public static double TriangleInscribedCircleArea(double a, double b, double c)
        {
            double p = a + b + c / 2;
            double radius = p * ((p - a) * (p - b) * (p - c)) / p;
            return radius;
        }
    }
}

class Program
{
    static void Main()
    {
        double circleRadius = 5;
        double rectangleLength = 4;
        double rectangleWidth = 6;
        double parallelepipedLength = 3;
        double parallelepipedWidth = 4;
        double parallelepipedHeight = 5;
        double triangleSideA = 3;
        double triangleSideB = 4;
        double triangleSideC = 5;
        Console.WriteLine("Çevrənin sahəsi: " + Area.CircleArea(circleRadius));
        Console.WriteLine("Düzbucaqlının sahəsi: " + Area.RectangleArea(rectangleLength, rectangleWidth));
        Console.WriteLine("Düzbucaqlı paralelpipedin tam səthi: " + Area.ParallelepipedSurfaceArea(parallelepipedLength, parallelepipedWidth, parallelepipedHeight));
        Console.WriteLine("Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi: " + Area.TriangleInscribedCircleArea(triangleSideA, triangleSideB, triangleSideC));
    }
}
