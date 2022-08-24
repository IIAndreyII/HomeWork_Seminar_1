// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.Write("Введите число 1 - ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2 - ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2)
{
    Console.WriteLine("Числа равны.");
}
if(number1 > number2)
{
     Console.Write("Большее число - ");
     Console.WriteLine(number1);

     Console.Write("Меньшее число - ");
     Console.WriteLine(number2);
}
if(number1 < number2)
{
     Console.Write("Большее число - ");
     Console.WriteLine(number2);

     Console.Write("Меньшее число - ");
     Console.WriteLine(number1);
}

