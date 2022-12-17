// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(21);
}

void Regrouping(int[,] arr, int[] arr1)
{
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr1[k] = arr[i, j];
            Console.Write($"{arr1[k]} ");
            k++;
        }
    }
}

void SortArray(int[] arr)
{
    int tmp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                tmp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tmp;
            }
        }
    }
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}

void Regrouping2(int[,] arr, int[] arr1)
{
    int k = 0;
    // for (int a = 0; a < arr1.Length; a++)
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = arr1[k];
            k++;
        }
}

Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
int[] array1 = new int[rows * cols];
int[,] array2 = new int[rows, cols];
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Regrouping(array, array1);
Console.WriteLine();
Console.WriteLine();
SortArray(array1);
Console.WriteLine();
Regrouping2(array2, array1);
Console.WriteLine();
PrintArray(array2);