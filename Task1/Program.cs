/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

int GetNumber(string msg)
{
    while(true)
    {
    Console.Write(msg);
    string valueFromConsole = Console.ReadLine();
    

        if(int.TryParse(valueFromConsole, out int number))
        {
            if(number > 0)
                return number;
                else
                {
                    Console.WriteLine("Число должно быть больше нуля. Введите другое число");
                }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля");
        }
    }
}  

int [] GetArrayManual(int length)
{
    int [] arr = new int[length];

    for(int i = 0; i < length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

string PrintArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) result = "[" + Convert.ToString(array[i]) + ", ";//string builder
        else if (i < array.Length-1)
            result = result + Convert.ToString(array[i]) + ", ";
        else result = result + Convert.ToString(array[i]) + "]";
    }
return result;
}

int GetCountPositive(int [] arr)
{
    int count = 0;

    foreach(int item in arr)
    {
        if(item > 0)
         count++;
    }
    return count;
}



string message = "Введите длину массива: ";
int length = GetNumber(message);
int[] arr = GetArrayManual(length);
string array = PrintArray(arr);
Console.WriteLine(array);
int count = GetCountPositive(arr);
Console.WriteLine($"Количество положительных чисел в массиве: {count}");




