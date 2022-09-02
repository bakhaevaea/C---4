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

    //  Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
    // пользователь вводит число элементов в массиве и минимальное, и максимальное значение .
    //  надо заполнить массив рандоными данными от минимального до максимального значение .
    //  И важное уточнениее , делать все в методе который возвращает массив
    public static int[] NewArr()
    {
        System.Console.WriteLine("Введите размер массива ");
        int Len = int.Parse( Console.ReadLine());
        
        System.Console.WriteLine("Введите минимальное значение ");
        int MinVal = int.Parse( Console.ReadLine());
        
        System.Console.WriteLine("Введите максимальное значение ");
        int MaxVal = int.Parse( Console.ReadLine());
        
        int [] MyArr = new int [Len];
        for (int i = 0; i < Len; i++)
        {
            MyArr[i] = new Random().Next(MinVal, MaxVal+1);
        }
        return MyArr;
    }


    static void Main()
    {

        // Console.WriteLine("Введите первое число");
        // int numberA= Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Введите второе число");
        //int numberB= Convert.ToInt32(Console.ReadLine());

      // int PowAB = MyPow(numberA, numberB);
      // Console.WriteLine(PowAB);

        //   int Summa = SumNum(numberA);
        //   Console.WriteLine(Summa);

        int [] Array = NewArr();
        System.Console.WriteLine(String.Join("  ", Array));

    }

 
}