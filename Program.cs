// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

int FindAmountWordsInArray(string[] array, int lengthWord)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthWord)
        {
            amount++;
        }
    }
    return amount;
}

string[] SortedArray(string[] array, int count, int lengthWord)
{
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; j < newArray.Length; i++)
    {
        if (array[i].Length <= lengthWord)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array, int lengthWord)
{
    if (array.Length == 0)
    {
        Console.WriteLine($"В данном массиве нет строк меньше, либо равным {lengthWord} символам.");
    }
    else
    {
        Console.Write($"Строки меньше, либо равные {lengthWord} символам: ");
        Console.WriteLine(String.Join(", ", array));
    }
}

void PrintTask(string[] array, int lengthWord)
{
    Console.Write("Заданный массив: ");
    Console.WriteLine(String.Join(", ", array));
    int amountWords = FindAmountWordsInArray(array, lengthWord);
    string[] sortArray = SortedArray(array, amountWords, lengthWord);
    PrintArray(sortArray, lengthWord);
    Console.WriteLine();
}

string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

int wordLenth = 3;

PrintTask(array1, wordLenth);
PrintTask(array2, wordLenth);
PrintTask(array3, wordLenth);