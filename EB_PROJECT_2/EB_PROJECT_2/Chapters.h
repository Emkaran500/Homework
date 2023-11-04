#pragma once

bool Chapter(Hero& hero, BIOM currentLocation , int& checkpoint, int& score)
{
	system("cls");

	if (DeathCheck())
	{
		return false;
	}

	cout << "You wander into the "<< area[currentLocation - 1] << endl;
	cout << "Now you encounter:\n\n";
	cout << press;
	_getch();
	Event(hero, score, currentLocation, hero.difficulty);

	if (DeathCheck())
	{
		return false;
	}

	cout << "Your health is restored." << endl;
	hero.health = hero.oldHealth;

	return true;
}