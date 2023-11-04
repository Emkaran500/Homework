namespace EB_DZ_43.Shapes.Base;
public abstract class Shape
{
    public ConsoleColor color;

    public (int, int) shapePosition;

    public char usedSymbol;

    public char[] model;

    public abstract void Show();

    public override string ToString()
    {
        return string.Join("", this.model);
    }
}
