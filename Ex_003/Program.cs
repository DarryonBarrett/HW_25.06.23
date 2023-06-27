// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InpitNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round((rnd.NextDouble() * 100), 2);
}  

string PrintArray(double[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += array[i]  + " ";
    }
    return res;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}

double Diff(double min, double max)
{
    return (max - min);
}

int size = InpitNum("Введите размер массива: ");
double[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
double max = FindMax(myArray);
double min = FindMin(myArray);
Console.WriteLine($"Минимальное значение - {min}, максимльное - {max}");
Console.WriteLine($"Разница между ними составляет {Math.Round((Diff(min, max)), 2)}");
