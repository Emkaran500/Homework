class Program
{
    static void Main()
    {
        //1.
        //Даны целые положительные числа A и B(A < B).Вывести все целые нечётные числа от A до B включительно; каждое
        //число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное
        //его значению. Например: если А = 3, а В = 8, то программа
        //должна сформировать в консоли следующий вывод:
        //3 3 3
        //5 5 5 5 5
        //7 7 7 7 7 7 7
        string str = "  ";

        int A = default;
        int B = default;

        Console.Write("Input num1: ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input num2: ");
        B = Convert.ToInt32(Console.ReadLine());

        if (A > B)
        {
            int temp;
            temp = A;
            A = B;
            B = temp;
        }

        for (int i = A; i <= B; i++)
        {
            if (i % 2 != 0)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
                        Console.WriteLine(i);
                    else
                        Console.Write($"{i} ");
                }
            }
        }

        //2.
        //Пользователь с клавиатуры вводит длину линии, символ заполнитель, направление линии(горизонтальная,
        //вертикальная). Программа отображает линию по заданным параметрам.
        int length = default;
        char symbol = default;
        char horizontal = default;
        bool isHorizontal = default;

        Console.Write("Input length: ");
        length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input writing symbol: ");
        symbol = Convert.ToChar(Console.ReadLine());

        do
        {
            Console.Write("Is line horizontal? (y/n): ");
            horizontal = Convert.ToChar(Console.ReadLine());
        } while (horizontal != 'y' && horizontal != 'n');

        if (horizontal == 'y')
            isHorizontal = true;
        else
            isHorizontal = false;

        for (int i = 0; i < length; i++)
        {
            if (isHorizontal)
            {
                Console.Write(symbol);
            }
            else
            {
                Console.WriteLine(symbol);
            }
        }
        Console.WriteLine("");

        //3.
        //Пользователь вводит сумму денег и выбирает нужную валюту для конвертации. 
        //Программа выводит на экран резуальтат конвертации по выбранному курсу. (AZN, RUB, EURO, USD)
        char currency = default;
        decimal money = default;
        char convertingCurrency = default;

        decimal AZNtoRub = 46.7566m;
        decimal AZNtoEURO = 0.53274m;
        decimal AZNtoUSD = 0.58823m;
        decimal RUBtoEURO = 0.01138m;
        decimal RUBtoUSD = 0.01257m;
        decimal EUROtoUSD = 1.104m;

        do
        {
            Console.WriteLine("Input the currency of your money: \n1.AZN\n2.RUB\n3.EURO\n4.USD");
            currency = Convert.ToChar(Console.ReadLine());
        } while (currency != '1' && currency != '2' && currency != '3' && currency != '1');

        Console.Write("Input amount of money: ");
        money = Convert.ToDecimal(Console.ReadLine());


        if (currency == '1')
        {
            do
            {
                Console.WriteLine("Input the currency you want your money to convert to: \n1.RUB\n2.EURO\n3.USD");
                convertingCurrency = Convert.ToChar(Console.ReadLine());
            } while (convertingCurrency != '1' && convertingCurrency != '2' && convertingCurrency != '3');

            if (convertingCurrency == '1')
                money = money * AZNtoRub;
            else if (convertingCurrency == '2')
                money = money * AZNtoEURO;
            else if (convertingCurrency == '3')
                money = money * AZNtoUSD;
        }
        else if (currency == '2')
        {
            do
            {
                Console.WriteLine("Input the currency of your money: \n1.AZN\n2.EURO\n3.USD");
                convertingCurrency = Convert.ToChar(Console.ReadLine());
            } while (convertingCurrency != '1' && convertingCurrency != '2' && convertingCurrency != '3');

            if (convertingCurrency == '1')
                money = money / AZNtoRub;
            else if (convertingCurrency == '2')
                money = money * RUBtoEURO;
            else if (convertingCurrency == '3')
                money = money * RUBtoUSD;
        }
        else if (currency == '3')
        {
            do
            {
                Console.WriteLine("Input the currency of your money: \n1.AZN\n2.RUB\n3.USD");
                convertingCurrency = Convert.ToChar(Console.ReadLine());
            } while (convertingCurrency != '1' && convertingCurrency != '2' && convertingCurrency != '3');

            if (convertingCurrency == '1')
                money = money / AZNtoEURO;
            else if (convertingCurrency == '2')
                money = money / RUBtoEURO;
            else if (convertingCurrency == '3')
                money = money * EUROtoUSD;
        }
        else if (currency == '4')
        {
            do
            {
                Console.WriteLine("Input the currency of your money: \n1.AZN\n2.RUB\n3.EURO");
                convertingCurrency = Convert.ToChar(Console.ReadLine());
            } while (convertingCurrency != '1' && convertingCurrency != '2' && convertingCurrency != '3');

            if (convertingCurrency == '1')
                money = money / AZNtoUSD;
            else if (convertingCurrency == '2')
                money = money / RUBtoUSD;
            else if (convertingCurrency == '3')
                money = money / EUROtoUSD;
        }

        Console.WriteLine($"Your money is: {money}");
    }
}