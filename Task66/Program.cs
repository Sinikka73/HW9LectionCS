// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumOfNumbers(int M, int N)
{
    if(N == M)
    {
        return M;
    }
    return SumOfNumbers(M, N -1) +N;
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = SumOfNumbers(M, N);
Console.Write($"Сумма элементов от М до N: {result}");