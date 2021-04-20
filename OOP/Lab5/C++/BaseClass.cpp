#include "BaseClass.h"
#include<iostream>

using namespace std;

bString::bString(string input[]){
    data = input;
}

int bString::getLength(int index){
    if (index >= data->length() ){
        cout << "Your index is out of range.";
        return -1;
    }
    return data[index].length();
}