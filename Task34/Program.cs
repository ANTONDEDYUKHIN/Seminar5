/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
Console.Clear();
int[] CreateArrayRndInt(int size, int min, int max)// метод создания массива (размер, мин, макс число интервала)
{// начало тела метода
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)//цикл расчета значений массива по индексу о "0" до "размера"
{
    array[i] = rnd.Next(min, max+1);//расчет значений массива по индексу о "0" до "размера"
}
return array;//возваращение в начало цикла
}// конец тела метода

void PrintArray(int[] array)// метод вывода массива на консоль
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
int[] randomArray = CreateArrayRndInt(5, 100, 999);
int Count(int[] randomArray)
{
    int count = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
        count++;
    }
    return count;
}

PrintArray(randomArray);
Console.WriteLine(Count(randomArray));