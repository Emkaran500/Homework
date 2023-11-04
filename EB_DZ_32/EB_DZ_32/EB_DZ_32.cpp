#include <iostream>
#include <conio.h>
#include <string>
#include <vector>
#include <list>
#include <map>
#define ABSENT 18446744073709551615

using namespace std;

const string ISTEACHER[2] = { "False", "True" };

class User
{
public:
	string ID;
	string email;
	string name;
	string surname;
	bool isTeacher;
	string Teacher;

	User(string name, string surname, string email, bool isTeacher)
	{
		bool correct = false;
		while (!correct)
		{
			this->email = CheckEmail(email, correct);

			if (correct == false)
				cin >> email;
		}
		this->ID = CreateID(isTeacher);
		this->name = name;
		this->surname = surname;
		this->Teacher = ISTEACHER[(int)isTeacher];
		this->isTeacher = isTeacher;
	}

	User() {}

	string CheckEmail(string email, bool& correct)
	{
		if (email.find("@") == ABSENT && email.find(".") == ABSENT && email.find("@") < 1 && email.find(".") < (email.find("@") + 1))
		{
			cout << "Your email is incorrect, please reenter your email.";
			return "";
		}

		correct = true;
		return email;
	}

	string CreateID(bool isTeacher)
	{
		string ID;
		int base = 100000;
		if (isTeacher)
		{
			base = 200000;
		}

		base += rand();

		ID = to_string(base);
		return ID;
	}

	string GetName()
	{
		return this->name;
	}

	string GetSurname()
	{
		return this->surname;
	}

	string GetEmail()
	{
		return this->email;
	}

	string GetTeacherInfo()
	{
		return this->Teacher;
	}

	string GetID()
	{
		return this->ID;
	}

	void SetName(string name)
	{
		this->name = name;
	}

	void SetSurname(string surname)
	{
		this->surname = surname;
	}

	void SetEmail(string email)
	{
		this->email = email;
	}
};

ostream& operator << (ostream& out, User user)
{
	cout << "Name: " << user.GetName() << endl;
	cout << "Surname: " << user.GetSurname() << endl;
	cout << "email: " << user.GetEmail() << endl;
	cout << "ID: " << user.GetID() << endl;
	cout << "Is Teacher: " << user.GetTeacherInfo() << endl;

	return out;
}

struct Group
{
	int length = 0;
	string nameOfGroup = "";
	bool hasATeacher = false;
	User* users = new User[length]{};

	Group() {}

	Group(string name)
	{
		this->nameOfGroup = name;
	}

	void AddUserToGroup(User user)
	{
		if (hasATeacher == true && user.isTeacher == true)
		{
			throw "This Group already has a teacher.";
		}
		this->length++;

		User* newUsers = new User[this->length];
		newUsers[0] = user;

		for (int i = 1, j = 0; i < this->length; i++, j++)
		{
			newUsers[i] = this->users[j];
		}
		this->users = newUsers;

		delete[] newUsers;
	}

	void DeleteUserFromGroup(string ID)
	{
		if (this->length <= 0)
		{
			throw "This group already has no participants.";
		}

		int index = -1;
		for (int i = 0; i < this->length; i++)
		{
			if (this->users[i].ID == ID)
				index = i;
		}

		if (index == -1)
		{
			throw "There is no such User.";
		}
		this->length--;
		User* newUsers = new User[this->length];

		for (int i = 0, j = 0; j < (this->length + 1); j++, i++)
		{
			if (j != index)
				newUsers[i] = this->users[j];
			else
				i--;
		}

		this->users = newUsers;

		delete[] newUsers;
	}

	void ChangeNameOfGroup(string name)
	{
		this->nameOfGroup = name;
	}

	string GetName()
	{
		return this->nameOfGroup;
	}

	bool GetATeacher()
	{
		return this->hasATeacher;
	}

	void SetNameOfGroup(string nameOfGroup)
	{
		this->nameOfGroup = nameOfGroup;
	}
};

ostream& operator << (ostream& out, Group group)
{
	cout << "Name of group: " << group.GetName() << endl;
	cout << "Has a teacher in it: " << group.GetATeacher() << endl;
	cout << "Students in it: " << endl;
	for (int i = 0; i < group.length; i++)
	{
		cout << i+1 << ". " << group.users->GetName() << " " << group.users->GetSurname() << endl;
	}

	return out;
}

map<string, User> Users = map<string, User>();
map<string, Group> Teams = map<string, Group>();


void CreateUser()
{
	string name;
	string surname;
	string email;
	bool isTeacher;
	char chosenTeacher = ' ';

	cout << "Input the name: ", cin >> name;
	cout << "Input surname: ", cin >> surname;
	cout << "Input email: ", cin >> email;
	while (chosenTeacher != '0' && chosenTeacher != '1')
	{
		cout << "Input if he is a teacher: (0 or 1)", cin >> chosenTeacher;
	}
	isTeacher = int(chosenTeacher - char('0'));
	User user = User(name, surname, email, isTeacher);
	Users.insert(pair<string, User>(user.ID, user));
}

void DeleteUser()
{
	for (auto item : Users)
	{
		cout << Users.find(item.first)->second << endl;
	}

	string chosenID = "";

	while (chosenID == "" && chosenID != "1")
	{
		cout << "Input ID of a student you want to delete, or input \"1\" to exit:", cin >> chosenID;
	}

	int count = 0;

	for (auto item : Users)
	{
		if (Users.find(item.first)->second.ID == chosenID)
			count++;
	}

	if (count == 0)
		return;

	switch (stoi(chosenID))
	{
	case 1:
		return;
	default:
		Users.erase(chosenID);
		break;
	}
}


