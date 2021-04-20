using System;

namespace Training
{
    internal class StudentBase
    {
        public string[] studBase = new string[]
        {
            "Нечай Світлана Олегівна",
            "Петренко Іван Іванович",
            "Нечай Валерій Альбертович",
            "Зубенко Михайло Петрович",
            "Шевченко Тарас Григорович",
            "Цаль Віталій Віталійович",
            "Нечай Степан Костянтинович"
        };

         private bool accessToNechai = true;
         public bool accessibility
         {
             get
             {
                 return accessToNechai;
             }
             set
             {
                 if (value != accessToNechai)
                     accessToNechai = value;

             }
         }
         
         public int surnameAmount()
         {
             if (accessibility)
             {
                 int cnt = 0;
                 for (int i = 0; i < studBase.GetLength(0); i++)
                 {
                     string tmpSur = "";

                     for (int j = 0; j < 5; j++)
                     {
                         tmpSur += studBase[i][j];
                     }

                     if (tmpSur == _surname)
                     {
                         cnt++;
                     }
                 }

                 return cnt;
             }
             else
             {
                 return -1;
             }
         }

         private string _surname = "Нечай";
         
         public string this[int index]
         {
             get
             {
                 return studBase[index];
             }
         }
    }
    }