#include <iostream>

using namespace std;

template<typename T>
class Vector
{
    int length = 0;
    T* arr = nullptr;

public:
    void AddElement(const T newEl, const bool toEnd)
    {
        this->length++;
        T* newArr = new T[this->length]{};

        if (this->arr == nullptr)
            newArr[0] = newEl;
        else
        {
            if (toEnd)
            {
                for (int i = 0; i < (this->length - 1); i++)
                {
                    newArr[i] = this->arr[i];
                }
                newArr[this->length - 1] = newEl;
            }
            else
            {
                newArr[0] = newEl;
                for (int j = 1; j < (this->length - 1); j++)
                {
                    newArr[j] = this->arr[j - 1];
                }
            }
        }

        this->arr = newArr;
    }

    void AddElement(const T newEl, const int index)
    {
        if (index < 0 || index > this->length)
            throw "Error";

        this->length++;
        T* newArr = new T[this->length]{};

        if (this->arr == nullptr)
            newArr[0] = newEl;
        else
        {
            for (int i = 0, j = 0; i < (this->length - 1); i++)
            {
                if (i == index)
                    newArr[i] = newEl;
                else
                {
                    newArr[i] = this->arr[j];
                    j++;
                }
            }
        }

        this->arr = newArr;
    }

    void RemoveElement(const bool last)
    {
        if (this->arr == nullptr || this->length <= 0)
            throw "Error";

        this->length--;
        T* newArr = new T[this->length]{};

        if (last)
        {
            for (int i = 0; i < this->length; i++)
            {
                newArr[i] = this->arr[i];
            }
        }
        else
        {
            for (int i = 0; i < this->length; i++)
            {
                newArr[i] = this->arr[i + 1];
            }
        }

        this->arr = newArr;
    }

    void RemoveElement(const int index)
    {
        if (index < 0 || index > (this->length - 1) || this->length <= 0)
            throw "Error";

        this->length--;
        T* newArr = new T[this->length]{};

        for (int i = 0, j = 0; i < this->length; j++)
        {
            if (j != index)
            {
                newArr[i] = this->arr[j];
                i++;
            }
        }

        this->arr = newArr;
    }

    void Clear()
    {
        this->length = 0;
        delete[] this->arr;
    }

    void Show()
    {
        for (int i = 0; i < (this->length); i++)
        {
            cout << i << ": " << this->arr[i] << endl;
        }
    }

    void Resize(const int size)
    {
        int oldLength = this->length;
        this->length = size;

        T* newArr = new T[this->length];
        for (int i = 0; i < this->length; i++)
        {
            while (i < oldLength)
            {
                newArr[i] = arr[i];
                i++;
            }

            newArr[i] = 0;
        }

        arr = newArr;
    }

    void Swap(const int index1, const int index2)
    {
        if (index1 < 0 || index1 > (this->length - 1) || index2 < 0 || index2 >(length - 1))
            throw "Error";

        T tmp = this->arr[index1];
        this->arr[index1] = this->arr[index2];
        this->arr[index2] = tmp;
    }

    T At(const int index)
    {
        if (this->length < 0 || index < 0 || index >(this->length - 1))
            throw "Error";

        return this->arr[index];
    }

    void Replace(const T oldValue, const T newValue)
    {
        if (this->length < 0)
            throw "Error";

        for (int i = 0; i < this->length; i++)
        {
            if (this->arr[i] == oldValue)
                this->arr[i] = newValue;
        }
    }
};

int main()
{
    Vector<int> arr = Vector<int>();

    //arr.AddElement(1, true);
    //arr.AddElement(2, true);
    //arr.AddElement(3, true);
    //arr.AddElement(4, true);
    //arr.AddElement(5, true);
    //arr.RemoveElement(1);
    //arr.Clear();
    //arr.Resize(10);
    //cout << arr.At(2);
    //arr.Replace(0, 9);
    //arr.Show();
}