// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void InputArray(double[] array)
{
    for (int i =0; i < array.Length; i++)
        array[i] = new Random().Next(0, 21);
}

void PrintArray(double[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.Clear();
Console.Write($"n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
PrintArray(array);
Console.WriteLine($"Разница равна {array[array.Length - 1] - array[0]}");