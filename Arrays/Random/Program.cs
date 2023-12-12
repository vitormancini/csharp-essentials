// Gera um número aleatório até 100
Random random = new Random();
int numeroAleatorio = random.Next(100);

// Gera um número aleatório decimal
double flutuante = random.NextDouble();

// Gera numeros aleatório não repetidos
List<int> numeros = new List<int>();

for (int i = 0; i < 5; i ++)
{
    int sorteado;
    do
    {
        sorteado = random.Next(1, 61);
    } while (numeros.Contains(sorteado));

    numeros.Add(sorteado);
}

numeros.Sort();

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}