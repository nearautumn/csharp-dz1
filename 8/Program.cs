Console.WriteLine("Все четные числа от 0 до заданного."); 
Console.Write("Введите целое число: "); 
int number = int.Parse(Console.ReadLine() ?? "");
int count = 0;

Console.Write($"{number} -> ");

while(count <= number)
{
    Console.Write($"{count}, ");
    count = count + 2;
} 