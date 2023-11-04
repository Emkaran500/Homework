#pragma once
#define ZERO 48
#define ONE 1
#define TWO 2
#define FOUR 4

using namespace std;

const char press[]{ "Press any key to continue..." };

const int baseHealth = 80;
const int baseAttack = 10;
const int baseDefense = 0;
const int baseEvasion = 20;

const char** bonusName = new const char*[4]{ "No bonus", "Fire", "Ice", "Poison" };
const char** weaponName = new const char*[4]{ "knife", "sword", "mace", "warhammer" };
const char** armourName = new const char*[4]{ "leather", "steel", "plated", "knight" };
const char** area = new const char*[3]{"forest", "desert", "marsh"};
const char** enemiesNames = new const char*[3]{ "fox", "wolf", "bear" };
const char** classNames = new const char*[2]{ "scout", "swordsman" };
const char** difficultyNames = new const char*[2]{ "normal", "hard" };
const char** sizesNames = new const char*[3]{ " little ", " average ", " big " };

enum CHARACTER_CLASS
{
	noClass,
	scout,
	swordsman
};

enum DIFFICULTY
{
	notYet,
	normal,
	hard
};

enum BIOM
{
	forest = 1,
	desert,
	marsh
};

enum TYPE_OF_ENEMY
{
	little = 0,
	medium = 20,
	big = 50
};

enum SIZE_ENEMIES
{
	puny,
	moderate,
	enormous
};

enum LIFE
{
	alive,
	dead
};

enum TYPE_OF_BONUS_DAMAGE
{
	no_add_damage = 0,
	ice_damage = 2,
	fire_damage = 2,
	poison_damage = 5
};

enum TYPE_OF_DEFENSE
{
	no_add_defense = 0,
	ice_defense = 10,
	fire_defense = 10,
	poison_defense = 10
};

enum WEAPONS_DATA
{
	noWeapon = 100,
	knife = 1,
	sword,
	mace,
	warhammer
};

enum BODY_ARMOUR_DATA
{
	noArmour = 139,
	leather = 1,
	steel,
	plated,
	knight
};

struct WEAPONS
{
	char* nameOfWeapon = new char[20]{};
	int attackPoints;
	int weight;
	TYPE_OF_BONUS_DAMAGE bonusDamage;
};

struct BODY_ARMOUR
{
	char* nameOfArmour = new char[20]{};
	int defensePoints;
	TYPE_OF_DEFENSE defenseType;
	int weight;
};

struct Hero
{
	char* nameOfCharacter = new char[30]{};
	char* characterClass = new char[10]{};
	int health;
	WEAPONS* weapon;
	int attack;
	BODY_ARMOUR* armour;
	int evasion;
	int defense;
	DIFFICULTY difficulty = DIFFICULTY::notYet;
	char* difficultyName = new char[10]{};
	LIFE isDead = LIFE::dead;
	int oldHealth;
};

struct Enemies
{
	char* nameOfEnemy = new char[30]{};
	int health;
	int attack;
	int evasion;
	int defense;
};

WEAPONS weapon = WEAPONS();
BODY_ARMOUR armour = BODY_ARMOUR();
Hero hero = Hero();
Enemies enemy = Enemies();

void Introducing(char* name)
{
	cout << "Welcome stranger! Please introduce yourself: ", cin >> name;
	cout << endl;
}

void CharacterType(CHARACTER_CLASS& characterType)
{
	while ((int)characterType < ONE || (int)characterType > TWO)
	{
		cout << "What type of character are you?" << endl;
		cout << "Scout - type \"1\", Swordsman - type \"2\": ";
		int getch = _getch();
		characterType = (CHARACTER_CLASS)(getch - ZERO);
		cout << characterType;
		cout << endl;
	}
}

void EquipmentChoose(WEAPONS_DATA& weaponType)
{
	while ((int)weaponType < ONE || (int)weaponType > FOUR)
	{
		cout << endl;
		cout << "1. " << weaponName[0] << "\n" << "2. " << weaponName[1] << "\n" << "3. " << weaponName[2] << "\n" << "4. " << weaponName[3] << "\n";
		cout << "Choose your weapon: ", weaponType = (WEAPONS_DATA)(_getch() - ZERO);
		cout << weaponType;
		cout << endl;
	}
}

void EquipmentChoose(BODY_ARMOUR_DATA& armourType)
{
	while ((int)armourType < ONE || (int)armourType > FOUR)
	{
		cout << endl;
		cout << "1. " << armourName[0] << "\n" << "2. " << armourName[1] << "\n" << "3. " << armourName[2] << "\n" << "4. " << armourName[3] << "\n";
		cout << "Choose your armour: "; armourType = (BODY_ARMOUR_DATA)(_getch() - ZERO);
		cout << armourType;
		cout << endl;
	}
}

void DifficultyType(DIFFICULTY& difficultyType)
{
	while ((int)difficultyType < ONE || (int)difficultyType > FOUR)
	{
		cout << endl;
		cout << "What difficulty of the game would you prefer?" << endl;
		cout << "Normal - type \"1\", Hard - type \"2\": ", difficultyType = (DIFFICULTY)(_getch() - ZERO);
		cout << difficultyType << endl;
	}
}