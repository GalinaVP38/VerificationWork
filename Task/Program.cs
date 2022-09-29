﻿//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string [] array = new string [] {"ноль", "один","два", "три", "четыре", "пять", "6"};
Console.WriteLine("Заданный массив: " +  String.Join(", ", array));

Console.WriteLine("Новый массив:");
for (int i=0; i<array.Length; i++)
{
    int num = Convert.ToInt32(array[i].Length);
    if (num<=3) Console.Write(array[i] + " "); 
}
Console.WriteLine();