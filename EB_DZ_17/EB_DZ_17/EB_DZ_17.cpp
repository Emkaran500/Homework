#include <iostream>

using namespace std;

void CreateRectangle(int height, int width)
{
	if (height < 0 || width < 0)
	{
		cout << "Height or width cannot be less than 0!" << endl;
		return;
	}
	char symbol = '*';

	for (int i = 0; i < height; i++)
	{
		for (int j = 0; j < width; j++)
		{
			cout << symbol;
		}
		cout << endl;
	}
}

int Factorial(int num)
{
	if (num < 0)
	{
		return 0;
	}
	else if (num < 1)
	{
		return 1;
	}
	else
	{
		return num * Factorial(num - 1);
	}
}

char IsPrimeNum(int num)
{
	if (num <= 1)
	{
		cout << "Num cannot be less than 2!" << endl;
		return 'e';
	}

	int divider = num - 1;
	for (num, divider; divider >= 2; divider--)
	{
		if (num % divider == 0)
		{
			return 'f';
		}
	}
	return 't';
}

int CalculateCube(int num, const int cube)
{
	int result = num;

	for (int i = 1; i < cube; i++)
	{
		result = result * num;
	}

	return result;
}

int MaxCheck(const int num1, const int num2, const int num3)
{
	if (num1 >= num2)
	{
		if (num1 >= num3)
			return num1;
		else
			return num3;
	}
	else
	{
		if (num2 >= num3)
			return num2;
		else
			return num3;
	}
}

int main()
{
	//1.
	int height = 0;
	int width = 0;
	cout << "Input height of your rectangle: ", cin >> height;
	cout << "Input width of your rectangle: ", cin >> width;

	CreateRectangle(height, width);

	//2.
	int num = 0;
	cout << "Input number factorial of which you want to calculate: ", cin >> num;

	cout << Factorial(num) << endl;

	//3.
	int isprime = 0;
	cout << "Input number which you want to check if it's prime: ", cin >> isprime;

	cout << IsPrimeNum(isprime) << endl;

	//4.
	int degreenum = 0;
	const int cube = 3;
	cout << "Input number cube of which you want to calculate: ", cin >> degreenum;

	cout << CalculateCube(degreenum, cube) << endl;

	//5.
	int num1 = 0;
	int num2 = 0;
	int num3 = 0;
	cout << "Input 3 numbers that you want to check: " << endl;
	cout << "num1: ", cin >> num1;
	cout << "num2:", cin >> num2;
	cout << "num3: ", cin >> num3;

	cout << MaxCheck(num1, num2, num3) << endl;
}