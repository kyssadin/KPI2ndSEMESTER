#include "DerivedClass.h"

using namespace std;

dString::dString(string input[]):
bString(input) {
    data = input;
}

string dString::getData(int index){
    if (index >= data->length() ){
        cout << "Your index is out of range.";
        return " ";
    }
    return data[index];
}

void dString::removeDigit(char digit) {
    for (int i = 0; i < data->length()-1; i++){
        for (int j = 0; j < data[i].length(); j++){
            if (data[i][j] == digit){
                data[i].erase(j,1);
                j--;
            }
        }
    }
}