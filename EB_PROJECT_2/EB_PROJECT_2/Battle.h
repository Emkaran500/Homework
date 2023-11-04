#pragma once
#define EVADED 100

int RunAway(Hero& hero, bool evaded)
{
	int* evasionChance = new int(rand() % 101);

	if (*evasionChance <= hero.evasion)
	{
		cout << "You successfully evaded an enemy!\n\n";
		evaded = true;

		cout << press;
		_getch();
	}
	else
	{
		cout << "You couldn't evade...\n\n";
		hero.health = hero.health - enemy.attack;

		cout << press;
		_getch();
	}

	return evaded;
}

void PlayerAttack(Hero hero, Enemies& enemy)
{
	int* missEvadeChance = new int(rand() % 101);
	int* missDefenseChance = new int(rand() % 101);

	if (*missEvadeChance > enemy.evasion && *missDefenseChance > enemy.defense)
	{
		cout << "You have hit enemy for " << hero.attack << " hp" << "\n\n";
		enemy.health = enemy.health - hero.attack;
	}
	else
	{
		if (*missEvadeChance <= enemy.evasion)
		{
			cout << "Enemy dodged the attack!" << "\n\n";
		}
		else if (*missDefenseChance <= enemy.defense)
		{
			cout << "Enemy blocked the attack!" << "\n\n";
		}
	}
}

void EnemyAttack(Hero& hero, Enemies enemy)
{
	int* missEvadeChance = new int(rand() % 101);
	int* missDefenseChance = new int(rand() % 101);

	if (*missEvadeChance > hero.evasion && *missDefenseChance > hero.defense)
	{
		cout << "You have been hit for " << enemy.attack << " hp" << "\n\n";
		hero.health = hero.health - enemy.attack;
	}
	else
	{
		if (*missEvadeChance <= hero.evasion)
		{
			cout << "You dodged the attack!" << "\n\n";
		}
		else if (*missDefenseChance <= hero.defense)
		{
			cout << "You blocked the attack!" << "\n\n";
		}
	}
}

int PlayerMenu(int round)
{
	bool evaded = false;
	int input = 0;
	cout << "Round: " << round << "\n\n";
	cout << "What would you do?" << endl;
	while (input < 1 || input > 4)
	{
		cout << "1. Attack\n" << "2. Show player's characteristics\n" << "3. Show enemy's characteristics\n" << "4. Run away (" << hero.evasion << "%)\n\n";
		input = (_getch() - ZERO);
		Sleep(50);
	}

	return input;
}

void PlayerTurn(int& input, int& round)
{
	bool evaded = false;
	x:
	if (evaded)
	{
		enemy.health = 0;
		input = EVADED;
	}
	else
	{
		switch (input)
		{
		case 1:
			PlayerAttack(hero, enemy);
			break;
		case 2:
			ShowCharacter(hero);
			input = PlayerMenu(round);
			goto x;
			break;
		case 3:
			ShowEnemy(enemy);
			input = PlayerMenu(round);
			goto x;
			break;
		case 4:
			evaded = RunAway(hero, evaded);
			input = PlayerMenu(round);
			goto x;
			break;
		case EVADED:
			return;
		default:
			break;
		}
	}
}

bool EndBattle(Hero hero)
{
	if (hero.health <= 0)
	{
		return false;
	}
	else
	{
		return true;
	}
}

bool Battle(Hero& hero, Enemies& enemy)
{
	system("cls");
	bool battleWon;
	int round = 1;
	int input;
	while (hero.health > 0 && enemy.health > 0)
	{
		input = PlayerMenu(round);
		PlayerTurn(input, round);
		if (enemy.health > 0)
		{
			EnemyAttack(hero, enemy);
			cout << "Press any key to continue...\n\n";
			_getch();
		}
		round++;
	}

	battleWon = EndBattle(hero);

	return battleWon;
}