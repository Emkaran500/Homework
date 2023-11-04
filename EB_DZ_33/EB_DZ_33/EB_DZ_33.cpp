#include <iostream>
#include <fstream>
#define pi 3.14159265359

using namespace std;

struct DefaultFile
{
	virtual void Display(const char* path)
	{
		fstream file;
		char symbol;
		file.open(path, fstream::in);
		while (!file.eof())
		{
			file.get(symbol);
			cout << symbol;
		}
		file.close();
	}
};

struct ASCIIFile : DefaultFile
{
	void Display(const char* path) override
	{
		fstream file;
		char symbol;
		file.open(path, fstream::in);
		while (!file.eof())
		{
			file.get(symbol);
			cout << int(symbol);
		}
		file.close();
	}
};

struct BiteFile : DefaultFile
{
	void Display(const char* path) override
	{
		fstream file;
		char symbol;
		bool* ptr = (bool*)&symbol;
		file.open(path, fstream::in);
		while (!file.eof())
		{
			file.get(symbol);
			cout << *ptr;
		}
		file.close();
	}
};

struct Equations
{
	virtual void CreateEquation() = 0;
	virtual void Roots() = 0;
};

struct LinearEq : Equations
{
	// kx + b = 0
	double x;
	double k = 0;
	double b = 0;

	void CreateEquation() override
	{
		cout << "Input k: ", cin >> k;
		cout << "Input b: ", cin >> b;
	}

	void Roots() override
	{
		if (k == 0)
		{
			cout << "No equation." << endl;
			return;
		}
		x = (-b) / k;
		cout << "Root is: " << x << endl;
	}
};

struct QuadraticEq : Equations
{
	// ax^2 + bx + c = 0
	double x1;
	double x2;
	double a = 0;
	double b = 0;
	double c = 0;

	void CreateEquation() override
	{
		cout << "Input a: ", cin >> a;
		cout << "Input b: ", cin >> b;
		cout << "Input c: ", cin >> c;
	}

	double Bdegree2()
	{
		return this->b * this->b;
	}

	void Roots() override
	{
		if (a == 0)
		{
			cout << "Not a quadratic equation." << endl;
			return;
		}
		else if (a == 0 && b == 0)
		{
			cout << "No equation.";
			return;
		}
		
		double discr = Bdegree2() - 4 * a * c;

		if (discr > 0)
		{
			x1 = (-b + sqrt(discr)) / (2 * a);
			x2 = (-b - sqrt(discr)) / (2 * a);
			cout << "x1 = " << x1 << endl;
			cout << "x2 = " << x2 << endl;
		}
		else if (discr == 0)
		{
			x1 = -b / (2 * a);
			cout << "x = " << x1;
		}
		else
		{
			cout << "No roots.";
		}
	}
};

struct Shape
{
	virtual void Show() = 0;
	virtual double Perimeter() = 0;
	virtual double Area() = 0;
};

struct Square : Shape
{
	double length = 0;

	void CreateSquare()
	{
		cout << "Input side length of your square: ", cin >> length;
	}

	void Show()
	{
		for (int i = 1; i <= length; i++)
		{
			for (int j = 1; j <= length; j++)
			{
				cout << (j == length ? '\n' : char(254));
			}
		}
	}

	double Perimeter() override
	{
		return 4 * length;
	}

	double Area() override
	{
		return length * length;
	}
};

struct Rectangle : Shape
{
	double length = 0;
	double width = 0;

	void CreateRectangle()
	{
		cout << "Input side length of your rectangle: ", cin >> length;
		cout << "Input side width of your rectangle: ", cin >> width;
	}

	void Show()
	{
		for (int i = 1; i <= width; i++)
		{
			for (int j = 1; j <= length; j++)
			{
				cout << (j == length ? '\n' : char(254));
			}
		}
	}

	double Perimeter() override
	{
		return 2 * length + 2 * width;
	}

	double Area() override
	{
		return length * width;
	}
};

struct Circle : Shape
{
	double radius = 0;

	void CreateCircle()
	{
		cout << "Input radius of your circle: ", cin >> radius;
	}

	double RaduisDegree2()
	{
		return this->radius * this->radius;
	}

	void Show()
	{
		cout << "Circle" << endl;
	}

	double Perimeter() override
	{
		return 2 * pi * radius;
	}

	double Area() override
	{
		return pi * RaduisDegree2();
	}
};

struct Triangle : Shape
{
	double side1 = 0;
	double side2 = 0;
	double side3 = 0;

	void CreateTriangle()
	{
		cout << "Input the first side length of your triangle: ", cin >> side1;
		cout << "Input the second side length of your triangle: ", cin >> side2;
		cout << "Input the third side length of your triangle: ", cin >> side3;
	}

	double HalfPer()
	{
		return (side1 + side2 + side3) / 2;
	}

	void Show() override
	{
		cout << "Triangle" << endl;
	}

	double Perimeter() override
	{
		return side1 + side2 + side3;
	}

	double Area() override
	{
		return sqrt(HalfPer() * (HalfPer() - side1) * (HalfPer() - side2) * (HalfPer() - side3));
	}
};

int main()
{

}