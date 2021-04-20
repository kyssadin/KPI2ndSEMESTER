#pragma once
#include"BaseClass.h"
#include<iostream>

using namespace std;

class dString:
        public bString
{
public:
    dString(string[]);
    string getData(int);
    void removeDigit(char);
};
