// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

System.Console.Write("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());

if(number==6 || number==7)
    {
        System.Console.WriteLine("Да");
    }
    else if(number==1 || number==2 || number==3 || number==4 || number==5)
    {
        System.Console.WriteLine("Нет");
    }
    else
    {
        System.Console.WriteLine("Такого дня недели нет");
    }