﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

int a;
int i;

//вводим число
Console.Write("введите число: " );

a = Convert.ToInt32(Console.ReadLine());

//for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])

for ( i = 1; i <= a; i++) //создаем условие, где i - это счётчик который будет перебирать числа, а - число которое ввел пользователь, i++ прибавляет +1 к каждому кругу цикла
{ //относится к For
    if ((i % 2) == 0) // с помощью этого дейтвия у нас происходит перебор четных чисел которые делятся на 2
    {//относится к if
        Console.WriteLine(i); //пишем i в вывод данных так как i - переберет всё числа от 1 до числа который ввел пользователь
    }//относится к if
}//относится к For
