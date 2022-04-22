// 
void fillArray(int[,] arr, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(start, end + 1);
    }
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            // Console.Write(arr[i, j] + " ");
            Console.Write(String.Format("{0,4}", arr[i, j]));
        Console.WriteLine();
    }
    
}
//1. Сумма элементов матрицы
int SumElements(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            sum += arr[i, j];
    return sum;
}
//2 Произведение элементов  матрицы
int productElements(int[,] arr)
{
    int prod = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            prod *= arr[i, j];
    return prod;
}
//3 Максимальный  элемент  матрицы
int MaxElements(int[,] arr)
{
    int max = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] > max)
                max = arr[i, j];
    return max;
}
//4 минимальный   элемент  матрицы
int MinElements(int[,] arr)
{
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)

            if (arr[i, j] < min)
                min = arr[i, j];
    return min;
}


//5 Сумма элементов главной диагонали матрицы
int DiagonaleSum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == j) sum += arr[i, j];
    return sum;
}
//6 Произведение элементов главной диагонали матрицы
int DiagonaleProduct(int[,] arr)
{
    int prod = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == j) prod *= arr[i, j];
    return prod;
}
//7 Максимальный элемент, расположенный на главной диагонали матрицы
int DiagonaleMax(int[,] arr)
{
    int max = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == j)
                if (arr[i, j] > max)
                    max = arr[i, j];
    return max;
}
//8 Минимальный элемент, расположенный на главной диагонали матрицы
int DiagonaleMin(int[,] arr)
{    
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == j)
                if (arr[i, j] < min)
                    min = arr[i, j];
    return min;
}
//9 Сумма элементов побочной диагонали матрицы
int Diagonale2Sum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
           
            if (j== arr.GetLength(1)-1 -i)
            
               sum += arr[i,j];
           
   return sum;
}
//10 Произведение элементов побочной диагонали матрицы
int Diagonale2Product(int[,] arr)
{
    int prod = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (j== arr.GetLength(1)-1 -i)
            prod *= arr[i, j];
    return prod;
}
//11 Максимальный элемент, расположенный на побочной диагонали матрицы
int Diagonale2Max(int[,] arr)
{
    int max = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (j== arr.GetLength(1)-1 -i)
                if (arr[i, j] > max)
                    max = arr[i, j];
    return max;
}
// 12 Минимальный элемент, расположенный на побочной диагонали матрицы
int Diagonale2Min(int[,] arr)
{    
    int min = arr[0, arr.GetLength(0)-1];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (j== arr.GetLength(1)-1 -i)
                if (arr[i, j] < min)
                    min = arr[i, j];
    return min;
}

//13 Поиск минимального из максимальных элементов матрицы,

int MinMaxElements(int[,] arr)
{
    int max = 0;
    int minMax = Int32.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        max = arr[i, 0];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > max)
                max = arr[i, j];
        }
        if (minMax > max)
            minMax = max;
    }
    return minMax;
}
//14 Транспонирование для квадратной матрицы,
void replaseRowWithColumns(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr.GetLength(0) == arr.GetLength(1))
            {
                //Console.Write(arr[j, i] + " ");
                Console.Write(String.Format("{0,4}", arr[j, i]));
            }
        Console.WriteLine();
    }
}
//15 Сумма двух матриц одинаковых размерностей.
int[,] SumArray(int[,] arr, int[,] arr2)
{
    int[,] arr3 = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)

        for (int j = 0; j < arr.GetLength(1); j++)

            arr3[i, j] = arr[i, j] + arr2[i, j];

    return arr3;
}

int n = 5;
int[,] array = new int[n, n];
fillArray(array, 1, 10);
printArray(array);
Console.WriteLine($"Сумма элементов матрицы = {SumElements(array)}");
Console.WriteLine($"Произведение элементов матрицы = {productElements(array)}");
Console.WriteLine($"максимальный элемент матрицы = {MaxElements(array)}");
Console.WriteLine($"Минимальный элемент матрицы = {MinElements(array)}");
Console.WriteLine();
printArray(array);
Console.WriteLine($"Сумма элементов главной диагонали матрицы = {DiagonaleSum(array)}");
Console.WriteLine($"Произведение элементов главной диагонали матрицы = {DiagonaleProduct(array)}");
Console.WriteLine($"Максимальный элемент главной диагонали матрицы = {DiagonaleMax(array)}");
Console.WriteLine($"Минимальный элемент главной диагонали матрицы = {DiagonaleMin(array)}");
Console.WriteLine();
printArray(array);
Console.WriteLine($"Сумма элементов побочной диагонали матрицы = {Diagonale2Sum(array)}");
Console.WriteLine($"Произведение элементов побочной диагонали матрицы = {Diagonale2Product(array)}");
Console.WriteLine($"Максимальный элемент побочной  диагонали матрицы = {Diagonale2Max(array)}");
Console.WriteLine($"Минимальный элемент побочной диагонали матрицы = {Diagonale2Min(array)}");
Console.WriteLine();
printArray(array);
Console.WriteLine($"минимальный из максимальных элементов матрицы = {MinMaxElements(array)}");
Console.WriteLine();
Console.WriteLine("Транспонирование для квадратной матрицы: ");
printArray(array);
Console.WriteLine("Перевёрнутая матрица");
replaseRowWithColumns(array);
Console.WriteLine();
Console.WriteLine("Сумма двух матриц одинаковых размерностей: ");
fillArray(array, 1, 20);
int[,] array2 = new int[n, n];
fillArray(array2, 1, 20);
int[,] result = SumArray(array, array2);
Console.WriteLine($"матрица1: ");
printArray(array);
Console.WriteLine($"матрица2: ");
printArray(array2);
Console.WriteLine($"Сумма двух матриц = ");
printArray(result);