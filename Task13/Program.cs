// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Random rand = new Random();
int randNumber = rand.Next();  //Получить очередное случайное число

System.Console.WriteLine(randNumber);

if(randNumber>99)
{
       System.Console.WriteLine(randNumber.ToString()[2] + " "); //ToString служит для получения строкового представления данного объекта. Для базовых типов просто будет выводиться их строковое значение
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}

