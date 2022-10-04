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