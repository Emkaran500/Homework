#pragma once

using namespace std;

template<typename T>
void ChangeMoney(double* ptrmoney, char action, T adding)
{
	if (action == '+')
	{
		*ptrmoney = *ptrmoney + adding;
	}
	else if (action == '-')
	{
		if (*ptrmoney < adding)
		{
			cout << "Your money cannot be less than 0!" << endl;
			return;
		}
		*ptrmoney = *ptrmoney - adding;
	}

}