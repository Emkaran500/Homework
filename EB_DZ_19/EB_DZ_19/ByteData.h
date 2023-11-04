#pragma once

using namespace std;

template<typename T>
void ByteData(T* ptr)
{
	for (int i = 0; i < sizeof(T); i++)
	{
		cout << *((bool*)ptr + i) << " ";
	}
}