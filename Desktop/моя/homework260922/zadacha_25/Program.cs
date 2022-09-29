// Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
Console.WriteLine("введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int i = 1;
int res = 1;
while (i<b+1)
{
res = res * a;
i++;
}
Console.WriteLine(res);
