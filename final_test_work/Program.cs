// Написать программу, которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями. Лучше обойтись исключительно массивами.

// Примеры:
// ["hello","2","world",":-)"]->["2",":-)"]
// ["1234","1567","-2","computing science"]->["-2"]
// ["Russia","Denmark","Kazan"]->[]

string[] CreateArrayString(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i} строку: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] array, bool limitedString)
{
    if (limitedString)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
                Console.Write("[");
            if ((array[i].Length) <= 3)
            {
                if ((i != 0) && (!limitedString))
                    Console.Write(", ");

                Console.Write($"{array[i]}");
                limitedString = false;
            }
        }
        Console.WriteLine("]");
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
                Console.Write("[");
            if (i < array.Length - 1)
                Console.Write(array[i] + ", ");
            else
                Console.Write(array[i] + "] -> ");
        }
    }

}

Console.Clear();

Console.Write("Введите количество элементов массива строк: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] arrayString = CreateArrayString(num);

PrintArray(arrayString, false);
PrintArray(arrayString, true);
