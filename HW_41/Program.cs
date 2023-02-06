/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int getUserData(string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int[] generateArray(int number)
{
    int[] array = new int[number];
    for(int i = 0; i < number; i++)
    {
        array[i] = getUserData($"Введите {i+1} число");
    }
return array;
}

int findPositive(int [] array, int number)
{
    int count = 0;
    for(int i = 0; i < number; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
return count;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int number = getUserData("Введите сколько чисел вы будете вводить");
int[] newArray = generateArray(number);
int result = findPositive(newArray, number);
printArray(newArray);
Console.WriteLine($"Вы ввели {result} положительных числа");
