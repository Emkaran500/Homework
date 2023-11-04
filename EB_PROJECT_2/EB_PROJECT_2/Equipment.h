#pragma once

using namespace std;

template<typename T>
void ShowWeapon(T weapon)
{
	char* bonus = new char[10]{};

	bonus = (char*)bonusName[(int)weapon.bonusDamage];

	system("cls");
	cout << "Weapon: " << weapon.nameOfWeapon << endl;
	cout << "Attack Points: " << weapon.attackPoints << endl;
	cout << "Type of Bonus Damage: " << bonus << endl;
	cout << "Weight of a Weapon: " << weapon.weight << endl;
}

void ShowArmour(BODY_ARMOUR armour)
{
	char* bonus = new char[10]{};

	bonus = (char*)bonusName[(int)armour.defenseType];

	system("cls");
	cout << "Armour: " << armour.nameOfArmour << endl;
	cout << "Defense Points: " << armour.defensePoints << endl;
	cout << "Type of Bonus Defense: " << bonus << endl;
	cout << "Weight of an Armour: " << armour.weight << endl;
}

WEAPONS WhichWeaponForMelee(WEAPONS_DATA typeNum)
{
	weapon.nameOfWeapon = (char*)weaponName[(int)typeNum  - 1];
	weapon.attackPoints = 10*((int)typeNum);
	weapon.bonusDamage = (TYPE_OF_BONUS_DAMAGE)(rand());
	weapon.weight = 1*((int)typeNum);

	return weapon;
}

BODY_ARMOUR WhichArmour(BODY_ARMOUR_DATA typeNum)
{
	armour.nameOfArmour = (char*)armourName[(int)typeNum - 1];
	armour.defensePoints = 15*((int)typeNum);
	armour.defenseType = (TYPE_OF_DEFENSE)(rand());
	armour.weight = 5*((int)typeNum);

	return armour;
}