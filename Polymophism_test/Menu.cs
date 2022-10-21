using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    public class Menu
    {
        public void InputFromUserShape()
        {
            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();
            Geometry parallelogram = new Parallelogram();
            Geometry ellipse = new Ellipse();

            bool menu = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("--------------------");
                Console.WriteLine("CONversin PROgram");
                Console.WriteLine("--------------------");
                Console.WriteLine();
                Console.WriteLine("| S  H  A  P  E  S |");
                Console.WriteLine();
                Console.WriteLine("|#1|Circle\n|#2|Rectangle\n|#3|Square\n|#4|Parallelogram\n|#5|Ellipse\n|#6|Exit");
                Console.ResetColor();
                bool shapeAnswer = true;
                int userShape;
                if (Int32.TryParse(Console.ReadLine(), out userShape))

                    switch (userShape)
                    {
                        case 1:                         //Circle
                            Console.Clear();
                            CircleCalc();
                            shapeAnswer = false;
                            break;
                        case 2:                         //Rectangle
                            Console.Clear();
                            RectangleCalc();
                            shapeAnswer = false;
                            break;
                        case 3:                         //Square
                            Console.Clear();
                            SquareCalc();
                            shapeAnswer = false;
                            break;
                        case 4:                         //Parallelogram
                            Console.Clear();
                            ParallelogramCalc();
                            shapeAnswer = false;
                            break;
                        case 5:                         //Ellipse
                            Console.Clear();
                            EllipseCalc();
                            shapeAnswer = false;
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            
                            Console.WriteLine("Now exit");
                            Environment.Exit(0);
                            break;
                    }
                if (shapeAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Choose 1-4 from menu");
                    Console.ResetColor();
                }
                Console.ReadKey();
            } while (menu);

        }
        public void CircleCalc()
        {
            Circle circle = new Circle();

            double radius;
            bool CircleMenu = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Select calculation");
                Console.WriteLine();
                Console.WriteLine("|#1|Area\n|#2|Perimeter\n|#3|Volume as Sphere\n|#4|New shape\n|#5|Exit");
                bool calcAnswer = true;
                int selectedCalc;
                if (Int32.TryParse(Console.ReadLine(), out selectedCalc))
                
                    switch (selectedCalc)
                    {
                        case 1: //Area calculate     
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Clear();    
                            Console.WriteLine("AREA of CIRCLE");
                            Console.WriteLine();
                            Console.Write("Enter radius: ");
                            if (double.TryParse(Console.ReadLine(), out radius))
                            {
                                circle.GetArea(radius, radius);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("enter for menu");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("enter radius with a number");
                                Console.ResetColor();
                            }
                            calcAnswer = false;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;       //Perimeter calculate            
                            Console.Clear();
                            Console.WriteLine("PERIMETER of CIRCLE");
                            Console.WriteLine();
                            Console.Write("Enter radius: ");
                            if (double.TryParse(Console.ReadLine(), out radius))
                            {
                                circle.GetPerimeter(radius, radius = 0);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("enter for menu");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("||enter radius with a number||");
                                Console.ResetColor();
                            }
                            calcAnswer = false;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;        //VolumeSphere calculate
                            Console.Clear();
                            bool CalcSphere = true;
                            while (CalcSphere)
                            {
                                Console.WriteLine("VOLUME as SPHERE");
                                Console.WriteLine();
                                Console.Write("Enter radius: ");
                                if (double.TryParse(Console.ReadLine(), out radius))
                                {
                                    circle.GetVolumeSphere(radius);
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("enter for menu");
                                    Console.ResetColor();
                                    CalcSphere = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("||enter radius with a number||");
                                    Console.ResetColor();
                                }
                                calcAnswer = false;
                                break;
                            }
                            Console.ReadLine();
                            Console.Clear();
                            CircleCalc();
                            break;
                        case 4:
                            InputFromUserShape();
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Environment.Exit(0);
                            break;
                    }
                if (calcAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Choose from menu 1-5");
                    Console.ResetColor();
                }
                Console.ReadKey();
            } while (CircleMenu);
 
        }
        protected void RectangleCalc()
        {
            Rectangle rectangle = new Rectangle();

            double length;
            double height;
            double width;
            bool RectangleMenu = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Select calculation");
                Console.WriteLine();
                Console.WriteLine("|#1|Area\n|#2|Perimeter\n|#3|Volume\n|#4|New shape\n|#5|Exit");
               
                int areaCalc;
                if (Int32.TryParse(Console.ReadLine(), out areaCalc))

                    switch (areaCalc)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            bool userWidth = true;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("| AREA of RECTANGLE|");
                                Console.WriteLine();
                                Console.Write("Enter width: ");
                                userWidth = double.TryParse(Console.ReadLine(), out width);
                            } while (!userWidth);
                            bool userHeight = true;
                            do
                            {
                                Console.Write("Enter height: ");
                                userHeight = double.TryParse(Console.ReadLine(), out height);

                            } while (!userHeight);
                           
                            Console.WriteLine();
                            rectangle.GetArea(width, height);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("enter for menu");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                            
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            bool widthPerimeter = true;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("| PERIMETER of RECTANGLE |");
                                Console.WriteLine();
                                Console.Write("Enter width: ");
                                widthPerimeter = double.TryParse(Console.ReadLine(), out width);
                            } while (!widthPerimeter);
                            bool heightPerimeter = true;
                            do
                            {
                                Console.Write("Enter height: ");
                                heightPerimeter = double.TryParse(Console.ReadLine(), out height);

                            } while (!heightPerimeter);

                            Console.WriteLine();
                            rectangle.GetPerimeter(width, height);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("enter for menu");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                    case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            bool widthVolume = true;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("| VOLUME of RECTANGLE |");
                                Console.WriteLine();
                                Console.Write("Enter width: ");
                                widthVolume = double.TryParse(Console.ReadLine(), out width);
                            } while (!widthVolume);
                            bool heightVolume = true;
                            do
                            {
                                Console.Write("Enter height: ");
                                heightVolume = double.TryParse(Console.ReadLine(), out height);

                            } while (!heightVolume);
                            bool lenghtVolume = true;
                            do
                            {
                                Console.Write("Enter length: ");
                                lenghtVolume = double.TryParse(Console.ReadLine(), out length);

                            } while (!lenghtVolume);
                            Console.WriteLine();
                            rectangle.GetVolume(width, height, length);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("enter for menu");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                    case 4:
                        InputFromUserShape();

                        break;
                    case 5:
                         Console.ForegroundColor = ConsoleColor.DarkBlue;
                         Environment.Exit(0);
                        break;
                }
            } while (RectangleMenu);
            
        }

        protected void SquareCalc()
        {
            Square square = new Square();

            double sides;
            double height;

            bool SquareMenu = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Select calculation");
                Console.WriteLine();
                Console.WriteLine("|#1|Area\n|#2|Perimeter\n|#3|New shape\n|#4|Exit");

                int squareCalc;
                if (Int32.TryParse(Console.ReadLine(), out squareCalc))
                    switch (squareCalc)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            bool userWidth = true;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("| AREA of SQUARE |");
                                Console.WriteLine();
                                Console.Write("Enter width: ");
                                userWidth = double.TryParse(Console.ReadLine(), out sides);
                            } while (!userWidth);
                            bool userHeight = true;
                            do
                            {
                                Console.Write("Enter height: ");
                                userHeight = double.TryParse(Console.ReadLine(), out height);

                            } while (!userHeight);

                            Console.WriteLine();
                            square.GetArea(sides, height);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("enter for menu");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            bool widthPerimeter = true;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("| PERIMETER of SQUARE |");
                                Console.WriteLine();
                                Console.Write("Enter width: ");
                                widthPerimeter = double.TryParse(Console.ReadLine(), out sides);
                            } while (!widthPerimeter);

                            Console.WriteLine();
                            square.GetPerimeter(sides);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("enter for menu");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        case 3:
                            InputFromUserShape();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Environment.Exit(0);
                            break;
                    }

            } while (SquareMenu);

        }
        protected void ParallelogramCalc()
        {
            Parallelogram parallelogram = new Parallelogram();

            double width;
            double height;
            double lenght;

            bool ParallelogramMenu = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Select calculation");
                Console.WriteLine();
                Console.WriteLine("|#1|Area\n|#2|Perimeter\n|#3|New shape\n|#4|Exit");

                int ParalelloCalc;
                if (Int32.TryParse(Console.ReadLine(), out ParalelloCalc))
                    switch (ParalelloCalc)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            bool userLenght = true;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("| AREA of PARALLELOGRAM |");
                                Console.WriteLine();
                                Console.Write("Enter lenght: ");
                                userLenght = double.TryParse(Console.ReadLine(), out lenght);
                            } while (!userLenght);
                            bool userHeight = true;
                            do
                            {
                                Console.Write("Enter height: ");
                                userHeight = double.TryParse(Console.ReadLine(), out height);

                            } while (!userHeight);

                            Console.WriteLine();
                            parallelogram.GetArea(lenght, height);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("enter for menu");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            bool lenghtPerimeter = true;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("| PERIMETER of PARALLELOGRAM |");
                                Console.WriteLine();
                                Console.Write("Enter lenght: ");
                                lenghtPerimeter = double.TryParse(Console.ReadLine(), out lenght);
                            } while (!lenghtPerimeter);
                            
                            bool heightPerimeter = true;
                            do
                            {
                                Console.Write("Enter height: ");
                                heightPerimeter = double.TryParse(Console.ReadLine(), out height);
                            } while (!heightPerimeter);
                            Console.WriteLine();
                            parallelogram.GetPerimeter(lenght, height);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("enter for menu");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        case 3:
                            InputFromUserShape();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Environment.Exit(0);
                            break;
                    }

            } while (ParallelogramMenu);
        }
        public void EllipseCalc()
        {
            Ellipse ellipse = new Ellipse();

            double MajorRadiusA;
            double MinorRadiusB;

            bool ParallelogramMenu = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Select calculation");
                Console.WriteLine();
                Console.WriteLine("|#1|Area\n|#2|Perimeter\n|#3|New shape\n|#4|Exit");

                int EllipseCalc;
                if (Int32.TryParse(Console.ReadLine(), out EllipseCalc))
                    switch (EllipseCalc)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            bool userRadiusA = true;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("| AREA of ELLIPSE |");
                                Console.WriteLine();
                                Console.Write("Enter radius 1: ");
                                userRadiusA = double.TryParse(Console.ReadLine(), out MajorRadiusA);
                            } while (!userRadiusA);

                            bool userRardiusB = true;
                            do
                            {
                                Console.Write("Enter radius 2: ");
                                userRardiusB = double.TryParse(Console.ReadLine(), out MinorRadiusB);

                            } while (!userRardiusB);

                            Console.WriteLine();
                            ellipse.GetArea(MajorRadiusA, MinorRadiusB);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("enter for menu");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            bool radiusAPerimeter = true;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("| PERIMETER of ELLIPSE |");
                                Console.WriteLine();
                                Console.Write("Enter radius 1: ");
                                radiusAPerimeter = double.TryParse(Console.ReadLine(), out MajorRadiusA);
                            } while (!radiusAPerimeter);

                            bool radiusBPerimeter = true;
                            do
                            {
                                Console.Write("Enter radius 2: ");
                                radiusBPerimeter = double.TryParse(Console.ReadLine(), out MinorRadiusB);
                            } while (!radiusBPerimeter);
                            Console.WriteLine();
                            ellipse.GetPerimeter(MajorRadiusA, MinorRadiusB);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("enter for menu");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        case 3:
                            InputFromUserShape();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Environment.Exit(0);
                            break;
                    }

            } while (ParallelogramMenu);
        }
    }
}
