#include <iostream>
#include "myClass.h"
using namespace std;

void RowContainer::fill_row(char * inp) {
    rSize = strlen(inp);
    data = new char [rSize];
    for (int i = 0; i < strlen(inp); i++)
        data[i] = inp[i];
}

Text::Text(int size) {
    rows = new RowContainer [size];
}

void Text::addRow(char * inp) {
    rows[filled_rows].fill_row(inp);
    filled_rows++;
}


void Text::delRow(int index) {
    for (int i = index; i < filled_rows; i++) {
        rows[i] = rows[i+1];
    }
    rows[filled_rows].data = nullptr;
    rows[filled_rows].rSize = 0;
    filled_rows--;
}

void Text::erRows() {
    for (int i = 0; i < filled_rows; i++) {
        rows[i].data = {};
        rows[i].rSize = 0;
    }
    filled_rows = 0;
}

int Text::getCharAmount(){
    int charCounter{};
    for (int i = 0; i < filled_rows; i++){
        charCounter+=rows[i].rSize;
    }
    return charCounter;
}

int Text::getDigAmount() {
    double cnt{};
    for (int i = 0; i < filled_rows; i++){
       for (int j = 0 ; j < rows[i].rSize; j++){
           if(isdigit(rows[i].data[j])){
               cnt++;
           }
       }
    }
    return cnt;
}
double Text::getDigPercentage(){
    double percentage = (double)getDigAmount()/(double)getCharAmount()*100;
    return percentage;
}

int Text::getMaxRow(){
    int index{};
    for (int i = 0; i < filled_rows; i++){
        if (rows[i].rSize > rows[index].rSize)
            index = i;
    }
    return index;
}