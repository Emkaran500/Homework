#pragma once
#define RADIUS 31.5

enum Life
{
	isAlive,
	isDead
};


string balloonRedImPath = "textures\\red_balloon.png";
string balloonOrangeImPath = "textures\\orange_balloon.png";
string balloonBlueImPath = "textures\\blue_balloon.png";
sf::Texture balloonTexture = sf::Texture();
int wave = 1;


enum Colours
{
	none,
	red,
	orange,
	blue
};

class Enemy
{
public:
	static int numOfEnemies;
	int hp = 0;
	float directionX = 0;
	float directionY = 0;
	sf::CircleShape balloon;
	sf::Sprite balloonSkin = sf::Sprite();
	sf::Vector2f balloonPosition = sf::Vector2f(163, 700);
	MoveDirection direction = MoveDirection::north;
	Colours balloonColour = Colours::none;
	Life isAlive = Life::isDead;
	void Move()
	{
		if (direction == MoveDirection::north)
		{
			directionX = 0;
			directionY = -0.3;
		}
		else if (direction == MoveDirection::east)
		{
			directionX = 0.3;
			directionY = 0;
		}
		else if (direction == MoveDirection::south)
		{
			directionX = 0;
			directionY = 0.3;
		}
		else if (direction == MoveDirection::west)
		{
			directionX = -0.3;
			directionY = 0;
		}
		else
		{
			directionX = 0;
			directionY = 0;
		}

		this->balloon.setPosition(this->balloon.getPosition().x + this->directionX, this->balloon.getPosition().y + this->directionY);
	}

	virtual void DeathAction() = 0;
};


class Balloon : public Enemy
{
	double radius = 0;

	void DeathAction() override
	{
		//score += 100;
	}

	void SetBalloonColor(Colours colour)
	{
		this->balloonColour = colour;
	}

public:
	Balloon() {}

	Balloon(double radius, double distance, Colours colour)
	{
		this->hp = 10 * int(colour);
		this->radius = radius;
		this->balloon.setRadius(this->radius);
		this->balloon.setPosition(this->balloonPosition.x, this->balloonPosition.y + (distance * 30));
		this->isAlive = Life::isAlive;
	}
};

int Enemy::numOfEnemies = 5;
Balloon* balloons = new Balloon[Enemy::numOfEnemies]{Balloon(RADIUS, 0, Colours::red)};

void NewDirection()
{
	for (int i = 0; i < Enemy::numOfEnemies; i++)
	{
		for (int j = 0; j < TriggerBlock::numOfBlocks; j++)
		{
			if (balloons[i].balloon.getPosition().x >= blocksArr[j].positionX && balloons[i].balloon.getPosition().y >= blocksArr[j].positionY)
			{
				if (balloons[i].balloon.getPosition().x <= (blocksArr[j].positionX + 1) && balloons[i].balloon.getPosition().y <= (blocksArr[j].positionY + 1))
				{
					balloons[i].direction = blocksArr[j].blockDirection;
					break;
				}
			}
		}
	}
}