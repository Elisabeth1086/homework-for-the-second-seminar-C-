// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");
int randNumber=Convert.ToInt32(Console.ReadLine());

if(randNumber>99 && randNumber<1000)  // трехзначное
{
    int x=randNumber%10;
    System.Console.WriteLine(x);
}
else if(randNumber>999 && randNumber<10000)  //четырехзначное
{
    int x=(randNumber/10)%10;
    System.Console.WriteLine(x);
}
else if(randNumber>9999 && randNumber<100000)  //пятизначное
{
    int x=(randNumber/100)%10;
    System.Console.WriteLine(x);
}
else if(randNumber>99999 && randNumber<1000000)  //шестизначное
{
    int x=(randNumber/1000)%10;
    System.Console.WriteLine(x);
}
else if(randNumber>999999 && randNumber<10000000)  //семизначное
{
    int x=(randNumber/10000)%10;
    System.Console.WriteLine(x);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}

