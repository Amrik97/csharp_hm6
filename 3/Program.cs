// В двумерном массиве заменить элементы, 
//у которых оба индекса чётные на их квадраты

Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine() ?? "0");

var matrix = new double[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int i = 0; i < matrix.GetLength(0); j++)
    {
        matrix[i, j] = i + j;
    }
}
Console.WriteLine(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        matrix[i, j] = Math.Pow(matrix[i, j], 2);
    }
}
Console.WriteLine(matrix);