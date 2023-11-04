#include <iostream>

using namespace std;

template<typename T>
T* AddElementByIndex(T* arr, int& length, const int index, T newEl)
{
	if (length <= 0 || index > length || index < 0)
	{
		throw "Error";
	}

	length++;
	T* newArr = new T[length]{};

	for (int i = 0, j = 0; i < length; i++)
	{
		if (i != index)
		{
			newArr[i] = arr[j];
			j++;
		}
		else
		{
			newArr[i] = newEl;
		}
	}
	delete[] arr;

	return newArr;
}

template<typename T>
T* AddElement(T* arr, int& length, T newEl, bool front)
{
	if (length <= 0)
	{
		throw "Error";
	}

	length++;
	T* newArr = new T[length]{};

	int checkLength = length;
	bool notPassedFront = true;
	bool notPassedBack = true;

	for (int i = 0, j = 0; i < checkLength; i++)
	{
		if (front && notPassedBack)
		{
			newArr[--checkLength] = newEl;
			notPassedBack = false;
		}
		else if (front != true && notPassedFront)
		{
			newArr[0] = newEl;
			i++;
			notPassedFront = false;
		}
		newArr[i] = arr[j];
		j++;
	}

	delete[] arr;

	for (int i = 0; i < length; i++)
	{
		cout << newArr[i];
	}

	return newArr;
}

template<typename T>
T* DeleteElementByIndex(T* arr, int& length, const int index)
{
	if (length <= 0 || index >= length || index < 0)
	{
		throw "Error";
	}

	length--;
	T* newArr = new T[length]{};

	for (int i = 0, j = 0; i < length; j++)
	{
		if (j == index)
		{
			continue;
		}
		else
		{
			newArr[i] = arr[j];
			i++;
		}
	}

	for (int i = 0; i < length; i++)
	{
		cout << newArr[i] << endl;
	}

	delete[] arr;

	return newArr;
}

template<typename T>
T* DeleteElement(T* arr, int& length, bool front)
{
	if (length <= 0)
	{
		throw "Error";
	}

	length--;
	T* newArr = new T[length]{};

	int checkLength = length;
	bool notPassedFront = true;

	for (int i = 0, j = 0; i < checkLength; i++)
	{
		if (front != true && notPassedFront)
		{
			j++;
			notPassedFront = false;
		}
		newArr[i] = arr[j];
		j++;
	}

	delete[] arr;

	return newArr;
}

template<typename T>
T* ReplaceAll(T* arr, const int length, T oldValue, T newValue)
{
	if (length <= 0)
	{
		throw "Error";
	}

	for (int i = 0; i < length; i++)
	{
		if (arr[i] == oldValue)
		{
			arr[i] = newValue;
		}
	}

	return arr;
}

template<typename T>
T* DeleteAll(T* arr, int& length, T value)
{
	if (length <= 0)
	{
		throw "Error";
	}

	for (int i = 0; i < length; i++)
	{
		if (arr[i] == value)
		{
			length--;
		}
	}

	T* newArr = new T[length];

	for (int i = 0,j = 0; i < length; i++)
	{
		if (arr[j] == value)
		{
			j++;
			newArr[i] = arr[j];
			j++;
		}
		else if (arr[j] != value)
		{
			newArr[i] = arr[j];
			j++;
		}
	}

	delete[] arr;

	return newArr;
}

template<typename T>
T* GetOdds(T* arr, int& length)
{
	if (length <= 0)
	{
		throw "Error";
	}

	for (int i = 0; i < length; i++)
	{
		if (arr[i] % 2 != 0)
		{
			length--;
		}
	}

	T* newArr = new T[length]{};

	for (int i = 0, j = 0; i < length; j++)
	{
		if (arr[j] % 2 == 0)
		{
			continue;
		}
		else
		{
			newArr[i] = arr[j];
			i++;
		}
	}

	delete[] arr;

	return newArr;
}

int main()
{
	//1.
	int length = 5;
	int* arr = new int[length]{};
	int index = 1;
	int newEl = 6;

	for (int j = 0; j < length; j++)
	{
		arr[j] = j + 1;
	}

	/*try
	{ 
		arr = AddElementByIndex(arr, length, index, newEl);
	}
	catch (const char* error)
	{
		cout << error;
	}*/

	//2.

	bool front = true;

	/*try
	{
		arr = AddElement(arr, length, newEl, front);
	}
	catch (const char* error)
	{
		cout << error;
	}*/

	//3.

	/*try
	{
		arr = DeleteElementByIndex(arr, length, index);
	}
	catch (const char* error)
	{
		cout << error;
	}*/

	//4.

	/*try
	{
		arr = DeleteElement(arr, length, front);
	}
	catch (const char* error)
	{
		cout << error;
	}*/

	//5.

	int oldValue = 1;
	int newValue = 9;

	/*try
	{
		arr = ReplaceAll(arr, length, oldValue, newValue);
	}
	catch (const char* error)
	{
		cout << error;
	}*/

	//6.

	int value = 2;

	/*try
	{
		arr = DeleteAll(arr, length, value);
	}
	catch (const char* error)
	{
		cout << error;
	}*/

	//7.

	/*try
	{
		arr = GetOdds(arr, length);
	}
	catch (const char* error)
	{
		cout << error;
	}*/
}
