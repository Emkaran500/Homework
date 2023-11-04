public static class MenuApp
{
    private static string choice = default;

    public static string Choice
    {
        get { return choice; }
        set { choice = value; }
    }

    private static double wallet = 0;

    public static double Wallet
    {
        get { return wallet; }
        set 
        {
            if ((wallet + value + (value * 0.05)) < 0)
            {
                throw new ArgumentException(message: "Your balance can't be less than zero!");
            }
            wallet = value;
        }
    }

    public static void MoneyInput()
    {
        Console.Clear();
        int moneyInput = default;
        string strMoneyInput = default;

        do
        {
            Console.Write("Please, input the amount of money you want to add: ");
            strMoneyInput = Console.ReadLine();

        } while (int.TryParse(strMoneyInput, out moneyInput) != true);
        Wallet += moneyInput;
        Menu();
    }

    public static void CashOut()
    {
        if ((Wallet - Basket.finalSum + (Basket.finalSum * 0.05)) < 0)
        {
            Console.WriteLine("Your wallet is too small!");
            BasketMenu();
        }

        Wallet -= Basket.finalSum + (Basket.finalSum * 0.05);
        Bill bill = new Bill(Basket.finalSum + (Basket.finalSum * 0.05));
        bill.ShowBill();
        Menu();
    }

    public static void WhatDidYouChoose_Menu()
    {
        switch(Choice)
        {
            case "1":
                Choice = "0";
                MarketMenu();
                break;
            case "2":
                Choice = "0";
                BasketMenu();
                break;
            case "3":
                Choice = "0";
                WalletMenu();
                break;
            case "4":
                System.Environment.Exit(0);
                break;
            default:
                break;
        }
    }

    public static void WhatDidYouChoose_Wallet()
    {
        switch(Choice)
        {
            case "1":
                Choice = "0";
                MoneyInput();
                break;
            case "2":
                Choice = "0";
                Menu();
                break;
            default:
                break;
        }
    }

    public static void WhatDidYouChoose_Basket()
    {
        switch (Choice)
        {
            case "1":
                CashOut();
                break;
            case "2":
                //DeletingProduct();
                break;
            case "3":
                Menu();
                break;
            default:
                break;
        }
    }

    public static void ToBasket()
    {
        switch (Choice)
        {
            case "1":
                Basket.AddProduct(new Bread());
                break;
            case "2":
                Basket.AddProduct(new Potato());
                break;
            case "3":
                Basket.AddProduct(new Apple());
                break;
            case "4":
                Basket.AddProduct(new Chocolate());
                break;
            case "5":
                Basket.AddProduct(new Cola());
                break;
            default:
                break;
        }
    }

    public static void Menu()
    {
        Console.Clear();
        do
        {
            Console.WriteLine("1. Open market");
            Console.WriteLine("2. Open basket");
            Console.WriteLine("3. Open wallet");
            Console.WriteLine("4. Exit");
            Console.WriteLine($"\n\nCurrect balance: {wallet}$");
            Console.Write("Please input your choice: ");
            Choice = Console.ReadLine();
            Console.Clear();
        } while (Choice != "1" && Choice != "2" && Choice != "3" && Choice != "4");
        WhatDidYouChoose_Menu();
    }

    public static void MarketMenu()
    {
        do
        {
            Console.WriteLine("List of products on sale:");
            for (int i = 0; i < Products.numOfProds; i++)
            {
                Console.WriteLine($"{i + 1}. {Products.names[i]}");
            }
            Console.WriteLine($"{Products.numOfProds + 1}. Exit to Main Menu");
            Console.WriteLine($"{Products.numOfProds + 2}. Open basket");

            Choice = Console.ReadLine();
            ToBasket();
        } while (Choice != Convert.ToString(Products.numOfProds + 1) && Choice != Convert.ToString(Products.numOfProds + 2));
        Menu();
    }

    public static void BasketMenu()
    {
        Console.Clear();
        do
        {
            for (int i = 0; i < Basket.basketLength; i++)
            {
                Console.WriteLine($"{i + 1}: {Basket.products[i].name} - {Basket.products[i].price}$");
            }
            Console.WriteLine($"Your final price is: {Basket.finalSum}\n");

            Console.WriteLine("1. Pay the bill");
            Console.WriteLine("2. Delete product from the basket");
            Console.WriteLine("3. Exit to Main Menu");
            Choice = Console.ReadLine();
        } while (Choice != "1" && Choice != "2" && Choice != "3");


    }

    public static void WalletMenu()
    {
        Console.Clear();
        do
        {
            Console.WriteLine($"Your current balance: {wallet}$\n");
            Console.WriteLine("1. Put more money");
            Console.WriteLine("2. Exit to Main Menu");
            Choice = Console.ReadLine();
        } while (Choice != "1" && Choice != "2");
        WhatDidYouChoose_Wallet();
    }
}
