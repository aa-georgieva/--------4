/* // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int FiguresQuantity(int num)
{
    int length = 0;
     while (num % 10 != 0)
    {
        num /= 10;
        length++;
        }
return length;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число цифр {FiguresQuantity(num)}");
*/

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

/*
int MultiN(int num)
{
    int multy = 1;
    for(int i = 1; i <= num; i++)
    {
        multy=multy*i; 
    }
    return multy;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Произведение {MultiN(num)}");
*/

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int RandomOneZero(int [] num)
{
    int [] num = {};
    int randomNum = new Random().Next(0,2);
}