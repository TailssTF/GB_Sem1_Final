

//метод считывания числа с клавиатуры
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

//метод вывода массива строк
void PrintArray(string[] array)
{
    Console.Write("[");
    foreach (string e in array) Console.Write($"{e} ");
    Console.Write("]");
}


int n = GetNumber("Введите размер массива");
Console.WriteLine("Введите элементы массива");
string[] arr = new string[n];
int count = 0;

for (int i = 0; i < n; i++)
{
    arr[i] = Console.ReadLine();
    if (arr[i].Length <= 3) count++;
}

Console.WriteLine("Исходный массив:");
PrintArray(arr);

string[] arr2 = new string[count];
int k = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i].Length <= 3)
    {
        arr2[k] = arr[i];
        k++;
    }
}

Console.WriteLine("\nРезультат:");
PrintArray(arr2);