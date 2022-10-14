bool FindNumber(int[,,] matrix, int number)
{
    bool result = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == number) result = true;
            }
        }
    }
    return result;
}

void FillArray(int[,,] matr, int min, int max)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
          for (int k = 0; k < matr.GetLength(2); k++)
          {
               int rnd;
               do
               {
                 rnd = new Random().Next (min, max);
               } while (FindNumber(matr, rnd));
               matr[i, j, k] = rnd;
          }
       }
   }
}

void PrintArray(int[,,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
           for (int k = 0; k < matr.GetLength(2); k++)
           {
               Console.Write($" {matr[ i , j, k ]}  ");
           }
       }
   Console.WriteLine(); 
   }
}

int[,,] matrix = new int[2, 2, 2];
FillArray(matrix, 10, 99);
PrintArray(matrix);
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write(String.Format("{0}({1} {2} {3}) ", matrix[i,j,k], i, j, k));
        }
        Console.WriteLine();
    }
}