#include <iostream>

using namespace std;

int main()
{
	//Пользователь вводит 3 числа, выводится наибольшее из них.
	float bigNum1 = 0;
	float bigNum2 = 0;
	float bigNum3 = 0;
	cout << "Input the first number: ", cin >> bigNum1;
	cout << "Input the second number: ",cin >> bigNum2;
	cout << "Input the third number: ",cin >> bigNum3;
	if (bigNum1 >= bigNum2 and bigNum1 >= bigNum3)
	{
		cout << "Num1 is the biggest: " << bigNum1 << endl;
	}
	else if (bigNum2 >= bigNum3)
	{
		cout << "Num2 is the biggest: " << bigNum2 << endl;
	}
	else
	{
		cout << "Num3 is the biggest: " << bigNum3 << endl;
	}

	//Пользователь вводит 3 числа, считается их среднее арифметическое.
	float midNum1 = 0;
	float midNum2 = 0;
	float midNum3 = 0;
	float midAv = 0;
	cout << "Input the first number: ", cin >> midNum1;
	cout << "Input the second number: ", cin >> midNum2;
	cout << "Input the third number: ", cin >> midNum3;
	midAv = (midNum1 + midNum2 + midNum3) / 3;
	cout << "Average is: " << midAv << endl;

	//Пользователь вводит число и процент, выводится процент от числа.
	float percNum = 0;
	float percent = 0;
	float percOfNum = 0;
	cout << "Input number: ", cin >> percNum;
	cout << "Input percent: ", cin >> percent;
	percOfNum = (percNum * percent) / 100;
	cout << "Percentage of your number is: " << percOfNum << endl;

	//Пользователь вводит символ, проверить является ли он английской буквой.
	char symb1;
	cout << "Input your symbol: ", cin >> symb1;
	if ((int(symb1) >= 65 and int(symb1) <= 90) or (int(symb1) >= 97 and int(symb1) <= 122))
	{
		cout << "Your symbol is in english alphabet." << endl;
	}
	else
	{
		cout << "Your symbol is not in english alphabet." << endl;
	}

	//Пользователь вводит символ, проверить является ли он числом.
	char symb2;
	cout << "Input your symbol:", cin >> symb2;
	if (int(symb2) >= 48 and int(symb2) <= 57)
	{
		cout << "Your symbol is a number.";
	}
	else
	{
		cout << "Your symbol is not a number.";
	}
}