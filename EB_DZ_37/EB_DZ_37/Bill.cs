public class Bill
{
    public double finalSum = default;
    public string[] basketNames = new string[0];

    public string[] AddBasket()
    {
        string[] newBasketNames = new string[Basket.basketLength];

        for (int i = 0; i < Basket.basketLength; i++)
        {
            newBasketNames[i] = Basket.products[i].name;
        }

        this.basketNames = newBasketNames;

        return this.basketNames;
    }

    public void ShowBill()
    {
        Console.WriteLine("Your groceries:");
        for (int i = 0; i < Basket.basketLength; i++)
        {
            Console.WriteLine($"{i + 1}. {basketNames[i]}");
        }
        Console.WriteLine($"Final Sum: {finalSum} (0.05% service)");
    }

    public Bill(double finalSum)
    {
        this.finalSum = finalSum;
        this.AddBasket();
    }
}
