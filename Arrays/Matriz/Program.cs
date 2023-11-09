// Declaa uma matriz de números inteiros com 3 linhas e 3 colunas
int[,] matrizInteiros = new int[3, 3]
{
    {1,2,3}, 
    {4,5,6}, 
    {5,6,7}
};

// Itera sobre a matriz
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrizInteiros[i,j] + ",");
    }
    Console.WriteLine();
}

// Usando o foreach
foreach (int n in matrizInteiros)
{
    Console.WriteLine(n);
}