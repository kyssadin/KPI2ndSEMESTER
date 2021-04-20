#include<iostream>
using namespace std;
bool EqualityFunction(int number1, int number2)
{
    bool equal = true;
    for (int x = 0; ((x < sizeof(int)) | (x < sizeof(int))); x++)
    {
        if ((number1 & (1 << x)) == (number2 & (1 << x)))
        {
            equal = true;
        }
        else
        {
            equal = false;
            return equal;
        }
    }
    return equal;
}
void Increment(int& b)
{
	int counter = 0;
	while ((b & (1 << counter)) != 0)
	{
		b = b ^ (1 << counter);
		counter++;
	}
	b = b ^ (1 << counter);

}