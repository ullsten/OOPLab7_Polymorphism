namespace Polymophism_test
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|| Area calculations ||");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();
            Geometry Parallelogram = new Parallelogram(); 
            Geometry ellipse = new Ellipse();
            Menu menu = new Menu();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Press enter to make your own calculations");
            Console.ReadKey();
            menu.InputFromUserShape(); //Menu for the program
            Console.ReadKey();
        }
    }
}