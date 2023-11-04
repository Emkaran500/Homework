#include <iostream>
using namespace std;

int money = 5;

const int windowWidth = 982, windowHeight = 693;

const int mapElementWidth = 63, mapElementHeight = 63;
const int mapX = 14, mapY = 11;

#include <SFML/Graphics.hpp>
#include "Projectiles.h"
#include "Triggers.h"
#include "Balloons.h"
#include "Placeables.h"
#include "MapAndWindow.h"



int main()
{

    sf::Clock clock;

    int map[mapY][mapX]{
        {0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 },
        {0 ,0, 0, 0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 },
        {0 ,0 ,0 ,0 ,0 ,6 ,2 ,2 ,2 ,7 ,0 ,0 ,1 ,0 },
        {0 ,6 ,2 ,7 ,0 ,1 ,0 ,0 ,0 ,1 ,0 ,0 ,1 ,0 },
        {0 ,1 ,0 ,1 ,0 ,1 ,0 ,0 ,0 ,1 ,0 ,0 ,1 ,0 },
        {0 ,1 ,0 ,1 ,0 ,1 ,0 ,0 ,0 ,1 ,0 ,0 ,1 ,0 },
        {0 ,1 ,0 ,9 ,2 ,8 ,0 ,0 ,0 ,1 ,0 ,0 ,1 ,0 },
        {0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,1 ,0 },
        {0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,1 ,0 },
        {0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,9 ,2 ,2 ,8 ,0 },
        {0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
    };

    BlocksCreation(map, mapX, mapY);

    sf::Texture mapTexture = sf::Texture();
    mapTexture.loadFromFile("textures\\ground_tile.jpg");
    sf::Texture tableTexture = sf::Texture();
    tableTexture.loadFromFile("textures\\table.png");
    sf::Texture archerTowerTexture = sf::Texture();
    archerTowerTexture.loadFromFile("textures\\archer_tower.png");
    sf::Texture archerTowerTakenTexture = sf::Texture();
    archerTowerTakenTexture.loadFromFile("textures\\archer_tower_taken.png");
    sf::Font font;
    font.loadFromFile("fonts\\MedievalSharp.ttf");
    sf::Text archerTowerText;
    archerTowerText.setFont(font);
    sf::Text moneyText;
    moneyText.setFont(font);
    sf::Text LoseText;
    LoseText.setFont(font);

    LoseText.setString("You Lost!");
    LoseText.setCharacterSize(40);
    archerTowerText.setFillColor(sf::Color::Black);
    LoseText.setOutlineThickness(0.25);
    LoseText.setOutlineColor(sf::Color::Black);
    LoseText.setPosition(sf::Vector2f(441, 306));

    archerTowerText.setString("Archer Tower");
    archerTowerText.setCharacterSize(15);
    archerTowerText.setFillColor(sf::Color::Black);
    archerTowerText.setOutlineThickness(0.25);
    archerTowerText.setOutlineColor(sf::Color::Black);
    archerTowerText.setPosition(sf::Vector2f(6, 65));

    moneyText.setCharacterSize(15);
    moneyText.setFillColor(sf::Color::Black);
    moneyText.setOutlineThickness(0.25);
    moneyText.setOutlineColor(sf::Color::Black);
    moneyText.setPosition(sf::Vector2f(6, 500));

    while (window.isOpen())
    {
        window.clear();
        string textForMoney = "Money: " + to_string(money);
        moneyText.setString(textForMoney);
        sf::Time timer = clock.getElapsedTime();
        cout << timer.asSeconds() << endl;

        switch (wave)
        {
        case 1:
            for (int i = 0; i < Enemy::numOfEnemies; i++)
            {
                balloons[i] = Balloon(RADIUS, i, Colours::red);
                balloonTexture.loadFromFile(balloonRedImPath);
                balloonTexture.setSmooth(true);
                balloons[i].balloon.setTexture(&balloonTexture);
            }
            wave++;
            break;
        case 2:
            if ((timer.asSeconds() - 30) >= 0)
            {
                for (int i = 0; i < Enemy::numOfEnemies; i++)
                {
                    balloons[i] = Balloon(RADIUS, i, Colours::orange);
                    balloonTexture.loadFromFile(balloonOrangeImPath);
                    balloonTexture.setSmooth(true);
                    balloons[i].balloon.setTexture(&balloonTexture);
                }
                wave++;
                break;
            }
        case 3:
            if ((timer.asSeconds() - 60) >= 0)
            {
                for (int i = 0; i < Enemy::numOfEnemies; i++)
                {
                    balloons[i] = Balloon(RADIUS, i, Colours::blue);
                    balloonTexture.loadFromFile(balloonBlueImPath);
                    balloonTexture.setSmooth(true);
                    balloons[i].balloon.setTexture(&balloonTexture);
                }
                wave++;
                break;
            }
        }

        sf::Time statusTimer;
        
        if (sf::Mouse::isButtonPressed(sf::Mouse::Left))
        {
            leftClickStatus = CheckForItems();
        }

        MapCreation(map, mapX, mapY, mapTexture, leftClickStatus, archerTowerTexture);

        for (int i = 0; i < mapY; i++)
        {
            for (int j = 0; j < mapX; j++)
            {

                while (sf::Mouse::isButtonPressed(sf::Mouse::Button::Left) && leftClickStatus)
                {
                    if (sf::Mouse::getPosition().x >= 196 + (196 * j) && sf::Mouse::getPosition().y >= 114 * i)
                    {
                        if (sf::Mouse::getPosition().x <= 317 + (317 * j) && sf::Mouse::getPosition().y <= 114 + (114 * i))
                        {
                            money--;
                            towers.push_back(ArcherTower());
                            ArcherTower::numOfTowers++;
                            towers[i].PlaceTower(i, j);
                            towers[i].tower.setTexture(&archerTowerTexture);
                            window.draw(towers[i].tower);
                        }
                    }
                }
            }
        }

        DrawTable(tableTexture);

        window.draw(archerTowerText);
        window.draw(moneyText);

        auto towerRect = sf::RectangleShape(sf::Vector2f(63, 63));
        towerRect.setPosition(18.5, 20);

        if (leftClickStatus)
        {
            towerRect.setTexture(&archerTowerTakenTexture);
            window.draw(towerRect);
        }
        else
        {
            towerRect.setTexture(&archerTowerTexture);
            window.draw(towerRect);
        }

        auto farmRect = sf::RectangleShape(sf::Vector2f(63, 63));
        farmRect.setPosition(18.5, 120);

        NewDirection();
        
        for (int i = 0; i < Enemy::numOfEnemies; i++)
        {
            balloons[i].Move();
            window.draw(balloons[i].balloon);
        }

        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();
        }

        auto testTower1 = ArcherTower();
        testTower1.tower.setOrigin(sf::Vector2f(31.5, 31.5));
        testTower1.PlaceTower(2, 3);
        testTower1.tower.setTexture(&archerTowerTexture);
        testTower1.Action();
        window.draw(testTower1.arrow.arrow);
        window.draw(testTower1.tower);

        auto testTower2 = ArcherTower();
        testTower2.tower.setOrigin(sf::Vector2f(31.5, 31.5));
        testTower2.PlaceTower(1, 5);
        testTower2.tower.setTexture(&archerTowerTexture);
        testTower2.Action();
        window.draw(testTower1.arrow.arrow);
        window.draw(testTower2.tower);

        for (int i = 0; i < Enemy::numOfEnemies; i++)
        {
            if ((balloons[i].balloon.getPosition().y + 31.5) <= 0)
            {
                window.draw(LoseText);
            }
        }

        window.display();
    }

    return 0;
}