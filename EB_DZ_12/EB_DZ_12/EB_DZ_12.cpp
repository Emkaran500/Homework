
#include <iostream>

using namespace std;

int main()
{
    // Вводится кол-во дней. Выводится информация ввиде "х лет у дней"
    int days = 0;
    cout << "Input the amount of days: ", cin >> days;
    int years = days / 365;
    int daysInYears = days - (years * 365);
    cout << years << " years " << daysInYears << " days." << endl;

    //Вводятся деньги в формате хх.уу. Выводится хх usd уу cent
    float money = 0;
    cout << "Input your money: ", cin >> money;
    int intPart = money;
    int fracPart = (money - int(money))*100;
    cout << intPart << " usd " << fracPart << " cent." << endl;

    //Вводятся AZN, выводятся USD.
    float AZN = 0;
    float USD = 0;
    cout << "Input your money you want to convert: ", cin >> AZN;
    USD = AZN * 1.7;
    cout << "Your money in USD is: " << USD << endl;
}
