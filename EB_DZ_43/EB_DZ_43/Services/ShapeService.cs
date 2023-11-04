namespace EB_DZ_43.Services;

using EB_DZ_43.Factories;
using EB_DZ_43.Factories.Base;
using EB_DZ_43.Shapes;

public class ShapeService
{
    public IShapeFactory shapeFactory;

    public ShapeService(IShapeFactory shapeFactory)
    {
        this.shapeFactory = shapeFactory ?? new DigitElementFactory();
    }

    public DigitElement CreateElement()
    {
        return this.shapeFactory.GetElement();
    }
}
