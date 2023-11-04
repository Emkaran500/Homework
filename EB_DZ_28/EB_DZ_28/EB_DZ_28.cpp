#include <iostream>

using namespace std;

class Calculator
{
public:
    int Summator(int num1, int num2)
    {
        return num1 + num2;
    }

    int Raznost(int num1, int num2)
    {
        return num1 - num2;
    }

    double Deleniye(double num1, double num2)
    {
        return num1 / num2;
    }

    int Umnojeniye(int num1, int num2)
    {
        return num1 * num2;
    }

    int Stepen(int num1, int num2)
    {
        if (num2 > 0)
            return num1 * Stepen(num1, num2 - 1);
    }

    double Procent(double num1, double num2)
    {
        return (num1 * num2) / 100;
    }

    int Factorial(int num1)
    {
        if (num1 > 0)
            return num1 * Factorial(num1 - 1);
    }
};

int CreateNum(int& counter)
{
    int num;
    cout << "Input " << counter << " number: ", cin >> num;

    counter++;
    return num;
}


int main()
{
    Calculator operation = Calculator();
    int resultInt = 0;
    double resultDouble = 0;
    int counter = 1;
    int num1 = CreateNum(counter);
    int num2 = CreateNum(counter);

    //resultInt = operation.Summator(num1, num2);
    //resultInt = operation.Raznost(num1, num2);
    //result = operation.Deleniye(num1, num2);
    //resultInt = operation.Umnojeniye(num1, num2);
    //resultInt = operation.Stepen(num1, num2);
    //resultDouble = operation.Procent(num1, num2);
    //resultInt = operation.Factorial(num1);

    if (resultInt != 0)
        cout << "Result: " << resultInt << endl;
    else
        cout << "Result: " << resultDouble << endl;
}
