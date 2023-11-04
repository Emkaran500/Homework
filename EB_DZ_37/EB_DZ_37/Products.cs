public abstract class Products
{
    public static readonly string[] names = new string[5] {"Bread", "Potato", "Apple", "Chocolate", "Cola"};

    public string name = default;

    public double price = default;

    public static readonly int numOfProds = 5;
}

public class Bread : Products
{
    public Bread()
    {
        this.name = names[0];
        this.price = 0.7;
    }
}

public class Potato : Products
{
    public Potato()
    {
        this.name = names[1];
        this.price = 0.1;
    }
}

public class Apple : Products
{
    public Apple()
    {
        this.name = names[2];
        this.price = 0.2;
    }
}

public class Chocolate : Products
{
    public Chocolate()
    {
        this.name = names[3];
        this.price = 2;
    }
}

public class Cola : Products
{
    public Cola()
    {
        this.name = names[4];
        this.price = 0.5;
    }
}
