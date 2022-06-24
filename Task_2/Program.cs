// Задайте одномерный массив, заполненный случайными числами
// Найдите сумму элементов, стоящих на нечетных позициях.


int [] FillArray()
{
    int [] array = new int [6];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
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

void Summa (int [] array)
{   int s = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)  // Индекс данного числа при делении на два не должен давать остаток 0
        {
            s = s + array[i];
        }
    }
    Console.WriteLine ($"Сумма элементов стоящих на нечетных позициях = {s}");
}
int [] Four = FillArray();
PrintArray(Four);
Summa(Four);