/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите 3 числа ");
int NumberA = int.Parse(Console.ReadLine());
int NumberB = int.Parse(Console.ReadLine());
int NumberC = int.Parse(Console.ReadLine());
   
    if (NumberA > NumberB && NumberA > NumberC)
    Console.WriteLine("Nubmer Max = " + NumberA); 
    else if (NumberB > NumberC)
    Console.WriteLine("Number Max = " + NumberB); 
    else
    Console.WriteLine("Number Max = " + NumberC); 