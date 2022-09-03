// Задача 21 HARD - необязательная
// Напишите программу, которая принимает на вход координаты точек и находит расстояние между ними в N-мерном пространстве. 
// N - задается пользователем.

double GetDistanseNDim(double[] point1, double[] point2, int dimension)
{
    double sum = 0.0;
    for (int i = 0; i < dimension; i++)
    {
        sum += Math.Pow(point2[i] - point1[i], 2);
    }
    return Math.Round(Math.Sqrt(sum), 3);
}

try
{
    Console.Write("Введите число измерений пространства:  \t");
    int dim = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координаты первой точки {dim}-мерного пространства через ' ':  \t");
    double[] a = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
    Console.Write($"Введите координаты второй точки {dim}-мерного пространства через ' ':  \t");
    double[] b = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
    Console.WriteLine($"Расстояние между точками {dim}-мерного пространства: {GetDistanseNDim(a, b, dim)}");
}
catch 
{
    Console.WriteLine("Неверный ввод!");
}