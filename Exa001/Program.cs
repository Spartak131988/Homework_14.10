void FillArray(int[,] matr, int min, int max)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
           matr[i, j] = new Random(). Next (min, max);
       } 
   }
}

void PrintArray(int[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
           Console.Write($" {matr[ i , j ]}  ");
       }
   Console.WriteLine(); 
   }
}

int rows = 4;
int columns = 4;
int[,] matr = new int[rows,columns];
int[] sum = new int[rows];
Console.Write("Массив: ");
Console.WriteLine();
FillArray(matr, 1, 10);
PrintArray(matr);
Console.WriteLine();
Console.Write("Сумма каждой строки: ");

for (int i = 0; i < rows; i++)
{
    sum[i] = 0;
    for (int j = 0; j < columns; j++)
    {
        sum[i] = sum[i] + matr[i,j];
    }
    Console.Write(sum[i] + "; ");
}

int min = sum[0];
for (int i = 0; i < sum.Length; i++)
{
    if (sum[i] < min)
    {
        min = sum[i];       
    }
}
Console.WriteLine();

int indexMin = 0; 
Console.Write("Строка с наименьшей суммой элементов: ");
for (int i = 0; i < sum.Length; i++)
{
    if (sum[i] == min)
    {
        indexMin = i;
        Console.Write((indexMin + 1) + "; ");
    }  
}