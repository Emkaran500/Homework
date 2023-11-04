#include <iostream>
#include "calculator.h"


using namespace std;

int main()
{
	int num1 = 15;
	//int num2 = 10;
	//double num1 = 17.3;
	double num2 = 3.4;

	char symbol;
	cout << "Input preferable operation: ", cin >> symbol;

	if (symbol == '+')
	{
		cout << SumNums<double>(num1, num2);
	}
	else if (symbol == '-')
	{
		cout << SubtractNums<double>(num1, num2);
	}
	else if (symbol == '*')
	{
		cout << MultiplyNums<double>(num1, num2);
	}
	else if (symbol == '/')
	{
		cout << DivideNums<double>(num1, num2);
	}
	else if (symbol == '%')
	{
		if (sizeof(num1) == sizeof(double) || sizeof(num2) == sizeof(double))
		{
			cout << "You cannot find percent of double nums!";
			return 0;
		}
		cout << PercentNums(num1, num2);
	}
	else
	{
		cout << "There isn't such operation!";
	}
}
