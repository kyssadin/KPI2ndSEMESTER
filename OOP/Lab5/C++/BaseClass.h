#pragma once

#include<string>

using namespace std;

class bString {
protected:
    string* data;
public:
    bString(string[]);
    int getLength(int);
};
