namespace EB_DZ_43.Factories;

using EB_DZ_43.Factories.Base;
using EB_DZ_43.Shapes;
using EB_DZ_43.Shapes.Base;

public class DigitElementFactory : IShapeFactory
{
    public DigitElement GetElement()
    {
        var shape = new DigitElement();
        Random rand = new Random();
        shape.model = new char[rand.Next(1, 5)];

        for (int i = 0; i < shape.model.Length; i++)
        {
            if (DigitElement.count > '9')
                DigitElement.count = '1';

            shape.model[i] = DigitElement.count;
            DigitElement.count++;
        }

        shape.shapePosition = (Random.Shared.Next(1, 19 - shape.model.Length), 1);

        return shape;
    }
}
