// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.

double [] FillArray()
{
    double [] array = new double [6];
    double [] array1 = new double [6];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (new Random().NextDouble()) * (new Random().Next(1,101));
        array1[i] = Math.Round(array[i], 2);
    }
    return array1;
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ,");
    }
    Console.WriteLine();
}


void MaxMin(double [] array)
{   double Max = array[0];
    double Min = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }
        if (array[i] < Min)
        {
            Min = array[i];
        }
        
    }
    result = Max - Min;
    double result1 =Math.Round(result, 2);
    Console.WriteLine($"Разница max-min = {result1}");
}
double [] Four = FillArray();
PrintArray(Four);
MaxMin(Four);