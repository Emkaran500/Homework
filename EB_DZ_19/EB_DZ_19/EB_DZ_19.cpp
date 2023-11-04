#include <iostream>
#include "SwapMethod.h"
#include "ChangeMoney.h"
#include "ByteData.h"

using namespace std;

int main()
{
	//1.
	int var1 = 13;
	int var2 = 25;
	int* ptrvar1 = &var1;
	int* ptrvar2 = &var2;

	SwapMethod(ptrvar1, ptrvar2);

	cout << var1 << " " << var2 << endl;

	//2.
	double money = 0;
	double* ptrmoney = &money;
	char action;
	cout << "Input an action you want to perform on your purse (+/-): ", cin >> action;
	int adding = 0;
	//double adding = 0;
	cout << "Input the amount of money you want your current sum to change: ", cin >> adding;

	ChangeMoney(ptrmoney, action, adding);

	cout << money << endl;

	//3.
	int random = 124253;
	int* ptrrandom = &random;

	ByteData(ptrrandom);
}
