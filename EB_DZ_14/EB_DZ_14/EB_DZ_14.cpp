#include <iostream>

using namespace std;

int main()
{
	//1.Напишите программу, которая вычисляет сумму целых чисел от а до 500 (значение a вводится с клавиатуры)
	int numSum1 = 0;
	int numSum2 = 20;
	int result = 0;
	cout << "Input your number: ", cin >> numSum1;

	while (numSum1 <= 20 || (numSum1 - numSum2 >= 0))
	{
		if (numSum1 > 20)
		{
			result += numSum2;
			numSum2++;
		}
		else
		{
			result += numSum1;
			numSum1++;
		}
	}
	cout << result << endl;

	//2.Напишите программу, которая запрашивает два целых числа x и y, после чего вычисляет и выводит значение x в степени y
	int numGrade1 = 1;
	int numGrade2 = 0;
	int grade = 1;
	cout << "Input your number: ", cin >> numGrade1;
	cout << "Input power of your number: ", cin >> numGrade2;

	while (numGrade2 >= 1)
	{
		grade *= numGrade1;
		numGrade2--;
	}
	cout << grade << endl;

	//3.Найти произведение всех чётных чисел от a до b (значение a и b вводится с клавиатуры)
	int numMult1 = 1;
	int numMult2 = 1;
	int multi = 1;
	cout << "Input the first number: ", cin >> numMult1;
	cout << "Input the second number: ", cin >> numMult2;

	while (numMult1 <= numMult2)
	{
		if (numMult1 % 2 == 0)
		{
			multi *= numMult1;
			numMult1++;
		}
		else
		{
			numMult1++;
		}
	}
	cout << multi << endl;

	//4.Вывести на экран все простые числа от 0 до введённого пользователем числа
	int numPrime1 = 1;
	int limit = 1;
	cout << "Input your limit: ", cin >> numPrime1;
	int numPrime2 = numPrime1 - 1;

	while (numPrime1 > limit)
	{
		if (numPrime1 % numPrime2 == 0 && numPrime2 > 1)
		{
			numPrime1--;
		}
		else if (numPrime2 == 1)
		{
			cout << numPrime1 << endl;
			numPrime1--;
			numPrime2 = numPrime1 - 1;
		}
		else
		{
			numPrime2--;
		}
	}
}
