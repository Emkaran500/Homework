#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <conio.h>

int checkpoint = 1;

#include "AddCreationInfo.h"
#include "Equipment.h"
#include "Characters.h"
#include "Battle.h"
#include "Events.h"
#include "Chapters.h"
#include "MainStory.h"

using namespace std;


int main()
{
	srand(time(0));
	bool exit;
	exit = MainMenu();
	if (exit)
	{
		cout << "Goodbye gamer!";
		return 0;
	}
	int score = 0;
	bool finished = false;
	hero = CharacterInfo();
	finished = MainStory(hero, checkpoint, score);
	EndGame(checkpoint, finished, score);
}