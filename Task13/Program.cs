// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");
int randNumber=Convert.ToInt32(Console.ReadLine());

int i=randNumber;

while(i !=0)
{
    if(randNumber>99)
    {
        int a=i%10;
        i=i/10;
        System.Console.Write(a);
    }
    else
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
}