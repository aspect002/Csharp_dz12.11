//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int number1;
int number2;
int maximum;
int minimum;

//выводим текст на консоль
Console.Write("введите число: " );


//ввести number1
//ввести number2
 number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число: " );

 number2 = Convert.ToInt32(Console.ReadLine());

//создать необходимое условие для сравнения двух чисел

//сравнить два числа и определить большее и меньшее
  maximum = Math.Max(number1, number2);
  minimum = Math.Min(number1, number2);

//вывести наибольшее и наименьшее число на консоль
Console.WriteLine("a = " + number1 + " b = " + number2 + " -> max = " + maximum + " -> min = " + minimum );
