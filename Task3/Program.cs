// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Reverse(int[] array, int i)
{
    if (i < 0) return;
    Console.Write(array[i] + " ");
    Reverse(array, i - 1);
}

int[] CreateArray()
{
    int n;
    Console.WriteLine("Введите число элементов массива");
    n = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[n];
    int i = 0;

    while (i < n)
    {
        Console.WriteLine("Введите элемент массива");
        array[i] = int.Parse(Console.ReadLine());
        Console.WriteLine();
        i++;
    }

    return array;
}

int[] array = CreateArray();
Reverse(array, array.Length - 1);