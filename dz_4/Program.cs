//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int numb1;
int numb2;
int numb3;
int maximum;



//выводим текст на консоль
Console.Write("введите число: " );

//ввести numb1,numb2,numb3
numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число: " );

numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число: " );
numb3 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число: " );



//создать необходимое условие для сравнения трёх чисел

//сранвить три числа и вывести максимальное из этих чисел

// Так как Math принимает только два аргумента а у нас 3 аргумента, мы в Math положили ещё один Math

 maximum = Math.Max(numb1, Math.Max(numb2, numb3));




//вывести максимальное число на консоль
Console.WriteLine("a = " + numb1 + " b = " + numb2 + " c = " + numb3 + " -> max = " + maximum);
