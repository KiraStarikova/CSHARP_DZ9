// Задайте значения M и N. Напишите программу, которая
//выведет все натуральные числа в промежутке от M до N.

void PrintNumbers(int m, int n)
{
    if(m > n)
    return;

    Console.Write($"{m} ");

    PrintNumbers(m + 1, n);

}

PrintNumbers(3,9);

Console.WriteLine();