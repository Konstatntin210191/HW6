/* Задача 43. Напишите программу, 
которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */

double GetNumber(string msg)
{
    while(true)
    {
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();
    

        if(double.TryParse(valueFromConsole, out double number))
        {
                return number;     
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}  

double GetFindXCross(double b1, double k1, double b2, double k2)
{
    double xCross = (b2 - b1)/(k1 - k2);
    return xCross;
}

double GetFindYCross(double xCross, double k1, double b1)
{
    double yCross = k1 * xCross + b1;
    return yCross;
}

string messageB1 = "Введите длину число b1 для первой прямой: ";
double b1 = GetNumber(messageB1);
string messageK1 = "Введите длину число k1 для первой прямой: ";
double k1 = GetNumber(messageK1);
string messageB2 = "Введите длину число b2 для второй прямой: ";
double b2 = GetNumber(messageB2);
string messageK2 = "Введите длину число k2 для второй прямой: ";
double k2 = GetNumber(messageK2);

double xCross = GetFindXCross(b1, k1, b2, k2);
double yCross = GetFindYCross(xCross, k1, b1);

Console.WriteLine($"Точка пересечения дух прямых: {xCross} ; {yCross}");