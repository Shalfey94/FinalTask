// Задача: Написать программу, 
// которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа.
// Первоначальный массив можно задать с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


Console.WriteLine("Введите кол-во элементов массива:");
int count = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[count];

FillArray(array1);
PrintArray(array1);

int lengthElement = 3;
int countElements = CountElementsLessLength(array1, lengthElement);
string[] array2 = CreateArrayLessLengthElements(array1, lengthElement, countElements);
PrintArray(array2);

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length ; i++)
    {
        Console.WriteLine("Введите элемент:");
        arr[i] = Console.ReadLine();
    }

}

void PrintArray(string[] arr)
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine($"]");
}

int CountElementsLessLength(string[] arr, int lengthEl)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= lengthEl)
            count++;
    }
    return count;
}

string [] CreateArrayLessLengthElements(string [] arr,int lengthEl, int size)
{
    string [] newArr = new string [size];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= lengthEl)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}
