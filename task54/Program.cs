// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Task54()
{
int rows = 4;
int columns = 7;
int [,] array = new int [rows, columns];
FillArray(array);
PrintArray(array);
Sort(array);


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
void Sort(int[,] array)
{
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < columns - j - 1; k++)
        {
            if (array [i,k] < array [i, k + 1])
            { 
                int temp = array [i,k];
                array [i,k] = array [i, k +1];
                array [i, k +1] = temp;
            }
        }

    }
}
}
PrintArray(array);
}
Task54();