#include <iostream>

using namespace std;

int main()
{
    //1.Напишите программу, которая вычисляет сумму целых чисел от а до 500 (значение a вводится с клавиатуры)(если а будет больше 500 - перевернуть цикл)
    int numSum1 = 0;
    int numSum2 = 0;
    int result = 0;
    cout << "Input your number: ", cin >> numSum1;
    numSum2 = numSum1;
    for (numSum1, numSum2; numSum1 <= 20 || numSum2 >= 20; )
    {
        if (numSum1 <= 20)
        {
            result += numSum1;
            numSum1++;
        }
        else
        {
            result += numSum2;
            numSum2--;
        }
    }
    cout << result << endl;

    //2.Напишите программу, которая запрашивает два целых числа x и y, после чего вычисляет и выводит значение x в степени y
    int numGrade1 = 1;
    int numGrade2 = 0;
    int grade = 1;
    cout << "Input your number: ", cin >> numGrade1;
    cout << "Input power of your number: ", cin >> numGrade2;

    for (numGrade1, numGrade2; numGrade2 >= 1; numGrade2--)
    {
        grade *= numGrade1;
    }
    cout << grade << endl;

    //3.Найти произведение всех чётных чисел от a до b(значение a и b вводится с клавиатуры)
    int numMult1 = 1;
    int numMult2 = 1;
    int multi = 1;
    cout << "Input the first number: ", cin >> numMult1;
    cout << "Input the second number: ", cin >> numMult2;

    for (numMult1, numMult2; numMult1 <= numMult2; numMult1++)
    {
        if (numMult1 % 2 == 0)
        {
            multi *= numMult1;
        }
    }
    cout << multi << endl;

    //4.Вывести на экран все простые числа от 0 до введённого пользователем числа
    int numPrime1 = 1;
    int limit = 1;
    cout << "Input your limit: ", cin >> numPrime1;
    int numPrime2 = numPrime1 - 1;

    for (numPrime1, numPrime2, limit; numPrime1 >= limit && numPrime2 > 0; numPrime2--)
    {
        if (numPrime2 == limit)
        {
            cout << numPrime1 << endl;
            numPrime1--;
            numPrime2 = numPrime1;
        }
        else if (numPrime1 % numPrime2 == 0)
        {
            numPrime1--;
        }
    }
}
