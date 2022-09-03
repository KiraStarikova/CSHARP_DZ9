//Задайте значения M и N. Напишите программу, которая
//найдёт сумму натуральных элементов в промежутке от M до N.

//Console.WriteLine("Введите начальное число M: ");
//int M = int.Parse(Console.ReadLine());

//Console.WriteLine("Введите последнее число N: ");
//int N = int.Parse(Console.ReadLine());

void NumbersSum (int M, int N, int sum)
{
    if (M <= N)
    {
         sum = sum + (M++);
        NumbersSum(M, N, sum);
        return;
    }

    Console.WriteLine($"Сумма натуральных элементов: {sum}");
     
}

NumbersSum(3, 7, 0);