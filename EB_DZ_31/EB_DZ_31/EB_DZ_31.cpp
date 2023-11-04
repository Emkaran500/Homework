#include <iostream>
#include <conio.h>

using namespace std;

class Hero
{
public:
	string name;
	int attack;
	int defense;
	int hp;
	int xray = 0;

	Hero(const char* name, int attack, int defense, int hp)
	{
		this->name = name;
		this->attack = attack;
		this->defense = defense;
		this->hp = hp;
	}

	Hero operator - (Hero& hero2)
	{
		int num = rand() % 100;
		if (num > hero2.defense)
			hero2.hp = hero2.hp - this->attack;
		return hero2;
	}

	Hero operator ++ ()
	{
		if (this->hp + 15 >= 100)
			this->hp = 100;
		else
			this->hp = this->hp + 15;
		return *this;
	}

	Hero operator -- ()
	{
		this->hp = this->hp - 15;
		return *this;
	}

	Hero operator / (Hero& hero2)
	{
		int num = rand() % 100;
		if (num > hero2.defense)
				hero2.hp = hero2.hp - (this->attack * 3);
		return hero2;
	}

	static void Battle(Hero& hero1, Hero& hero2)
	{
		int count = 1;
		bool isNotOver = true;
		while (isNotOver)
		{
			isNotOver = Menu(hero1, hero2, count);
			cout << "Player1 hp: " << hero1.hp << endl;
			cout << "Player2 hp: " << hero2.hp << "\n\n";
		}

		if (hero1.hp <= 0)
			GameOver(hero1);
		else
			GameOver(hero2);
	}

	static bool Menu(Hero& hero1, Hero& hero2, int& count)
	{
		int get = 0;
		while (get != '1' && get != '2' && get != '3' && get != '4')
			if (count % 2 != 0)
			{
				cout << "-------------------------" << "\n\n";
				cout << "Player1 turn" << endl;
				cout << "Choose your move:" << endl;
				cout << "1. Attack (for " << hero2.attack << " hp)" << endl;
				cout << "2. To heal (for 15 hp)" << endl;
				cout << "3. To damage yourself (Idk why would you do this)" << endl;
				if (hero1.xray >= 100)
					cout << "4. Xray (for triple the attack)" << endl;
				get = _getch();
				if (get == '4' && hero1.xray < 100)
				{
					cout << "You cannot use xray right now!";
					get = 0;
				}
			}
			else
			{
				cout << "Player2 turn" << endl;
				cout << "Choose your move:" << endl;
				cout << "1. Attack (for " << hero2.attack << " hp)" << endl;
				cout << "2. To heal (for 15 hp)" << endl;
				cout << "3. To damage yourself (Idk why would you do this)" << endl;
				if (hero2.xray >= 100)
					cout << "4. Xray (for triple the attack)" << endl;
				get = _getch();
				if (get == '4' && hero2.xray < 100)
				{
					cout << "You cannot use xray right now!";
					get = 0;
				}
			}

		switch (get)
		{
		case '1':
			Attack(hero1, hero2, count);
			break;
		case '2':
			Heal(hero1, hero2, count);
			break;
		case '3':
			DamageYourself(hero1, hero2, count);
			break;
		case '4':
			Xray(hero1, hero2, count);
			break;
		default:
			break;
		}

		if (hero1.hp <= 0 || hero2.hp <= 0)
			return false;
		else
			return true;
	}

	static void Attack(Hero& hero1, Hero& hero2, int& count)
	{
		if (count % 2 != 0)
		{
			hero1 - hero2;
			hero1.xray += 30;
			hero2.xray += 40;
		}
		else
		{
			hero2 - hero1;
			hero2.xray += 30;
			hero1.xray += 40;
		}

		count++;
	}

	static void Heal(Hero& hero1, Hero& hero2, int& count)
	{
		if (count % 2 != 0)
			++hero1;
		else
			++hero2;

		count++;
	}

	static void DamageYourself(Hero& hero1, Hero& hero2, int& count)
	{
		if (count % 2 != 0)
			--hero1;
		else
			--hero2;

		count++;
	}

	static void Xray(Hero& hero1, Hero& hero2, int& count)
	{
		if (count % 2 != 0)
		{
			hero1 / hero2;
			hero1.xray = 0;
		}
		else
		{
			hero2 / hero1;
			hero2.xray = 0;
		}

		count++;
	}

	static void GameOver(Hero hero)
	{
		cout << hero.name << " has died, you won!" << endl;
	}
};


int main()
{
	srand(time(0));
	Hero Scorpion = { "Scorpion", 20, 25, 100 };
	Hero KungLao = { "Kung Lao", 25, 20, 100 };

	Hero::Battle(Scorpion, KungLao);
}