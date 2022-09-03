// Задача 19 HARD - необязательная
// Напишите программу, которая принимает на вход число любой размерности и проверяет, является ли оно палиндромом.

bool CheckPalindrome(ulong number)
{
    bool result = false;
    ulong left, right;
    ulong numberLength = Convert.ToUInt64(Math.Ceiling(Math.Log(number, 10)));
    uint i = 0;
    while (i <= numberLength / 2)
    {
        if (i == 0)
        {
            left = number / Convert.ToUInt64(Math.Pow(10, numberLength - 1));
            right = number % 10;
            if (left == right) i++;
            else break;
        }

        else if (i <= numberLength / 2)
        {
            left = number / Convert.ToUInt64(Math.Pow(10, numberLength - 1 - i)) % 10;
            right = number % Convert.ToUInt64(Math.Pow(10, i + 1)) / Convert.ToUInt64(Math.Pow(10, i));
            if (left == right)
            {
                if (i == numberLength / 2) result = true;
                i++;
            }
            else break;
        }
    }
    return result;
}

try
{
    Console.Write("Введите положительное целое число: \t");
    ulong num = Convert.ToUInt64(Console.ReadLine());
    if (CheckPalindrome(num) == true) Console.WriteLine("Число является палиндромом.");
    else Console.WriteLine("Число не является палиндромом.");
}
catch 
{
    Console.WriteLine("Неверный ввод!");
}