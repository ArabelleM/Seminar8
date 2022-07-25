// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillMatrix(int[,] matr) {
    for(int i = 0; i < matr.GetLength(0); i++) {
        for(int j = 0; j < matr.GetLength(1); j++) {
            matr[i, j] = new Random().Next(1, 10);
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

int[] SumOfRows(int [,] matrix2) {
    int[] sumOfRows = new int[matrix2.GetLength(0)];
    for(int i = 0; i < matrix2.GetLength(0); i++) {
        for(int j = 0; j < matrix2.GetLength(1); j++) {
            sumOfRows[i] = sumOfRows[i] + matrix2[i, j];
        }
    }
    return sumOfRows;
}

int MinRow(int[] sum) {
    int minIndex = 0;
    for(int i = 0; i < sum.Length; i++) {
        if(sum[i] < sum[minIndex]) minIndex = i;
    }
    return minIndex + 1; // при выводе считаем строки с первой, а не с нулевой (опционально)
}

int m = 5;
int n = 3;
int[,] matrix = new int[m, n];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int[] sum1 = SumOfRows(matrix); // выведем на экран все суммы строк
Console.WriteLine("Sum of rows: [" + string.Join(", ", sum1) + "]"); // for your comfort :)
Console.WriteLine("Min sum of numbers at row " + MinRow(SumOfRows(matrix)));
