#pragma once
#define WINNER 200
#define TREASURE 100
#define MIRAGE 50

SIZE_ENEMIES CheckSize(SIZE_ENEMIES size)
{
	int randomizer = (rand() % 3);

	switch (randomizer)
	{
	case 0:
		size = SIZE_ENEMIES::puny;
		break;
	case 1:
		size = SIZE_ENEMIES::moderate;
		break;
	case 2:
		size = SIZE_ENEMIES::enormous;
		break;
	default:
		break;
	}

	return size;
}

TYPE_OF_ENEMY CheckType(TYPE_OF_ENEMY type ,SIZE_ENEMIES size)
{
	switch (size)
	{
	case 0:
		type = TYPE_OF_ENEMY::little;
		break;
	case 1:
		type = TYPE_OF_ENEMY::medium;
		break;
	case 2:
		type = TYPE_OF_ENEMY::big;
		break;
	default:
		break;
	}

	return type;
}

void Event(Hero& hero, int& score, BIOM location, DIFFICULTY difficulty)
{
	system("cls");
	int randomizer = rand() % 3;
	int whichName = (rand() % 3);
	SIZE_ENEMIES size = SIZE_ENEMIES::puny;
	TYPE_OF_ENEMY typeOfEnemy = TYPE_OF_ENEMY::little;

	switch (randomizer)
	{
	case 0:
		cout << "An animal is coming towards you, prepare yourself!" << endl;

		cout << press;
		_getch();

		bool battleWon;

		size = CheckSize(size);
		typeOfEnemy = CheckType(typeOfEnemy, size);

		enemy = CreateEnemy((char*)enemiesNames[whichName], location, TYPE_OF_ENEMY::big, size, difficulty);
		battleWon = Battle(hero, enemy);

		if (battleWon)
		{
			score += WINNER;
			checkpoint++;
			cout << "You have won the battle!" << endl;
			cout << "Score + " << WINNER << endl;

			cout << press << endl;
			_getch();
		}
		else
		{
			hero.isDead = LIFE::dead;
		}
		break;
	case 1:
		cout << "You find a treasure, congratz!" << endl;
		cout << "Score + " << TREASURE << endl;
		score += 100;
		checkpoint++;
		cout << press;
		_getch();
		break;
	case 2:
		cout << "You saw a mirage and didn't encounter anything." << endl;
		cout << "Score + " << MIRAGE << endl;
		score += 50;
		checkpoint++;
		cout << press;
		_getch();
		break;
	default:
		break;
	}
}

void EndGame(const int checkpoint, bool finished, const int score)
{
	system("cls");
	if (finished)
	{
		cout << "You have returned home with all the treasures and glory you have earned on your way!\n\n";
		cout << "Your final score is: " << score << endl;

		cout << press;
		_getch();
	}
	else
	{
		switch (checkpoint)
		{
		case 1:
			cout << "You have been lost in the forest, lying between trees' roots, conecting to the forest's soul." << endl;
			cout << "Your final score is: " << score << "\n\n";
			cout << press, _getch();
			break;
		case 2:
			cout << "You have been lost in the desert, lying between sand dunes, rotting under the scorching Sun." << endl;
			cout << "Your final score is: " << score << "\n\n";
			cout << press, _getch();
			break;
		case 3:
			cout << "You have been lost in the marsh, lying between reeds, with little frogs and flies around you." << endl;
			cout << "Your final score is: " << score << "\n\n";
			cout << press, _getch();
			break;
		default:
			break;
		}
	}
}