void EditExistingUser(string chosenID)
{
	User user = User();
	User* users = &user;

	for (auto item : Users)
	{
		if (Users.find(item.first)->second.ID == chosenID)
			users = &item.second;
			cout << *users << endl;
	}
	string editing;

	while (editing != "1" && editing != "2" && editing != "3")
	{
		cout << "Choose the setting you want to change:" << endl;
		cout << "1. Name \n2. Surname\n3. email" << endl;
		cin >> editing;
	}
	string newInfo = "";

	switch (stoi(editing))
	{
	case 1:
		while (newInfo == "")
		{
			cout << "Input new name: ", cin >> newInfo;
		}
		users->SetName(newInfo);
		break;
	case 2:
		while (newInfo == "")
		{
			cout << "Input new surname: ", cin >> newInfo;
		}
		users->SetSurname(newInfo);
		break;
	case 3:
		while (newInfo == "" || newInfo.find("@") == ABSENT && newInfo.find(".") == ABSENT && newInfo.find("@") < 1 && newInfo.find(".") < (newInfo.find("@") + 1))
		{
			cout << "Input new email: ", cin >> newInfo;
		}
		users->SetEmail(newInfo);
		break;
	}
}

void EditUser()
{
	for (auto item : Users)
	{
		cout << Users.find(item.first)->second << endl;
	}

	string chosenID = "";

	while (chosenID == "" && chosenID != "1")
	{
		cout << "Input ID of a student you want to edit, or input \"1\" to exit:", cin >> chosenID;
	}

	int count = 0;

	for (auto item : Users)
	{
		if (Users.find(item.first)->second.ID == chosenID)
			count++;
	}

	if (count == 0)
		return;

	switch (stoi(chosenID))
	{
	case 1:
		return;
	default:
		EditExistingUser(chosenID);
		break;
	}
}


void CreateGroup()
{
	string nameOfGroup = "";

	while (nameOfGroup == "" && nameOfGroup != "1")
	{
		cout << "Input name of new group or \"1\" to exit.", cin >> nameOfGroup;
	}

	if (nameOfGroup == "1")
		return;

	Teams.insert(pair<string, Group>(nameOfGroup, Group(nameOfGroup)));
}


void EditExistingGroup(string chosenGroupName)
{
	Group gr = Group();
	Group* group = &gr;

	for (auto item : Teams)
	{
		if (Teams.find(item.first)->second.nameOfGroup == chosenGroupName)
			group = &item.second;
		cout << group << endl;
	}
	string editing;

	while (editing != "1" && editing != "2" && editing != "3")
	{
		cout << "Choose the setting you want to change:" << endl;
		cout << "1. Name of group \n2. Add student\n3. Delete Student" << endl;
		cin >> editing;
	}
	string newInfo = "";

	switch (stoi(editing))
	{
	case 1:
		while (newInfo == "")
		{
			cout << "Input new name of group: ", cin >> newInfo;
		}
		group->SetNameOfGroup(newInfo);
		break;
	case 2:
		newInfo = "";
		for (auto item : Users)
		{
			cout << Users.find(item.first)->second << endl;
		}

		while (true)
		{
			cout << "Input ID of a user you want to add.", cin >> newInfo;
			for (auto item : Users)
			{
				if (Users.find(item.first)->second.ID == newInfo)
					group->AddUserToGroup(item.second);
			}
		}
		break;
	case 3:
		int numOfStudent = 0;
		while (numOfStudent <= 0 && numOfStudent >= group->length)
		{
			cout << "Choose the student you want to delete: ", cin >> numOfStudent;
		}

		group->DeleteUserFromGroup(group->users[numOfStudent + 1].ID);
		break;
	}
}

void EditGroup()
{
	string chosenGroupName = "";

	for (auto item : Teams)
	{
		cout << Teams.find(item.first)->second << endl;
	}

	while (chosenGroupName == "")
	{
		cout << "Input name of the group you want to edit: ", cin >> chosenGroupName;
	}

	for (auto item : Teams)
	{
		if (Teams.find(chosenGroupName) == Teams.end())
			return;
	}

	EditExistingGroup(chosenGroupName);
}

void GroupsSubMenu()
{
	char groupsChoice = ' ';

	while (groupsChoice != '1' && groupsChoice != '2')
	{
		cout << "1. Add new group." << endl;
		cout << "2. Edit existing group." << endl;
	}

	switch (groupsChoice)
	{
	case '1':
		CreateGroup();
		break;
	case '2':
		EditGroup();
		break;
	}
}

void UsersSubMenu()
{
	char usersChoice = ' ';
	while (usersChoice != '1' && usersChoice != '2' && usersChoice != '3')
	{
		cout << "\n\n";
		cout << "1. Add user to tab." << endl;
		cout << "2. Delete user from tab." << endl;
		cout << "3. Edit user." << endl;
		cin >> usersChoice;
	}

	if (usersChoice == '1')
		CreateUser();
	else if (usersChoice == '2')
		DeleteUser();
	else
		EditUser();
}

void Menu()
{
	char choice = ' ';

	while (choice != '1' && choice != '2' && choice != '3')
	{
		cout << "\n";
		cout << "-------------------------------------ACADEMY APP-------------------------------------";
		cout << "\n" << "Choose the prefered option:" << endl;
		cout << "1. Tab of Users." << endl;
		cout << "2. Academy groups." << endl;
		cout << "3. Exit." << endl;
		choice = _getch();
	}

	switch (choice)
	{
	case '1':
		UsersSubMenu();
		break;
	case '2':
		GroupsSubMenu();
		break;
	case '3':
		exit(0);
	default:
		break;
	}
}


int main()
{
	srand(time(0));
	while (true)
		Menu();
}