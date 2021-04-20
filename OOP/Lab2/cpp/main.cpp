#include<iostream>
#include"myClass.h"
#include<iomanip>

using namespace std;


void show(Text & obj) {
    for (int k = 0; k < 4; k++){
        for (int i = 0; i < obj.rows[k].rSize; i++)
            cout << obj.rows[k].data[i];
        cout << endl;
    }
}


int main(){
    Text myStr(5);
    myStr.addRow((char *) "Hello");
    myStr.addRow((char *) "Next is digits");
    myStr.addRow((char *) "123456789");
    myStr.addRow((char *) "Goodbye");
    cout << endl << "========STARTING TEXT========" << endl << endl;
    show(myStr);
    cout << endl << endl;

    cout << endl << "========CALCULATIONS========" << endl << endl;
    cout << "Amount of characters in the text : " << myStr.getCharAmount() << endl;
    cout << "Digit Percentage : " << setprecision(3) << myStr.getDigPercentage() << "%  |   " << myStr.getDigAmount();
    cout << " digits to " << myStr.getCharAmount() << " characters " << endl;
    cout << "Max Row : ";
    for ( int i = 0 ; i < myStr.rows[myStr.getMaxRow()].rSize; i++){
        cout << myStr.rows[myStr.getMaxRow()].data[i];
    }
    cout << endl;

    cout << endl << "========ERASING TEXT========" << endl << endl;
    cout << "Text after deleting row 1 : " << endl;
    myStr.delRow(1);
    show(myStr);
    myStr.erRows();
    cout << "Text after erasing it completely : " << endl;
    show(myStr);
    cout << endl << "========END========" << endl << endl;
};
