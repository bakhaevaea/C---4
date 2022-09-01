using System;

class MyNewClass
{
    //Задача 25. Напишите цикл, который принимает на вход два числа (A и B)
    // и возводит число A в натуральную степень B.
    public static  int MyPow(int numA, int numB)
    {
        int result = 1;
        for (int i = 1; i <= numB; i++)
            result = result * numA;
        return result;
    }

    ///Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    public static int SumNum( int num)
    {
        int result = 0;
        while (num > 0)
        {
            result +=num % 10;
            num /= 10;
        } 
        return result;
    }

    static void Main()
    {

        Console.WriteLine("Введите первое число");
        int numberA= Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Введите второе число");
        //int numberB= Convert.ToInt32(Console.ReadLine());

      // int PowAB = MyPow(numberA, numberB);
      // Console.WriteLine(PowAB);

      int Summa = SumNum(numberA);
      Console.WriteLine(Summa);
    }

 
}