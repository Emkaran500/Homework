#pragma once
#include <vector>

string towerImPath = "textures\\archer_tower.png";

const int archerTowerPrice = 3;
const int farmPrice = 2;

bool leftClickStatus = false;

class Placeable
{
protected:
	int price;
	sf::Clock placeablesClock;
	sf::Time placeablesTimer;

	virtual void Action() = 0;
};

class ArcherTower : protected Placeable
{
public:
	sf::RectangleShape tower = sf::RectangleShape(sf::Vector2f(63, 63));
	Arrow arrow = Arrow(0);
	double positionX;
	double positionY;
	static int numOfTowers;
	ArcherTower()
	{
		this->price = archerTowerPrice;
		this->positionX = 0;
		this->positionY = 0;
	}

	void PlaceTower(int i, int j)
	{
		this->tower.setPosition((mapElementWidth * j) + 100 + 31.5, (mapElementHeight * i) + 31.5);
	}

	void Action() override
	{
		this->placeablesTimer = this->placeablesClock.getElapsedTime();

		int angle = 0;

		for (int i = 0; i < 1; i++)
		{
			double toOrigin = sqrt((balloons[i].balloon.getPosition().x - this->tower.getPosition().x) * (balloons[i].balloon.getPosition().x - this->tower.getPosition().x) + (balloons[i].balloon.getPosition().y - this->tower.getPosition().y) * (balloons[i].balloon.getOrigin().y - this->tower.getOrigin().y));
			double toCenter = sqrt((toOrigin * toOrigin) + (31.5 * 31.5));
			double xDistance = this->tower.getPosition().x - balloons[0].balloon.getPosition().x;
			double sin = xDistance / toCenter;
			angle = ((sin * 100) / 0.84) - angle;
			this->tower.rotate(angle);
		}

		if (int(this->placeablesTimer.asSeconds()) % 2 == 0 && this->placeablesTimer.asSeconds() != 0)
		{
			for (int i = 0; i < 1; i++)
			{
				if (int(this->placeablesTimer.asSeconds()) % 2 == 0)
				{
					double toOrigin = sqrt((balloons[i].balloon.getPosition().x - this->tower.getPosition().x) * (balloons[i].balloon.getPosition().x - this->tower.getPosition().x) + (balloons[i].balloon.getPosition().y - this->tower.getPosition().y) * (balloons[i].balloon.getOrigin().y - this->tower.getOrigin().y));
					double toCenter = sqrt((toOrigin * toOrigin) + (31.5 * 31.5));
					double xDistance = this->tower.getPosition().x - balloons[0].balloon.getPosition().x;
					double yDistance = this->tower.getPosition().y - balloons[0].balloon.getPosition().y;
					this->arrow = Arrow(angle);
					this->arrow.directionX = xDistance / 2;
					this->arrow.directionY = yDistance / 2;
					this->arrow.arrow.setPosition(this->arrow.directionX, this->arrow.directionY);

					if ((balloons[i].balloon.getPosition().x - this->arrow.arrow.getPosition().x) * (balloons[i].balloon.getPosition().x - this->arrow.arrow.getPosition().x) + (balloons[i].balloon.getPosition().y - this->arrow.arrow.getPosition().y) * (balloons[i].balloon.getPosition().y - this->arrow.arrow.getPosition().y))
					{
						balloons[i].hp -= this->arrow.attack;
					}
				}
			}
		}
	}
};

class Farm : protected Placeable
{
public:
	Farm()
	{
		this->price = farmPrice;
	}

	void Action() override
	{
		if (int(this->placeablesTimer.asSeconds()) % 10 == 0 && this->placeablesTimer.asSeconds() != 0)
		{
			//money++;
		}
	}
};

bool CheckForItems()
{
	if (sf::Mouse::getPosition().x >= 63 && sf::Mouse::getPosition().y >= 70)
	{
		if (sf::Mouse::getPosition().x <= 126 && sf::Mouse::getPosition().y <= 120)
		{
			return true;
		}
	}

	return false;
}

int ArcherTower::numOfTowers = 0;
vector<ArcherTower> towers = vector<ArcherTower>(ArcherTower::numOfTowers);