/* Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях (индексах).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

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
int [] GetSumEvenOddElem(int [] array)// метод расчета сумм чисел с нечетными и четными индексами
{
    int SumOdd = 0;//нечетные индексы
    int SumEven = 0;// четные индексы
    for (int i = 1; i < array.Length; i = i + 2)// цикл для нечетных индексов
    {
        SumOdd += array[i];
    }   
    for (int i = 0; i < array.Length; i = i + 2)// цикл для четных индексов
    {
        SumEven += array[i];
    }   
    return new int[] {SumOdd, SumEven};
}

int [] arr = CreateArrayRndInt(size, 0, 10);// введение конкретных параметров массива
PrintArray(arr);
int [] SumEvenOddElem = GetSumEvenOddElem(arr);
Console.WriteLine($"Сумма чисел с нечетными индексами массива = {SumEvenOddElem[0]}");
Console.WriteLine($"Сумма чисел с четными индексами массива = {SumEvenOddElem[1]}");