// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray()
{
    Console.Write("Введите длину массива:  \t");
    int num = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() + new Random().Next(-100, 100), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("Сгенерированный массив: \t[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}  ");
        else Console.WriteLine($"{array[i]}]");
    }
}

double GetMaxMinDifference(double[] array)
{
    double max, min;
    if (array[0] >= array[1]) {max = array[0]; min = array[1];}
    else {max = array[1]; min = array[0];}
    
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return Math.Round(max - min, 2);
}

try
{
    double[] array = FillArray();
    PrintArray(array);
    Console.WriteLine($"Разница между max и min: \t{GetMaxMinDifference(array)}");
}
catch
{
    Console.WriteLine("Неверный ввод!");
}