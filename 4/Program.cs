Console.Write("Введите первое целое число: "); 
int firstNumber = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе целое число: "); 
int secondNumber = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите третье целое число: "); 
int thirdNumber = int.Parse(Console.ReadLine() ?? "");

int max = firstNumber;

if(secondNumber > max) 
{
    max = secondNumber;
}

if(thirdNumber > max) 
{
    max = thirdNumber;
} 

Console.WriteLine($"a = {firstNumber}, b = {secondNumber}, c = {thirdNumber} -> max = {max}");