#include <iostream>

using namespace std;

template<typename T>
T* CreateArr(T* arr,const int length, const int dlina)
{
    if (length > dlina)
    {
        cout << "You cannot do that!";
        return nullptr;
    }
    for (int i = 0; i < length; i++)
    {
        arr[i] = i;
    }

    return arr;
}

int* CheckPoints(int* arr1, int* arr2, const int length1, const int length2)
{
    int counter1 = 0;
    int counter2 = 0;
    int truelength = 0;
    if (length1 >= length2)
        truelength = length1;
    else
        truelength = length2;

    for (int i = 0; i < truelength; i++)
    {
        if (arr1[i] > arr2[i])
        {
            counter1++;
        }
        else if (arr1[i] < arr2[i])
        {
            counter2++;
        }
    }
    counter2 = counter2 + (length2 - length1);

    if (counter1 > counter2)
        return arr1;
    else if (counter2 > counter1)
        return arr2;
    else
        return nullptr;
}

int main()
{
    //1.
    const int dlina = 10;
    int length;
    cout << "Input length of your arr: ", cin >> length;
    int arr[dlina];

    for (int i = 0; i < length; i++)
    {
        cout << CreateArr<int>(arr, length, dlina)[i] << " ";
    }
    
    //2.
    const int length1 = 10;
    const int length2 = 5;
    int arr1[length1]{3412,564234,564,342,654342,5643,342,56412,354,3412};
    int arr2[length2]{3645,342,6879,5342};

    CheckPoints(arr1, arr2, length1, length2);
}
