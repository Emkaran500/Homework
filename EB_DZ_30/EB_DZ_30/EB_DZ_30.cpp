#include <iostream>

using namespace std;

struct String
{
    string str;

    String(const char* string) : str(string) {};

    String Replace(string oldValue, string newValue)
    {
        int counter = 0;
        char* newStr = new char[1000]{};

        for (int i = 0, k = 0, j = 0, l = 0, m = 0; i < (this->str.length()); )
        {
            for (i, j; (j < oldValue.length()) && (i < this->str.length()); i++, j++)
            {
                counter += (this->str[i] == oldValue[j]);
            }
            j = 0;

            if (counter == oldValue.length())
            {
                int killMe = m;

                for (m, k; m < (killMe + newValue.length()); m++, k++)
                {
                    newStr[m] = newValue[k];
                }

                k = 0;
            }
            else
            {
                l = i - oldValue.length();
                int def = l;
                for (m, l; l < (def + oldValue.length()); m++, l++)
                    newStr[m] = str[l];
            }
            counter = 0;
        }
        this->str = newStr;

        return *this;
    }

    static String Replace(String obj, string oldValue, string newValue)
    {
        int counter = 0;
        char* newStr = new char[1000]{};

        for (int i = 0, k = 0, j = 0, l = 0, m = 0; i < (obj.str.length()); )
        {
            for (i, j; (j < oldValue.length()) && (i < obj.str.length()); i++, j++)
            {
                counter += (obj.str[i] == oldValue[j]);
            }
            j = 0;

            if (counter == oldValue.length())
            {
                int killMe = m;

                for (m, k; m < (killMe + newValue.length()); m++, k++)
                {
                    newStr[m] = newValue[k];
                }

                k = 0;
            }
            else
            {
                l = i - oldValue.length();
                int def = l;
                for (m, l; l < (def + oldValue.length()); m++, l++)
                    newStr[m] = obj.str[l];
            }
            counter = 0;
        }
        obj.str = newStr;

        return obj;
    }

    int FirstIndex(char symb, bool first)
    {
        if (first)
        {
            for (int i = 0; i < this->str.length(); i++)
            {
                if (this->str[i] == symb)
                {
                    return i;
                }
            }
            return -1;
        }
        else
        {
            for (int i = (this->str.length() - 1); i >= 0; i--)
            {
                if (this->str[i] == symb)
                {
                    return i;
                }
            }
            return -1;
        }
    }

    static int FirstIndex(String obj, char symb, bool first)
    {
        if (first)
        {
            for (int i = 0; i < obj.str.length(); i++)
            {
                if (obj.str[i] == symb)
                {
                    return i;
                }
            }
            return -1;
        }
        else
        {
            for (int i = (obj.str.length() - 1); i >= 0; i--)
            {
                if (obj.str[i] == symb)
                {
                    return i;
                }
            }
            return -1;
        }
    }

    string* Split(char separator)
    {
        int length = 1;
        for (int i = 0; i < this->str.length(); i++)
        {
            if (this->str[i] == separator)
                length++;
        }

        string* stringArr = new string[length]{"                                           ", "                                           "};

        int j = 0;

        for (int k = 0, u = 0, counter = 0; k < length; k++)
        {
            for (j; j < this->str.length(); j++)
            {
                if (this->str[j] == separator )
                {
                    break;
                }
                counter++;
            }
            j++;

            for (int l = 0; l < counter; l++, u++)
            {
                stringArr[k][l] = this->str[u];

                if (l == (counter - 1))
                    stringArr[k][counter] = '\0';
            }
            u++;
            counter = 0;
        }

        return stringArr;
    }

    static string* Split(String obj, char separator)
    {
        int length = 1;
        for (int i = 0; i < obj.str.length(); i++)
        {
            if (obj.str[i] == separator)
                length++;
        }

        string* stringArr = new string[length]{ "                                           ", "                                           ", "                                           "};

        int j = 0;

        for (int k = 0, u = 0, counter = 0; k < length; k++)
        {
            for (j; j < obj.str.length(); j++)
            {
                if (obj.str[j] == separator)
                {
                    break;
                }
                counter++;
            }
            j++;

            for (int l = 0; l < counter; l++, u++)
            {
                stringArr[k][l] = obj.str[u];

                if (l == (counter - 1))
                    stringArr[k][counter] = '\0';
            }
            u++;
            counter = 0;
        }

        return stringArr;
    }
};

int main()
{
    /*String string = "qwerty sleeping";
    string.Replace("rty", "test");
    cout << string.str << endl;
    cout << String::Replace(String("qwertyqwertyqwerty"), "qw", "eut").str << endl;
    cout << string.FirstIndex('t', true) << endl;
    cout << String::FirstIndex(String("IamTired"), 'b', false) << endl;
    std::string* arr = string.Split(' ');
    std::string* arr2 = String::Split(String("abrakadabra"), 'r');*/

    /*for (int i = 0; i < 2; i++)
    {
        cout << arr[i] << endl;
    }*/

    /*for (int i = 0; i < 3; i++)
    {
        cout << arr2[i] << endl;
    }*/
}