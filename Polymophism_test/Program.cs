namespace Polymophism_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drawing circle = new Circle();
            Drawing square = new Square();
            Drawing rectangle = new Rectangle();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Some basic calculations");
            Console.WriteLine("-------------------------");
            Console.ResetColor();
            circle.PrintInfo();
            Console.WriteLine();
            rectangle.PrintInfo();
            Console.WriteLine();
            square.PrintInfo();
        }
    }
}