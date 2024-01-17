// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] array = new int[10];

void GetArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int CountEvenNumbers()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0) 
        { 
            count++; 
        }
    }
    return count;
}

GetArray();
PrintArray();
System.Console.WriteLine("Четных чисел: " + CountEvenNumbers());