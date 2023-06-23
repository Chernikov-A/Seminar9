/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
/*
Console.WriteLine("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int startNum = 1;

Console.WriteLine(PrintNumbers(numbers, startNum));
string PrintNumbers(int num1,int num2){
    if(num1 == num2){
        return num1.ToString();
    }
    return (num1 + ", " + PrintNumbers(num1-1,num2));
}
*/

/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/* Console.WriteLine("Введите значения числа M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения числа N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int PrintSummaNumber(int M, int N){
    if (M == N){
        return N;
    }
    else return (M  + PrintSummaNumber(M+1,N));
}

Console.WriteLine($"Сумма натуральных элементов: {PrintSummaNumber(numberM,numberN)}"); */

/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите значения числа M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения числа N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int FunctionsAckerman (int M, int N){
    if (M == 0) return N +1;
    else if (N == 0) return FunctionsAckerman(M - 1, 1);
    else return FunctionsAckerman(M - 1, FunctionsAckerman(M, N-1));
}
Console.WriteLine($"Значение функции Аккермана: {FunctionsAckerman(numberM, numberN)}");