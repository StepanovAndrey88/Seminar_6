// 
// Домашнее задание №6

// Задача 41: Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// Пример:
// 0,7,8,-2,-2->2
// -1,-7,567,89,223->3

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numArr = new int[size];
// int[] numArr = new int[]{34;5;9}; - если мы хотим заполнить массив сами
int positiveNum=0;
for(int i=0; i<numArr.Length;i++)
{
    Console.Write("Введите элемент массива: ");
    numArr[i] = Convert.ToInt32(Console.ReadLine());
    if(numArr[i]>0)
    {
        positiveNum++;
        // positiveNum+=numArr[i] - альтернативный вариант предыдущей записи
    }
}
Console.WriteLine(String.Join(",",numArr)+
"\n Кол-во положительных чисел = "+positiveNum);

 
// Задача 43 Напишите программу, 
// которая найдет точку пересечения двух прямых, 
// заданных уравнениями y=k1*x+b1,y=k2*x+b2;
// значения b1,k1,b2 и k2 задаются пользователем.
// Пример:
// b1=2, k1=5, b2=4, k2=9->(-0,5;-0,5)

Console.Write("Дано уравнение: y=k1*x+b1,y=k2*x+b2");
Console.WriteLine("");
Console.WriteLine("Введите число b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;
x = (b2-b1)/(k1-k2);
y = k1*x+b1;
Console.WriteLine($"Точка пересечения двух прямых: [{x};{y}]");
