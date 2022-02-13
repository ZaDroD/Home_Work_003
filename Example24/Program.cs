// 24 Найти кубы чисел от 1 до N

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int n = 1;

while (n <= num)
{
    Console.Write(n* n* n);
    n ++;
}
