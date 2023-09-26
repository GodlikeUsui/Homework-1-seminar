// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Enter 1st number");
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter 2nd number");
// int number2 = int.Parse(Console.ReadLine());

// if (number1 > number2)
// {
//     Console.WriteLine("max = " + number1);
//     Console.WriteLine("min = " + number2);
// }
// else if (number1 < number2)
// {
//     Console.WriteLine("max = " + number2);
//     Console.WriteLine("min = " + number1);
// }
// else if (number1 = number2)
// Console.WriteLine ("equal");
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22






// int  Max(int arg1, int arg2 , int arg3)
// {
//     int result = arg1 ;
//     if(arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// Console.WriteLine("Enter 1st number");
// int a1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter number");
// int b1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter number");
// int c1 = int.Parse(Console.ReadLine());
// int max = Max(a1,b1,c1);
// Console.WriteLine("max is " + max);




// Console.WriteLine("Enter 1st number");
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter 2nd number");
// int number2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter 3rd number");
// int number3 = int.Parse(Console.ReadLine());

// int max = number3 ;

// if (number1 > max) max = number1;
// if (number2 > max) max = number2;
// if (number3 > max) max = number3;

// Console.Write("max = ");
// Console.WriteLine(max);

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
    
        //    Console.WriteLine("enter a number");
        //    int number = int.Parse(Console.ReadLine());
        //    int N = 2;
        //    while ( N  <= number) ;
        //   {
        //       if (N % 2 == 0) ;
        //        N++;
        //        Console.WriteLine(N);
        //    }
          
//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("enter a number");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine(num + " -> yes");

}
else
{
    Console.WriteLine(num + " -> no");

}


