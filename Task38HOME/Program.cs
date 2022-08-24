/* Задайте массив вещественных чисел. Найдите разницу
 между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/
Console.Clear();
double[] CreateArrayRndDouble(int size, int min, int max)
{
double[] array = new double[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(min, max+1);
}
return array;
}

void PrDoubleArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}
double[] randomArray = CreateArrayRndDouble(10, 0, 200);
    double MinNum = randomArray[0];
        for (int i = 1; i < randomArray.Length; i++)
    {
        if (MinNum > randomArray[i])MinNum = randomArray[i];
    
    }
    
    double MaxNum = randomArray[0];
    for (int i = 1; i < randomArray.Length; i++)
    {
        if (MaxNum < randomArray[i]) MaxNum = randomArray[i];
            
    }
double delta = MaxNum - MinNum;
PrDoubleArray(randomArray);
Console.WriteLine($"Максимальное число массива: {MaxNum}");
Console.WriteLine($"Минимальное число массива: {MinNum}");
Console.WriteLine($"Разница между максимальным и минимальным числами массива: {delta}");