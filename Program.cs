/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// void FiveNumber() 
// {
//     int result = 0;

//     Console.Write("Введите пятизначное число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int temp = number;

//     while (number > 0) {
//         result *= 10;
//         result += number % 10;
//         number /= 10;
//         }
   
//     if (result <= 9999) Console.Write("Ошибка! Введите пятизначное число.");
//     else if (result == temp) Console.WriteLine("Да");
//     else Console.WriteLine("Нет");                 
// }

// FiveNumber();

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// double Coordinates(double x, double y, double z, double x1, double y1, double z1)
// {
//     double xLine = x1 - x;
//     double yLine = y1 - y;
//     double zLine = z1 - z;

//     double distance = xLine * xLine + yLine * yLine + zLine * zLine;
//     double result = Math.Sqrt(distance);
//     Console.Write(result);

//     return result;
// }

// Console.Write("Input number 1: "); 
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 2: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 3: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 4: ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 5: ");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 6: ");
// int zb = Convert.ToInt32(Console.ReadLine());

// Coordinates(xa, xb, ya, yb, za, zb);

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// void Cube(int n) 
// {
//     int count = 1;
//     while (count <= n)
// {
//     int cube = count * count * count;
//     Console.Write(cube + " ");  
//     count++;
// }
// }

// Console.Write("Input number: "); 
// int n = Convert.ToInt32(Console.ReadLine());

// Cube(n);