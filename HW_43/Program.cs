/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double getUserData(string message)
{
    Console.WriteLine(message);
    double UserData = double.Parse(Console.ReadLine()!);
    return UserData;
}

double getKoordinataX(double b1, double k1, double b2, double k2)
{
    double x = 0;
    x = (b2-b1)/(k1-k2);
    return x;
}

double getKoordinataY(double b1, double k1, double x)
{
    double y = 0;
    y = k1*x + b1;
    return y;
}

double b1 = getUserData("Введите значение b1 уравнения");
double k1 = getUserData("Введите значение k1 уравнения");
double b2 = getUserData("Введите значение b2 уравнения");
double k2 = getUserData("Введите значение k2 уравнения");
double x = getKoordinataX(b1, k1, b2, k2);
double y = getKoordinataY(b1, k1, x);
Console.WriteLine($"Точка пересечения двух прямых -> ({x};{y})");