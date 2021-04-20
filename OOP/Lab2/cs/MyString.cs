using System;

namespace myStringLib
{
    public class RowContainer
    {
        public void fill_row(char [] inp)
        {
            rSize = inp.Length;
            data = new char [rSize];
            for (var i = 0; i < inp.Length; i++)
                data[i] = inp[i];
        }

        public char [] data;
        public int rSize;
    }

    public class Text
    {
        private int _filledRows;
        public readonly RowContainer[] Rows;

        public Text(int size)
        {
            Rows = new RowContainer [size];
        }

        public void addRow(char[] inp)
        {
            Rows[_filledRows].fill_row(inp);
            _filledRows++;
        }

        public void delRow(int index)
        {
            for (var i = index; i < _filledRows; i++)
            {
                (Rows[i], Rows[i + 1]) = (Rows[i + 1], Rows[i]);
            }

            Rows[_filledRows].data = "".ToCharArray();
            Rows[_filledRows].rSize = 0;
            _filledRows--;
        }

        

        public void erRows()
        {
            for (var i = 0; i < _filledRows; i++)
            {
                Rows[i].data = "".ToCharArray();
                Rows[i].rSize = 0;
            }

            _filledRows = 0;
        }

        public int getCharAmount()
        {
            int charCounter = 0;
            for (int i = 0; i < _filledRows; i++){
                charCounter+=Rows[i].rSize;
            }
            return charCounter;
        }

        public double getDigAmount()
        {
            double cnt = 0;
            for (int i = 0; i < _filledRows; i++){
                for (int j = 0 ; j < Rows[i].rSize; j++){
                    if(Char.IsDigit((Rows[i].data[j]))){
                        cnt++;
                    }
                }
            }
            return cnt;
        }

        public double getDigPercentage()
        {
            return (getDigAmount() / (double) (getCharAmount()) * 100);
        }

        public int getMaxRow()
        {
            int index = 0;
            for (int i = 0; i < _filledRows; i++){
                if (Rows[i].rSize > Rows[index].rSize)
                    index = i;
            }
            return index;
        }


    }
}