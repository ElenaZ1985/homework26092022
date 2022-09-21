// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int Number3 = 0;
if (i < 0)
{
    i=i;
}
if (i < 100)
{
    Console.WriteLine("третьей цифры нет"); 
}    
else
{
    while (i > 1000)
    {
        i = i/10;
    }
    Number3 = i%10;
    Console.WriteLine(Number3);
}