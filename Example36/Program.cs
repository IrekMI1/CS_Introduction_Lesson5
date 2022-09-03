// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray()
{
    Console.Write("Введите длину массива:\t");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(-100,101);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Сгенерированный массив \t[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

int OddPositionSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}

try
{
    int[] array = FillArray();
    PrintArray(array);
    Console.WriteLine($"Сумма элементов на нечетных позициях: \t{OddPositionSum(array)}");
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}