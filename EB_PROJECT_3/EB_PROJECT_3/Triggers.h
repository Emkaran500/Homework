#pragma once

#define NORTHWEST 6
#define NORTHEAST 7
#define SOUTHEAST 8
#define SOUTHWEST 9
#define CornerCheck (currentElement == NORTHWEST || currentElement == NORTHEAST || currentElement == SOUTHEAST || currentElement == SOUTHWEST)

enum MoveDirection
{
	unknown,
	north,
	east,
	south,
	west
};

class TriggerBlock
{
public:
	static int numOfBlocks;
	sf::RectangleShape block = sf::RectangleShape(sf::Vector2f(63, 63));
	double positionX;
	double positionY;

	MoveDirection blockDirection = MoveDirection::unknown;

	void BlockDirection(const int mapElementType)
	{
		if (mapElementType == NORTHWEST || mapElementType == SOUTHWEST)
		{
			this->blockDirection = MoveDirection::east;
		}
		else if (mapElementType == NORTHEAST)
		{
			this->blockDirection = MoveDirection::south;
		}
		else if (mapElementType == SOUTHEAST)
		{
			this->blockDirection = MoveDirection::north;
		}
	}

	TriggerBlock() 
	{
		this->positionX = 0;
		this->positionY = 0;
	}
	
	TriggerBlock(double X, double Y, const int mapElementType)
	{
		this->positionX = X;
		this->positionY = Y;
		BlockDirection(mapElementType);

		block.setFillColor(sf::Color(0, 0, 0, 0));
	}

	static TriggerBlock* AddBlock(const int i, const int j, TriggerBlock* blocksArr, const int mapElementType) //from for(){for(){...}}
	{
		numOfBlocks++;
		TriggerBlock* newBlocksArr = new TriggerBlock[numOfBlocks];



		newBlocksArr[numOfBlocks - 1] = TriggerBlock((mapElementWidth * j) + 100, mapElementHeight * i, mapElementType);
		for (int m = 0; m < (numOfBlocks - 1); m++)
		{
			newBlocksArr[m] = blocksArr[m];
		}

		blocksArr = newBlocksArr;

		return blocksArr;
	}
};

int TriggerBlock::numOfBlocks = 0;

TriggerBlock* blocksArr;
