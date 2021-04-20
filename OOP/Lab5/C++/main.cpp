#include <iostream>
#include"BaseClass.h"
#include"DerivedClass.h"

int main(){
    dString object = dString(new string[3]{ "This", "Cont4ins", "Fours 44444"});

    for(int i = 0; i < 3; i++){
        cout << object.getData(i) << endl;
    }
    cout << endl;

    cout << "Length of line 1 : " << object.getLength(0) << endl;
    cout << "Length of line 2 : " << object.getLength(1) << endl;
    cout << "Length of line 3 : " << object.getLength(2) << endl << endl;

    object.removeDigit('4');
    for(int i = 0; i < 3; i++){
        cout << object.getData(i) << endl;
    }

    cout << endl << "Length of line 2 : " << object.getLength(1) << endl;
    cout << "Length of line 3 : " << object.getLength(2) << endl << endl;
}
