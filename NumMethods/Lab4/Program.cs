using System;

namespace lab4_dan
{
    class Program
    {
        static double[,] matrixMultiplication(double[,] matrixA, double[,] matrixB)
        {
            int s = matrixA.GetLength(1); // ==== Переменная для компактности записи
            double[,] AxB = new double[s, s]; // ==== Создаем матрицу произведения
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    AxB[i, j] = 0;
                    for (int c = 0; c < s; c++)
                    {
                        AxB[i, j] += matrixA[i, c] * matrixB[c, j];
                    }
                }
            }

            return AxB;
        }


        static void printMatrix(double[,] matrix) // ==== Функция для выведения матрицы на экран
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0:f6}", matrix[i,j]) + "\t  ");
                }

                Console.WriteLine();
            }
        }

        static double[,] matrixMConstruction(double[,] mA, int index) // ==== Функция для расчета матрицы М
        {
            int col = index - 1; // ==== Вычисляем индекс нужного элемента
            int s = mA.GetLength(1); // ==== Переменная для компактной записи
            double[,] matrixM = new double[s,s]; // ==== Создание самой матрицы М
            for (int i = 0; i < s; i++)
            {
                matrixM[i, i] = 1; // ==== Элементы главной диагонали становятся равны 1
                if (i == col) // ==== Для расчета элемента на позиции нужного
                {
                    matrixM[index - 1, i] = 1 / mA[index, col];
                }
                else
                {
                    matrixM[index - 1, i] = -mA[index, i] / mA[index, col];
                }
            }

            return matrixM;
        }

        static double[,] invMatrixMConstruction(double[,] mA, int index) // Функция для построения M^-1
        {
            int s = mA.GetLength(1);
            double[,] invM = new double [s, s];

            for (int i = 0; i < s; i++)
            {
                invM[i, i] = 1;
                invM[index - 1, i] = mA[index, i];
            }

            return invM;
        }

        static void danilevskyMethod(double[,] A)
        {
            double[,] matrixM;
            double[,] invMatrixM;

            int size = A.GetLength(1);
            int index = size - 1;

            for (int i = 1; i < size; i++)
            {
                matrixM = matrixMConstruction(A, index);
                invMatrixM = invMatrixMConstruction(A, index);
                --index;

                Console.WriteLine("\n======================\n");
                Console.WriteLine($"{i}'s iteration : \n");
                Console.WriteLine("Matrix M : \n");
                printMatrix(matrixM);
                Console.WriteLine();

                Console.WriteLine("Matrix M^-1 : \n");
                printMatrix(invMatrixM);
                Console.WriteLine();

                A = matrixMultiplication(invMatrixM, A);
                A = matrixMultiplication(A, matrixM);
                Console.WriteLine("Matrix A : \n");
                printMatrix(A);
                Console.WriteLine();
            }

            Console.WriteLine("Frobenius Matrix : ");
            printMatrix(A);
        }
        
        static void Main(string[] args)
        {
            // ==== Параметры матрицы====
            double t = 8;
            double k = 3*(3 - 4) + 2;
            double a = 0.11 * t;
            double b = 0.02 * k;
            double g = 0.02 * k;
            double d = 0.015 * t;
            // ==== 
            double[,] matrixA =
            {
                {6.26 + a, 1.10 - b, 0.97 + g, 1.24 - d},
                {1.10-b, 4.16-a, 1.30, 0.16},
                {0.97+g, 1.30, 5.44, 2.10},
                {1.24-d, 0.16, 2.10, 6.10-a}
            };
            
            
            // ==== Выведение начальной матрицы на экран
            
            Console.WriteLine("\n\t : : : Starting Matrix A : : : \t\n");
            printMatrix(matrixA);
            Console.WriteLine("\n");

            // ==== Используем метод Данилевского

            danilevskyMethod(matrixA);
        }
    }
}
