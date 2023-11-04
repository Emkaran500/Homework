using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_DZ_42;

public enum Direction
{
    Descending = 0,
    Ascending = 1,
}

public static class ArrExtensionMethods
{
    public static int[] Sort(this int[] intArr, Direction direction = Direction.Descending)
    {
        int iterations = 0;
        int[] newArr = intArr;

        if (direction == Direction.Descending)
        {
            do
            {
                iterations = 0;
                for (int i = 0; i < newArr.Length - 1; i++)
                {
                    if (newArr[i] < newArr[i + 1])
                    {
                        int tmp = newArr[i + 1];
                        newArr[i + 1] = newArr[i];
                        newArr[i] = tmp;
                        iterations++;
                    }
                }
            } while (iterations != 0);
        }
        else if (direction == Direction.Ascending)
        {
            do
            {
                iterations = 0;
                for (int i = 0; i < newArr.Length - 1; i++)
                {
                    if (newArr[i] > newArr[i + 1])
                    {
                        int tmp = newArr[i + 1];
                        newArr[i + 1] = newArr[i];
                        newArr[i] = tmp;
                        iterations++;
                    }
                }
            } while (iterations != 0);
        }

        intArr = newArr;

        return intArr;
    }

    public static bool FindValueInArray<T>(this T[]? arr, T valueToFind)
    {
        if (arr is null)
        {
            return false;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(valueToFind))
            {
                return true;
            }
        }

        return false;
    }

    public static bool FindValuesInArray<T>(this T[]? arr, params T[] valuesToFind)
    {
        if (arr is null)
        {
            return false;
        }

        int countOfFounded = 0;

        for (int i = 0; i < arr.Length && countOfFounded < valuesToFind.Length; i++)
        {
            if (arr[i].Equals(valuesToFind[countOfFounded]))
            {
                countOfFounded++;
            }
        }

        if (countOfFounded == (valuesToFind.Length))
            return true;

        return false;
    }

    public static T[] Plus<T>(this T[] arr, T[] anotherArr)
    {
        T[] newArr = new T[arr.Length + anotherArr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];

            if (i == arr.Length - 1)
            {
                for (int j = 0; j < anotherArr.Length; j++, i++)
                {
                    newArr[i + 1] = anotherArr[j];
                }
            }
        }

        arr = newArr;

        return arr;
    }

    public static T[] Get<T>(this T[] arr, Predicate<T> predicate)
    {
        int length = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (predicate.Invoke(arr[i]))
            {
                length++;
            }
        }

        T[] newArr = new T[length];

        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (predicate.Invoke(arr[i]))
            {
                newArr[j] = arr[i];
                j++;
            }
        }

        return newArr;
    }
}
