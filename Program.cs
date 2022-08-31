void MatrixGeneration(ref int[,] matrix)
{
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
            matrix[i,j] = rnd.Next(-10,10);
}

void MatrixOutput(int[,] matrix)
{
    Console.WriteLine("\n Массив:");
    for(int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
                Console.Write(matrix[i,j] + " ");
            Console.WriteLine();
        }
}

void MeanInColumn(int[,] matrix)
{   
    float mean = 0;
    Console.WriteLine("\nСреднее арифметическое число для каждого столбца соответственно:");
    for(int i = 0; i < matrix.GetLength(1); ++i)
        {
            for (int j = 0; j < matrix.GetLength(0); ++j)
                mean += matrix[j,i];

            Console.Write(Math.Round(mean/matrix.GetLength(0), 2) + "; ");
            mean = 0;
        }
}

Console.WriteLine("Введите размерность массива(строки, столбцы)");

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix= new int[m,n];

MatrixGeneration(ref matrix);
MatrixOutput(matrix);

MeanInColumn(matrix);