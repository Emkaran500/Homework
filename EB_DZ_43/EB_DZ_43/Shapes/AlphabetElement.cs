namespace EB_DZ_43.Shapes;

using EB_DZ_43.Shapes.Base;

public class AlphabetElement : DigitElement
{
    public static int numOfLetter = 97;

    public override void Show()
    {
        for (int i = 0; i < this.model.Length; i++)
        {
            Console.Write(this.model[i]);
        }
    }
}
