using Figuras.Entities;
using Figuras.Entities.Enums;

namespace Figuras {
    internal class Program {
        static void Main(string[] args) {

            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberShapes = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= numberShapes; i++) {

                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shape = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Color (Black/Blue/Red): ");
                Color Color = Enum.Parse<Color>(Console.ReadLine());

                if (shape == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    shapes.Add(new Rectangle(width, height, Color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    shapes.Add(new Circle(Color, radius));
                }

                Console.WriteLine();

            }

            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in shapes) {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}