#pragma once

using namespace std;

bool MainMenu()
{
	int input = -1;
	while (input < 0 || input > 1)
	{
		cout << "Press \"1\" to play and \"0\" to exit." << endl;
		input = (_getch() - ZERO);
	}

	switch (input)
	{
	case 0:
		return true;
	case 1:
		system("cls");
		return false;
	default:
		break;
	}
}

bool MainStory(Hero& hero, int& checkpoint, int& score)
{
	bool walkthrough = true;
	while (checkpoint <= 3)
	{
		switch (checkpoint)
		{
		case 1:
			walkthrough = Chapter(hero, BIOM(checkpoint), checkpoint, score);
			if (walkthrough == false)
			{
				return walkthrough;
			}
			break;
		case 2:
			walkthrough = Chapter(hero, BIOM(checkpoint), checkpoint, score);
			if (walkthrough == false)
			{
				return walkthrough;
			}
			break;
		case 3:
			walkthrough = Chapter(hero, BIOM(checkpoint), checkpoint, score);

			return walkthrough;

			break;
		default:
			break;
		}
	}
}