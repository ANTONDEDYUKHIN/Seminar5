/* Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний 
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21  */
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
int[] array = CreateArrayRndInt(6, 1, 10);
PrintArray(array);
int[] compositionArray(int[] array)
{
    int size1 = 0;
    if (array.Length % 2 == 0) size1 = array.Length / 2;
    else size1 = (array.Length/2) + 1;
    int[] result = new int[size1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0) result[size1 - 1] = array[array.Length / 2];
    return result;
}
int[] result = compositionArray(array);
PrintArray(result);