// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Раз в условии не уточняется, принимаем, что матрицы равны по кол-ву столбцов и строк.

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

int[,] Matrix1XMatrix2(int[,] mat1, int[,] mat2) {
    int[,] matrixMult = new int[mat1.GetLength(0), mat1.GetLength(1)];
    for(int i = 0; i < mat1.GetLength(0); i++) {
        for(int j = 0; j < mat1.GetLength(1); j++) {
            matrixMult[i, j] = mat1[i, j] * mat2[i, j];
        }
    }
    return matrixMult;
}

int m = 5;
int n = 5;
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];

FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();

FillMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();

int [,] matrix = Matrix1XMatrix2(matrix1, matrix2); 
PrintMatrix(matrix);