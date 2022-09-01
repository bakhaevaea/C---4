using System;

class MyNewClass
{
       //Напишите цикл, который принимает на вход два числа (A и B)
    // и возводит число A в натуральную степень B.
    public static  int MyPow(int numA, int numB)
    {
        int result = 1;
        for (int i = 1; i <= numB; i++)
            result = result * numA;
        return result;
    }

    static void Main()
    {

        Console.WriteLine("Введите первое число");
        int numberA= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        int numberB= Convert.ToInt32(Console.ReadLine());

       int PowAB = MyPow(numberA, numberB);
       Console.WriteLine(PowAB);
    }

 
}