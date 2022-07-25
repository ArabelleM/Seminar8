// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


void FillMatrix(int[,] matr) {
    for(int i = 0; i < matr.GetLength(0); i++) {
        for(int j = 0; j < matr.GetLength(1); j++) {
            matr[i, j] = new Random().Next(-10, 10);
        }
    }
}

void PrintMatrix(int[,] mat) {
    for(int i = 0; i < mat.GetLength(0); i++) {
        for(int j = 0; j < mat.GetLength(1); j++) {
            Console.Write(mat[i, j] + "\t");
        }
    Console.WriteLine("");
    }
}

int[,] SortMatrix(int[,] matrix1, int m1) {
    if (m1 == matrix1.GetLength(0)) return (matrix1);
    for(int k = 0; k < matrix1.GetLength(1) - 1; k++) {
        for(int g = k + 1; g < matrix1.GetLength(1); g++){
            if(matrix1[m1, k] > matrix1[m1, g]) {
                (matrix1[m1, g], matrix1[m1, k]) = (matrix1[m1, k], matrix1[m1, g]);
            }
        }
    }
    return SortMatrix(matrix1, m1 + 1);
}

int m = 5;
int n = 5;
int[,] matrix = new int[m, n];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix, 0); // 0 - строчка, с которой начинаем
PrintMatrix(matrix);


