// заполнение спиралью



void FillMatrixSpiral(int[,] matr) {
    int m = matr.GetLength(0);
    int n = matr.GetLength(1);
    int k = m * n; // первая цифра заполнения
    int cm = m / 2; // строка центра массива
    int cn = n / 2; // колонка центра массива
    if(n % 2 != 0) n = n - 1;
    while(k < m * n) {
        int i = 0;
        for(int j = 0; j < n; j++) {
                matr[i, j] = k;
                k++;
                if(j == n - 1) {
                     for(int i = 0; i < m; i++) {
                    matr[i, j] = k;
                    k++
                    }
                }
            }
        


        if(i == 0) {
            
        }
        for(int i = 0; i < m; i++) {
            for(int j = 0; j < n - m; j++) {
                matr[i, j] = k;
                k++;
            }
        }
    }
    for(int i = 0; i < matr.GetLength(0); i++) {
        for(int j = 0; j < matr.GetLength(1); j++) {
            matr[i, j] = new Random().Next(-10, 10);
        }
    }
    Console.WriteLine(m);
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

FillMatrixSpiral(matrix1);
PrintMatrix(matrix1);

