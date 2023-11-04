#include <iostream>

using namespace std;

template<typename T>
void PrintArr(T* arr, const int length)
{
	for (int i = 0; i < length; i++)
	{
		cout << arr[i] << " ";
	}
	cout << endl;
}

template<typename T>
void TurnArr(T* arr, const int length)
{
	for (int i = length - 1; i >= 0; i--)
	{
		cout << arr[i] << " ";
	}
	cout << endl;
}

void PrintEvenNumsOfArr(int* arr, const int length)
{
	for (int i = 0; i < length; i++)
	{
		if (arr[i] % 2 == 0)
		{
			cout << arr[i] << " ";
		}
	}
	cout << endl;
}

template<typename T>
T SumOfNumsOfArr(T* arr, const int length)
{
	int result = 0;

	for (int i = 0; i < length; i++)
	{
		result = result + arr[i];
	}

	return result;
}

template<typename T>
T FindTheMaxNumOfArr(T* arr, const int length)
{
	int max = arr[0];

	for (int i = 1; i < length; i++)
	{
		if (max < arr[i])
			max = arr[i];
	}

	return max;
}

int main()
{
	//1.
	const int length = 5;
	int arr[length]{ 1,2,3,4,5 };
	PrintArr(arr, length);

	//2.
	TurnArr(arr, length);

	//3.
	int numarr[length]{ 124,6332,5639,2537,34 };
	PrintEvenNumsOfArr(numarr, length);

	//4.
	cout << SumOfNumsOfArr(numarr, length) << endl;

	//5.
	cout << FindTheMaxNumOfArr(numarr, length);
}
