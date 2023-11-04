class Program
{
    static void Main()
    {
        //Приложение требует пользователя ввести его серийный номер удостоверения личности
        //до тех пор, пока номер не пройдёт валидацию.

        string serialNumber = default;
        int numOfErrors = default;

        Console.Write("Please input your serial number: ");
        serialNumber = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(serialNumber))
        {
            Console.WriteLine("Error: Your serial number is empty!");
            numOfErrors++;
        }
        else if (serialNumber.Substring(0, 3).ToUpper() != "AZE" && serialNumber.Substring(0, 2).ToUpper() != "AA")
        {
            Console.WriteLine("Error: Your passport series is wrong!");
            numOfErrors++;
        }

        if (serialNumber.Length < 9)
        {
            Console.WriteLine("Error: Your serial number doesn't have enought symbols!");
            numOfErrors++;
        }
        else if (serialNumber.Substring(0, 3).ToUpper() == "AZE")
        {
            if (!int.TryParse(serialNumber.Substring(3, 6), out int result))
            {
                Console.WriteLine("Error: Your serial number is wrong after passport series!");
                numOfErrors++;
            }
        }
        else if (serialNumber.Substring(0, 2).ToUpper() == "AA")
        {
            if (serialNumber.Length < 9)
            {
                Console.WriteLine("Error: Your serial number doesn't have enought symbols!");
                numOfErrors++;
            }
            else if (!int.TryParse(serialNumber.Substring(2, 7), out int result))
            {
                Console.WriteLine("Error: Your serial number is wrong after passport series!");
                numOfErrors++;
            }
        }

        if (numOfErrors > 0)
            Console.WriteLine($"Number of errors occured: {numOfErrors}");
        else
            Console.WriteLine("Success!");
    }
}