namespace EB_DZ_43.Factories;

using EB_DZ_43.Factories.Base;
using EB_DZ_43.Shapes;
using EB_DZ_43.Shapes.Base;

public class AlphabetElementFactory : IShapeFactory
{
    public DigitElement GetElement()
    {
        var shape = new AlphabetElement();
        Random rand = new Random();
        shape.model = new char[rand.Next(1, 5)];

        for (int i = 0; i < shape.model.Length; i++)
        {
            if (AlphabetElement.numOfLetter > (int)'z')
                AlphabetElement.numOfLetter = (int)'a';

            shape.model[i] = (char)AlphabetElement.numOfLetter;
            shape.color = ConsoleColor.DarkRed;
            AlphabetElement.numOfLetter++;
        }

        shape.shapePosition = (Random.Shared.Next(1, 19 - shape.model.Length), 1);

        return shape;
    }
}
