// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int FunctionAkkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return FunctionAkkerman(n - 1, 1);
    }
    else
    {
        return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
    }
}

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({n}, {m}) = {FunctionAkkerman(n, m)}");