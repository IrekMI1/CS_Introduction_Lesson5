// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillPrintArray()
{
    Console.Write("Введите длину массива:\t");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[num];
    Console.Write("[");
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(100,1000);
        if (i != num - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
    Console.WriteLine();
    return array;
}

int EvenElementCount(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if(item % 2 == 0) count++;
    }
    return count;
}

try
{
    int[] array = FillPrintArray();
    Console.WriteLine($"Количество четных элементов в массиве: {EvenElementCount(array)}");
}
catch 
{
    Console.WriteLine("Неверный ввод!");
}