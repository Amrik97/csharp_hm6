// В матрице чисел найти сумму элементов главной диагонали

Console.Write("Введите кол-во строк: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов: ");
    int m = int.Parse(Console.ReadLine()!);

    var matrix = new double[n, m];

    var sum = 0d;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            matrix[i, j] = i + j;
        }
    }

    Console.WriteLine(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (i == j)
                sum += matrix[i, j];
        }
    }

    Console.WriteLine($"Сумма элементов главной диагонали: {sum}");