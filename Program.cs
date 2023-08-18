// int[] FillArray()
// {
//     int size = new Random().Next(0, 20);
//     // int size = 9;
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 999);

//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}");
//     Console.Write("]");
// }

// void PrintNomberNombresPair(int[] array)
// {
//     int nomber = 0;
//     if (array.Length % 2 == 0)
//     {
//         nomber = array.Length / 2;
//     }
//     else
//     {
//         nomber = array.Length / 2 + 1;
//     }
//     Console.WriteLine($"Количество чётных чисел в массиве {nomber}");
// }
// int[] result = FillArray();
// PrintArray(result);
// Console.WriteLine();
// PrintNomberNombresPair(result);

// int[] FillArray()
// {
//     int size = new Random().Next(0, 10);
//     // int size = 3;
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 999);

//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}");
//     Console.Write("]");
// }

// void PrintNomberNombresPair(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i = i + 2)
//     {
//         if (i % 2 == 0)
//         {
//             sum = sum + array[i];
//         }
//     }

//     Console.WriteLine($"Сумма чётных чисел в массиве {sum}");
// }

// int[] result = FillArray();
// PrintArray(result);
// Console.WriteLine();
// PrintNomberNombresPair(result);

int[] FillArray()
{
    int size = new Random().Next(0, 10);
    // int size = 3;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);

    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

void PrintNomberNombresPair(int[] array)
{
   int min = array[0];
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    int difference = max - min;
    Console.Write($"Разница между максимальным значением {max} и минимальным значением {min} равна {difference}");
}

int[] result = FillArray();
PrintArray(result);
Console.WriteLine();
PrintNomberNombresPair(result);

