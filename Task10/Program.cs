// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Random rand = new Random();
int randNumber = rand.Next(100,1000);

System.Console.WriteLine(randNumber);

int desiredNumber = (randNumber/10)%10;  // 456/10->45, 45%10->5 или 456%100->56, 56/10->5 

System.Console.WriteLine(desiredNumber);

//Должна быть проверка, что число трехзначное..число не трехзначное