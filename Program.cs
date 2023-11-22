// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// РЕШЕНИЕ:
// void ShowNums(int n)
// {
//         if (n > 1)
//         {
//             System.Console.Write("{0}", n + " ");
//             ShowNums(n - 1);
//         }

//     else System.Console.Write(n + " ");

// }

// ShowNums(8);




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//     8      4

// РЕШЕНИЕ:
// int SortNumbers(int m, int n)
// {
//     if (n == m)
//     {
//         return n;
//     }
//    else return SortNumbers(m, n - 1) + n;
// }

// System.Console.WriteLine(SortNumbers(5, 7));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akkerman(int m, int n)
// {
//     if (m == 0) 
//     {
//         return n + 1;
//     }
//     else if (n == 0) 
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// Console.Write($"Функция Аккермана равно {Akkerman(3, 2)} ");