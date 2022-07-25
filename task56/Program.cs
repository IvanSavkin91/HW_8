// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Task56()
{
int rows = 4;
int columns = 7;
int [,] array = new int [rows, columns];
int sum = 0;
int sumMinIndex = 0;
int sumMin = 0;
FillArray(array);
PrintArray(array);
Summin(array);


void Summin(int [,] array)
{


    for (int j = 0; j < columns; j++)
    {
        sumMin += array[0, j];
    }
    Console.WriteLine();
        Console.WriteLine($"Сумма 1-й строки равна : {sumMin}");
        for (int i = 1; i < rows; i++)
        {
            
            for (int j = 0; j < columns; j++)
            {
                sum += array[i,j];
            }
            Console.WriteLine($"Сумма {i+1}-й строки равна : {sum}");
        
                if (sum < sumMin)
                {
                 sumMin = sum;
                 sumMinIndex = i;
                }
        }
}
        Console.WriteLine();
        Console.WriteLine($"Минимальная сумма в строке {sumMinIndex + 1} и равна {sumMin} ");
        Console.WriteLine();

void FillArray(int[,] array)
{
    Random random = new Random(); 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Вывод массива " + "\t");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i< rows; i++)
        {
            for (int j = 0; j < columns; j++ )
            Console.Write(array [i, j] + "\t");
            Console.WriteLine();
        }
}

}
Task56();