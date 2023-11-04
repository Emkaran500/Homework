#pragma once

using namespace std;

template<typename T>
T SumNums(T num1, T num2)
{
	return num1 + num2;
}

template<typename T>
T SubtractNums(T num1, T num2)
{
	return num1 - num2;
}

template<typename T>
T MultiplyNums(T num1, T num2)
{
	return num1 * num2;
}

template<typename T>
T DivideNums(T num1, T num2)
{
	return num1 / num2;
}

int PercentNums(int num1, int num2)
{
	return num1 % num2;
}
