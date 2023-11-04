#include <iostream>

using namespace std;

char** AddStudent(char** students, int& studentLength, const char* name)
{
	if (studentLength < 0)
	{
		throw "Error";
	}

	int oldLength = 1;
	studentLength++;
	char** newStudents = new char*[studentLength]{};

	for (int i = 0, j = 0; i < studentLength; i++)
	{
		if (i >= oldLength)
		{
			newStudents[i] = students[j];
			j++;
		}
		else
		{
			newStudents[i] = (char*)name;
		}
	}

	if ((studentLength - 1) > 0)
	{
		delete[] students;
	}

	return newStudents;
}

char** DeleteStudent(char** students, int& length, const char* name)
{
	if (length < 0)
	{
		throw "Error";
	}

	for (int i = 0; i < length; i++)
	{
		if (students[i] == name)
		{
			length--;
			char** newStudents = new char*[length]{};

			for (int i = 0, j = 0; i < length; j++)
			{
				if (students[j] == name)
				{
					continue;
				}
				else
				{
					newStudents[i] = students[j];
					i++;
				}
			}

			if ((length - 1) > 0)
			{
				delete[] students;
			}

			return newStudents;
		}
		else
		{
			if (i == length - 1)
			{
				return students;
			}
		}
	}
}

int** AddMarkToStudent(char** students, int& nameLength, int** studentsMarks, int* studentMark, int& marksLength, int& markLength, int newMark, const char* name)
{
	for (int i = 0; i < nameLength; i++)
	{
		if (students[i] == name)
		{
			while (marksLength != i + 1)
			{
				marksLength++;
			}
			markLength++;
			int** marks = new int*[marksLength]{};

			for (int j = 0; j < markLength; j++)
			{
				if (j != markLength - 1)
				{
					continue;
				}
				else
				{
					studentMark[j] = newMark;
				}
			}

			marks[i] = studentMark;

			return marks;
		}
		else
		{
			return studentsMarks;
		}
	}
}

void ShowStudents(char** students, const int nameLength, int** studentsMarks, const int markLength)
{
	for (int i = 0; i < nameLength; i++)
	{
		cout << students[i] << ": ";
		for (int j = 0; j < markLength; j++)
		{
			cout << studentsMarks[i][j] << endl;
		}
	}
}

int main()
{
	int nameLength = 0;
	int marksLength = 0;
	int markLength = 0;
	int newMark = 5;
	char** students = new char*[nameLength]{};
	int* studentMark = new int[markLength]{};
	int** studentsMarks = new int* [marksLength] {};
	
	students = AddStudent(students, nameLength, "Teddy Roosevelt");

	students = AddStudent(students, nameLength, "Harry Potter");

	//students = DeleteStudent(students, nameLength, "Teddy Roosevelt");

	studentsMarks = AddMarkToStudent(students, nameLength, studentsMarks, studentMark, marksLength, markLength, newMark, "Harry Potter");
	studentsMarks = AddMarkToStudent(students, nameLength, studentsMarks, studentMark, marksLength, markLength, 10, "Harry Potter");

	ShowStudents(students, nameLength, studentsMarks, markLength);
}