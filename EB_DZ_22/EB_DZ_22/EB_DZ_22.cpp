#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;

void ShowTopThree(int arr[5][5], const int length1, const int length2)
{
	if (length1 * length2 < 3)
	{
		return;
	}

	int top1 = 0;
	int top2 = 0;
	int top3 = 0;

	for (int i = 0; i < length1; i++)
	{
		for (int j = 0; j < length2; j++)
		{
			if (top1 <= arr[i][j])
			{
				top3 = top2;
				top2 = top1;
				top1 = arr[i][j];
			}
		}
	}

	cout << "Top1: " << top1 << endl;
	cout << "Top2: " << top2 << endl;
	cout << "Top3: " << top3 << endl;
}

void PrintArr1(int arr[5][5], const int length1, const int length2)
{
	for (int i = 0; i < length1; i++)
	{
		for (int j = 0; j < length2; j++)
		{
			cout << arr[i][j] << " ";
		}
	}
	cout << endl;
}

void PrintArr2(int arr[5][5], const int length1, const int length2)
{
	for (int i = 0; i < length1; i++)
	{
		for (int j = 0; j < length2; j++)
		{
			cout << *(*(arr + i) + j) << " ";
		}
	}
	cout << endl;
}

char* StrCopy(char* symbol, char* copy, const int length)
{
	for (int i = 0; i < length; i++)
	{
		if (i >= length - 1)
		{
			symbol[i] = '\0';
		}
		else
		{
			symbol[i] = copy[i];
		}
	}

	return symbol;
}

char* StrCat(char* symbol, char* append, char* newsymb, const int length, const int oldlength1, const int oldlength2)
{
	for (int i = 0; i < oldlength1; i++)
	{
		if (symbol[i] == '\0')
		{
			for (int j = 0; j < oldlength2; i++, j++)
			{
				if (append[j] == '\0')
				{
					break;
				}
				else
				{
					newsymb[i] = append[j];
				}
			}
			break;
		}
		else
		{
			newsymb[i] = symbol[i];
		}
	}

	return newsymb;
}

void StrLen(char* symbol, const int length)
{
	int counter = 0;

	while (symbol[counter] != '\0')
	{
		counter++;
	}

	cout << counter << endl;
}

int main()
{
	//1.
	const int length1 = 5;
	const int length2 = 5;
	int arr[length1][length2]
	{
		{123,52,312,234,564},
		{5647,342,8097,534,54},
		{5364,534,342,564,423},
		{567,3412,567,5346,5087},
		{423,675342,675,342,756}
	};

	//ShowTopThree(arr, length1, length2);

	//2.
	//PrintArr1(arr, length1, length2);
	//PrintArr2(arr, length1, length2);

	//3.
	const int copylength1 = 40;
	const int copylength2 = 20;
	char symbol1[copylength1]{ "asdfasdfasf" };
	char copy1[copylength2]{ "gsdfsdd" };

	/*for (int i = 0; i < copylength2; i++)
	{
		cout << StrCopy(symbol1, copy1, copylength2)[i];
	}
	cout << endl;*/

	const int oldlength1 = 20;
	const int oldlength2 = 20;
	const int appendlength = oldlength1 + oldlength2;
	char symbol2[oldlength1]{ "reyfdhfd" };
	char append[oldlength2]{ "srzd6te" };
	char newsymb[appendlength]{};

	for (int i = 0; i < appendlength; i++)
	{
		cout << StrCat(symbol2, append, newsymb, appendlength, oldlength1, oldlength2)[i];
	}
	cout << endl;

	const int lenlength = 40;
	char symbol3[lenlength]{ "awrfsgfsfzsdf" };

	//StrLen(symbol3, lenlength);
}
