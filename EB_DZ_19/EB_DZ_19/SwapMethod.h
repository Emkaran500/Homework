#pragma once

template<typename T>
void SwapMethod(T* ptrvar1, T* ptrvar2)
{
	int temp;

	temp = *ptrvar1;
	*ptrvar1 = *ptrvar2;
	*ptrvar2 = temp;
}