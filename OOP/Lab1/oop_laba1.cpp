#include <iostream>
#include"prikol.h"
using namespace std;



int main()
{
	int a, b, c; // переменные для сравнения в равенстве / инкремента
	cout << "Enter the numbers you want to be compared\n";
	cout << "1 > ";
	cin >> a; // введение 1 
	cout << "2 > ";
	cin >> b; // введение 2
	bool res = EqualityFunction(a, b); // функция проверки на равенство
	if (res)
		cout << "Numbers are equal"; 
	else
		cout << "Numbers are not equal";
	cout << endl << "\n\n\nEnter the number to increment > ";
	cin >> c; // введение 3
	Increment(c); // функция инкремента
	cout << "Result > " << c<<"\n\n\n";
}