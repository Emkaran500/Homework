#pragma once

class Arrow
{
public:
	int attack = 10;
	double directionX = 0;
	double directionY = 0;

	sf::RectangleShape arrow = sf::RectangleShape(sf::Vector2f(7, 2));

	Arrow(double angle)
	{
		this->arrow.setRotation(angle);
	}
};