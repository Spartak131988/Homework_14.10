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

int[,] matrixA = new int[2,2]
{
    {2, 4},
    {3, 2}
};
int[,] matrixB = new int[2,2]
{
    {3, 4},
    {3, 3}
};


int[,] matrixC = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        for (int k = 0; k < matrixB.GetLength(0); k++)
        {
            matrixC[i,j] = matrixC[i,j] + matrixA[i,k] * matrixB[k,j];
        }
    }
}
Console.WriteLine("Произведение матриц:");
PrintArray(matrixC);