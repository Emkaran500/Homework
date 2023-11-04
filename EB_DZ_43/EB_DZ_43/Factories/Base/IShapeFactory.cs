namespace EB_DZ_43.Factories.Base;

using EB_DZ_43.Shapes;
using EB_DZ_43.Shapes.Base;

public interface IShapeFactory
{
    DigitElement GetElement();
}
