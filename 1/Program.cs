// Показать двумерный массив размером m×n заполненный вещественными числами

Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()?? "0");

var matrix = new double[n, m];
var r = new Random();

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        matrix[i, j] = r.NextDouble();
    }
}
Console.WriteLine(matrix);