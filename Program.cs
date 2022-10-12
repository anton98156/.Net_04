// Семинар 4

/* Задача 26

Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/*
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество чисел в цифре {A} = {amount(A)}");

int amount(int A){
    int sum = 0;
    while(A>0){
        sum = sum + 1;
        A = A/10;
    }
    return sum;
}
*/

/*
**Задача 28:**

Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4  -> 24
5  -> 120
*/

/*
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до {N} = {GetSum(N)}");

int GetSum (int A){
    int sum = 1;
    for(int i = 1; i <= A; i++){
        sum = sum*i;
    }
    return sum;
}
*/

/*
**Задача 30:**

Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0]
*/

/*
int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}
*/



// HOMEWORK

/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
Console.WriteLine("введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int B = Convert.ToInt32(Console.ReadLine());

int result = A;
for (int i = 1; i < B; i++)
{
result = result * A;
}

Console.WriteLine($"A в степени В = {result}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {A} = {amount(A)}");

int amount(int A){
    int sum = 0;
    while(A>0){
        sum = sum + A%10;
        A = A/10;
    }
    return sum;
}
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(8);
    }
    return result;
}
*/