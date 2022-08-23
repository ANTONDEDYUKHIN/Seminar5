/* Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в 
отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */
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
int[] randomArray = CreateArrayRndInt(123, 0, 200);
int Count(int[] randomArray)
{
    int count = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] >= 10 && randomArray[i] <= 99)
        count++;
    }
    return count;
}

PrintArray(randomArray);
Console.WriteLine(Count(randomArray));