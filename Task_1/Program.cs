// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая показывает колличество четных чисел в массиве.

int [] FillArray()
{
    int [] array = new int [4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ,");
    }
    Console.WriteLine();
}

void Metod (int [] array)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) 
        {
            Count = Count +1;
        }
    }
    Console.WriteLine ($"Кол-во четных чисел в массиве = {Count}");
}



int [] Four = FillArray();
PrintArray(Four);
Metod(Four);

