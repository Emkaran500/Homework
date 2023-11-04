#pragma once

using namespace std;




sf::RenderWindow window(sf::VideoMode(windowWidth, windowHeight), "Monkey Rush");

void MapCreation(int map[][14], int mapX, int mapY, sf::Texture mapTexture, bool leftClickStatus, sf::Texture archerTowerTexture)
{
    for (int i = 0; i < mapY; i++)
    {
        for (int j = 0; j < mapX; j++)
        {
            int currentElement = map[i][j];

            auto rect = sf::IntRect((currentElement % 6) * mapElementWidth, (currentElement / 6) * mapElementHeight, mapElementWidth, mapElementHeight);

            sf::Sprite mapSprite = sf::Sprite(mapTexture, rect);
            mapSprite.setPosition((mapElementWidth * j) + 100, mapElementHeight * i);
            window.draw(mapSprite);
        }
    }
}

void BlocksCreation(int map[][14], int mapX, int mapY)
{
    for (int i = 0; i < mapY; i++)
    {
        for (int j = 0; j < mapX; j++)
        {
            int currentElement = map[i][j];

            if (CornerCheck)
            {
                blocksArr = TriggerBlock::AddBlock(i, j, blocksArr, currentElement);
            }
        }
    }
}

void DrawTable(sf::Texture tableTexture)
{
    auto tableRect = sf::IntRect(0, 0, 100, 693);
    

    sf::Sprite tableSprite = sf::Sprite(tableTexture, tableRect);
    tableSprite.setPosition(0, 0);

    window.draw(tableSprite);
}