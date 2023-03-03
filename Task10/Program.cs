// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

System.Console.Write("Введите число: ");
int randNumber=Convert.ToInt32(Console.ReadLine());

if(randNumber>99 && randNumber<1000)
{
    int desiredNumber = (randNumber/10)%10;         // 456/10->45, 45%10->5 или 456%100->56, 56/10->5 
    System.Console.WriteLine(desiredNumber);
}
else
{
    System.Console.WriteLine("Данное число не трехзначное");

}