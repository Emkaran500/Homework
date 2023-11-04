#include <iostream>

using namespace std;

int main()
{
	//1. Triangles
	int x = 0;
	int y = 0;
	int range = 0;
	int limit = 1;
	cout << "Input x axis: ", cin >> x;
	cout << "Input y axis: ", cin >> y;
	cout << "Input range: ", cin >> range;
	int var = range;

	if (x > 0 && y > 0)
	{
		for (range; range > 0; range--)
		{
			for (int i = 0; i <= limit && limit <= var; i++)
			{
				cout << ((i == limit) ? "\n" : "*");
			}
			limit++;
		}
	}
	else if (x > 0 && y < 0)
	{
		for (range; range > 0; range--)
		{
			for (int i = var + 1; i >= limit && limit <= var; i--)
			{
				cout << ((i == limit) ? "\n" : "*");
			}
			limit++;
		}
	}
	else if (x < 0 && y > 0)
	{
		limit = range;
		for (range; range > 0; range--)
		{
			for (int i = 1; i <= var; i++)
			{
				cout << ((i < limit) ? " " : "*");
			}
			limit--;
			cout << endl;
		}
	}
	else if (x < 0 && y < 0)
	{
		for (range; range > 0; range--)
		{
			for (int i = 1; i <= var; i++)
			{
				cout << ((i < limit) ? " " : "*");
			}
			limit++;
			cout << endl;
		}
	}
	else
	{
		cout << "x and y can not be 0!";
	}

	//2. Half rhombus
	int range2 = 0;
	cout << "Input your range: ", cin >> range2;
	int var2 = range2;
	int limit2 = 1;
	if (limit2 <= range2)
	{
		for (range2; range2 > -1; range2--)
		{
			for (int i = 0; i <= limit2 && limit2 <= var2 + 1; i++)
			{
				cout << ((i == limit2) ? "\n" : "*");
			}
			limit2++;
		}
		range2 = var2;
		limit2 = 1;
		for (range2; range2 > 0; range2--)
		{
			for (int i = var2 + 1; i >= limit2 && limit2 <= var2; i--)
			{
				cout << ((i == limit2) ? "\n" : "*");
			}
			limit2++;
		}
	}

	//3. 5, 45, 345, 2345, 12345
	int range3 = 0;
	cout << "Input your range: ", cin >> range3;
	int num = range3;
	int ranging = range3;
	int limit3 = 0;

	for (range3; range3 > 0; range3--)
	{
		for (num; num <= ranging; num++)
		{
			cout << num;
		}
		limit3++;
		num -= limit3 + 1;
		cout << endl;
	}

	//4. 1 212 32123 4321234 543212345
	int range4 = 0;
	cout << "Input your range: ", cin >> range4;
	int ranging2 = range4;
	int num2 = range4;
	int limit4 = 1;
	int relimit = limit4;

	for (range4; range4 > 0; range4--)
	{
		for (num2; num2 >= 1; num2--)
		{
			if (num2 > limit4)
			{
				cout << " ";
			}
			else
			{
				cout << num2;
			}
		}
		relimit = limit4;
		num2 = ranging2;
		for (limit4; limit4 > 1; limit4--)
		{
			cout << limit4;
		}
		limit4 = relimit;
		limit4++;
		cout << endl;
	}

	//5. 5 555 55555 ...
	int range5 = 0;
	cout << "Input your range: ", cin >> range5;
	int numm = range5;
	int ranging3 = range5;
	int num3 = range5;
	int limit5 = 1;
	int relimit2 = limit5;
	int decline = 0;

	for (range5; range5 > 0; range5--)
	{
		for (num3; num3 >= 1; num3--)
		{
			if (num3 > limit5)
			{
				cout << " ";
			}
			else
			{
				cout << numm;
			}
		}
		relimit2 = limit5;
		num3 = ranging3;
		for (limit5; limit5 > 1; limit5--)
		{
			cout << numm;
		}
		limit5 = relimit2;
		limit5++;
		cout << endl;
	}
	range5 = ranging3;
	limit5 = 1;
	for (range5; range5 > 0; range5--)
	{
		for (num3; num3 >= limit5; num3--)
		{
			if (num3 >= (6 - decline))
			{
				cout << " ";
			}
			else
			{
				cout << numm;
			}
		}
		decline++;
		limit5 = relimit2;
		for (limit5; limit5 > 1; limit5--)
		{
			cout << numm;
		}
		num3 = ranging3;
		relimit2--;
		cout << endl;
	}

	//6. ...
	int range6 = 0;
	cout << "Input your range: ", cin >> range6;
	int ranging4 = range6;
	int limit6 = 1;
	int dlimit = 1;
	int var3 = range6;

	limit6 = range6;
	for (range6; range6 > 0; range6--)
	{
		for (int i = 1; i <= var3; i++)
		{
			cout << ((i < limit6) ? " " : "*");
		}
		limit6--;

		cout << " ";

		for (int j = 0; j <= dlimit && dlimit <= var3; j++)
		{
			cout << ((j == dlimit) ? "\n" : "*");
		}
		dlimit++;
	}
	cout << endl;

	range6 = ranging4;
	dlimit = 1;
	limit6 = 1;
	for (range6; range6 > 0; range6--)
	{
		for (int i = 1; i <= var3; i++)
		{
			cout << ((i < dlimit) ? " " : "*");
		}
		dlimit++;

		cout << " ";

		for (int i = var3 + 1; i >= limit6 && limit6 <= var3; i--)
		{
			cout << ((i == limit6) ? "\n" : "*");
		}
		limit6++;
	}
}
