namespace EB_DZ_43;
using EB_DZ_43.Models;
using EB_DZ_43.Services;
using EB_DZ_43.Factories;
using EB_DZ_43.Shapes.Base;

public class Program
{
    static void Main()
    {
        Map map = Map.Instance;
        Shape[] shapes = new Shape[0];
        DateTime counter = DateTime.Now;


        ShapeService shapeService = new ShapeService(new DigitElementFactory());

        while (true)
        {
            Thread.Sleep(500);
            Console.Clear();
            map.DrawMap();
            if (shapes.Length != 0)
            {
                foreach (var shape in shapes)
                {
                    if (map.mapTiles[shape.shapePosition.Item2 + 1, shape.shapePosition.Item1] != (char)32)
                    {
                        Console.SetCursorPosition(shape.shapePosition.Item1, shape.shapePosition.Item2);
                        Console.Write(shape);
                        continue;
                    }

                    for (int i = 0; i < shape.model.Length; i++)
                    {
                        map.mapTiles[shape.shapePosition.Item2, i + shape.shapePosition.Item1] = ' ';
                    }

                    shape.shapePosition = (shape.shapePosition.Item1, shape.shapePosition.Item2 + 1);

                    for (int i = 0; i < shape.model.Length; i++)
                    {
                        map.mapTiles[shape.shapePosition.Item2, i + shape.shapePosition.Item1] = shape.model[i];
                    }
                    Console.SetCursorPosition(shape.shapePosition.Item1, shape.shapePosition.Item2);
                    Console.Write(shape);
                }
            }

            if (DateTime.Now - counter > TimeSpan.FromSeconds(2))
            {
                var shape = shapeService.CreateElement();
                shapes = shapes.Append(shape).ToArray();

                int rand = Random.Shared.Next(0,2);
                if (rand == 0)
                    shapeService = new ShapeService(new DigitElementFactory());
                else
                    shapeService = new ShapeService(new AlphabetElementFactory());
                Console.SetCursorPosition(shape.shapePosition.Item1, shape.shapePosition.Item2);
                Console.Write(shape);
                counter = DateTime.Now;
            }
        }
    }
}