// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (n > 1)
{
    while(count <= n )
    {
        if(count % 2 == 0)
        {
            Console.Write(count);
            Console.Write(" ");
        }
        count++;
    }


}
if (n < 1)
{
    while(n <= 1 )
    {
        if(n % 2 == 0)
        {
            Console.Write(n);
            Console.Write(" ");
        }
        n++;
    }


}

