// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]}\t");
    }
    Console.WriteLine();
}

Console.Clear();
string[] initArr = { "a", "abcdef", "ghijkl", "mn", "opq" };
Console.Write("Заданный массив: ");
PrintArray(initArr);
string[] finArr = new string[initArr.Length];
int j = 0;
for (int i = 0; i < initArr.Length; i++)
{
    if (initArr[i].Length < 4)
    {
        finArr[j] = initArr[i];
        j++;
    }
}
Array.Resize(ref finArr, j);
Console.Write("Полученный массив: ");
PrintArray(finArr);