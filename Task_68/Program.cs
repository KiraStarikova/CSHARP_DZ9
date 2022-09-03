// Напишите программу вычисления функции Аккермана с
//помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29


Console.WriteLine("Введите начальное число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int N = Convert.ToInt32(Console.ReadLine());

int AckFunction (int M, int N)
{
    if (M == 0) 
        return N + 1;
    if ((M > 0) && (N == 0)) 
        return AckFunction(M - 1, 1);
    else 
        return AckFunction(M - 1, AckFunction(M, N - 1));

}

Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckFunction(M, N)}");
