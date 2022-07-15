//  Задача 2: Напишите программу,
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//1 7 -> такого числа в массиве нет

int Prompt (string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int [,] GenerateArray (int rows, int columns, int min, int max)
{
    int [,]answer = new int [rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i,j]=rnd.Next(min, max+1);
        }
    }
    return answer;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}\t");
        }
    }
    System.Console.WriteLine();
}

int rows = Prompt ("Введите количество сторок > ");

int columns = Prompt ("Введите количество столбцов > ");

int [,] MyArray = GenerateArray (rows, columns, -10, 10);

PrintArray(MyArray);

int pos1 = Prompt ("Введите строку элемента поиска > ");

int pos2 = Prompt ("Введите столбец элемента поиска > ");

if (pos1 < 0 | pos1 > MyArray.GetLength(0) - 1 | pos2 < 0 | pos2 > MyArray.GetLength(1) - 1)
            {
                Console.WriteLine("Такого элемента нет");
            }
            else
            {
                Console.WriteLine("Элемента массива = {0}", MyArray[pos1-1, pos2-1]);
            }
            
        
