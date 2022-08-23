/* Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */
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
bool FindNumberFave(int[] array, int number)
{
    bool j = false;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
        j = true;
        break;
        }
    }
    return j;
}

Console.Write("введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(10, 1, 10);
PrintArray(arr);
bool a = FindNumberFave(arr, num);
if (a) Console.WriteLine("Да");
else Console.WriteLine("Нет");