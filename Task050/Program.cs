// Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void Find(int[,] array, int find)
{
    int m = 0;
    int n = 0;
    bool f = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
                if (find == array[i, j]) { m = i;n = j;f = true; };
                    Console.Write("{0}\t", array[i, j]); 
        }   
        Console.WriteLine();
    }
    Console.WriteLine();
    if (f)
    Console.WriteLine($"Число найдено. Строка {m+1} Столбец {n+1}");
    else
    Console.WriteLine("Число не найдено");
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int m = new Random().Next(1, 11);
int n = new Random().Next(1, 11);
int [,] numbers = new int [m, n];

FillArrayRandomNumbers(numbers);

Find(numbers, number);
