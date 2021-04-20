#pragma once

class RowContainer {
public:
    void fill_row(char * inp);

    ~RowContainer() {
        delete[] data;

    }

    char * data {};
    int rSize {};
};

class Text {
public:
    explicit Text(int size);
    ~Text(){
        delete[] rows;
    }

    void addRow(char * inp);

    void delRow(int ind);
    void erRows();
    int getCharAmount();
    int getDigAmount();
    double getDigPercentage();
    int getMaxRow();
    int filled_rows {};
    RowContainer * rows {};
};