#include <Windows.h>
#include <iostream>
#include "line.h"
#include "angle.h"
#include "triangle.h"
#include "circle.h"
#include "segments.h"

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	try {
		segments sm1(101);
		printf("������ ������� ������\n");
		sm1.totalvivod();
	}
	catch(std::string str) {
		printf("������ �� ��� ������\n");
		std::cout << str;
	}
	return 0;
}