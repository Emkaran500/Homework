#pragma once
#include <windows.h>

char* EnemiesName(char* name, BIOM location, SIZE_ENEMIES size)
{
	char** additionLocation = new char*[10]{ (char*)area[((int)location - 1)] };
	char** additionSize = new char*[10]{ (char*)sizesNames[(int)size] };
	char* result = new char[50]{};
	cout << additionLocation[0] << endl;
	cout << additionSize[0] << endl;
	strcat(result, additionLocation[0]);
	strcat(result, additionSize[0]);
	strcat(result, name);

	cout << result;
	return result;
}

void ShowEnemy(Enemies enemy)
{
	cout << "\n\n";

	cout << "Enemy's name: " << enemy.nameOfEnemy << endl;
	cout << "Enemy's health: " << enemy.health << endl;
	cout << "Enemy's attack: " << enemy.attack << endl;
	cout << "Enemy's defense: " << enemy.defense << endl;
	cout << "Enemy's evasion: " << enemy.evasion << "\n\n";

	cout << press << endl;
	_getch();
}

void ShowCharacter(Hero hero)
{
	cout << "\n\n";

	cout << "Your name: " << hero.nameOfCharacter << endl;
	cout << "Your class: " << hero.characterClass << endl;
	cout << "Character's health: " << hero.health << " hp" << endl;
	cout << "Character's weapon: " << hero.weapon->nameOfWeapon << endl;
	cout << "Character's attack: " << hero.attack << endl;
	cout << "Character's armour: " << hero.armour->nameOfArmour << endl;
	cout << "Character's defense: " << hero.defense << "%" << endl;
	cout << "Character's evasion: " << hero.evasion << "%" << endl;
	cout << "Difficulty: " << hero.difficultyName << "\n\n";

	cout << press << endl;
	_getch();
}

Hero CreateCharacter(char* name, WEAPONS weapon, CHARACTER_CLASS typeOfClass, DIFFICULTY difficulty)
{
	hero.nameOfCharacter = name;
	hero.characterClass = (char*)classNames[(int)typeOfClass - 1];
	hero.health = baseHealth + (typeOfClass * 10) - (difficulty * 10);
	hero.weapon = &weapon;
	hero.attack = baseAttack + hero.weapon->attackPoints + (typeOfClass * 10) - (difficulty * 10) ;
	hero.armour = &armour;
	hero.defense = baseDefense + hero.armour->defensePoints + (typeOfClass * 10) - (difficulty * 10);
	hero.evasion = baseEvasion + (typeOfClass * 10) - (difficulty * 10) - hero.armour->weight - hero.weapon->weight;
	hero.difficulty = difficulty;
	hero.difficultyName = (char*)difficultyNames[(int)difficulty - 1];
	hero.isDead = LIFE::alive;
	hero.oldHealth = hero.health;
	ShowCharacter(hero);

	return hero;
}

Enemies CreateEnemy(char* name, BIOM location, TYPE_OF_ENEMY typeOfEnemy, SIZE_ENEMIES size , DIFFICULTY difficulty)
{
	enemy.nameOfEnemy = EnemiesName(name, location, size);
	enemy.health = baseHealth + (int)typeOfEnemy + ((int)difficulty * 5);
	enemy.attack = baseAttack + (((int)typeOfEnemy) / 10) + ((int)difficulty * 2);
	enemy.defense = baseDefense + (int)typeOfEnemy + ((int)difficulty * 5);
	enemy.evasion = baseEvasion + ((int)difficulty * 5);

	return enemy;
}

Hero CharacterInfo()
{
	char* name = new char[30]{};
	CHARACTER_CLASS characterType = CHARACTER_CLASS::noClass;
	DIFFICULTY difficultyType = DIFFICULTY::notYet;
	WEAPONS_DATA weaponType = WEAPONS_DATA::noWeapon;
	BODY_ARMOUR_DATA armourType = BODY_ARMOUR_DATA::noArmour;

	Introducing(name);

	CharacterType(characterType);

	EquipmentChoose(weaponType);
	weapon = WhichWeaponForMelee((WEAPONS_DATA)weaponType);

	EquipmentChoose(armourType);
	armour = WhichArmour((BODY_ARMOUR_DATA)armourType);

	DifficultyType(difficultyType);

	return CreateCharacter(name, weapon, characterType, difficultyType);
}


bool DeathCheck()
{
	return hero.isDead == LIFE::dead;
}