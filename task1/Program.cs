// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
while (true)
{
    Console.WriteLine("Введите целое число или 'q' если хотите закончить: ");
    string input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    int num;
    if(int.TryParse(input, out num))
    {
        int sum = 0;
        while (num > 0)
        {
            sum = sum + num%10;
            num /= 10;
        }
        if(sum%2==0)
        {
            break;
        }
    }
}