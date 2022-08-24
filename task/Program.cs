using System;

Console.Write("Введите размер массива:");
int sizeArr = Convert.ToInt32(Console.ReadLine());

string[] CreateArray (int size) 
{
    string[] arr = new string[size];
    for (int i = 0; i<size; i++)
    {
        Console.Write("Введите элемент массива:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] FormatArray(string[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3){
            count++;
        }
    }
    string[] newArr = new string[count];
    int a = 0;
    for (int i = 0;  i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) {
            newArr[a] = arr[i];
            a++;
        }
    }
    return newArr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ",");
        else
            Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}


if (sizeArr>0) 
{
    string[] array = CreateArray(sizeArr);
    string[] newArray = FormatArray(array);
    PrintArray(newArray);
}
else Console.WriteLine("Некоректно введено число");