// INSTRUÇÃO goto (transfere a excução do código para uma label se uma determinada condição for satisfeita)

// Contador de 1 a 10
int i = 1;

contador: // label
    Console.WriteLine($"Valor de i: {i}");
    i++;
if (i <= 10) // condição
    goto contador;

Console.WriteLine("Fim da contagem com o goto...\n");

// INSTRUÇÃO WHILE 
// Imprime a tabuada do numero 7
int x = 0;

while (x <= 10) // condição
{
    Console.WriteLine($"7 x {x}: {7 * x}");
    x++;
}

Console.WriteLine("Fim da contagem com o while...\n");

// Inicia um loop que encerra paenas quando o usuário digitar um número ímpar
while (true)
{
    Console.Write("Digite o número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if ((numero % 2) != 0)
    {
        Console.WriteLine("Número ímpar digitado");
        break; // Encerra o loop while
    }
}

Console.WriteLine("Loop encerrado...\n");


// INSTRUÇÃO FOR
// for(inicialização; condição; iteração)

// Contador de 1 a 10
for (int y = 1; y <= 10; y++)
{
    Console.WriteLine($"Valor de y: {y}");
}

// Múltiplas expressões
for (int a = 0, b = 0; a + b <= 20; a++, b++)
{
    Console.WriteLine($"a = {a} e b = {b}");
}

// Instrução break, assim como no while, encerra o loop

// Instrução continue "pula" uma iteração
for (int c = 10; c >=0; c--)
{
    if (c % 2 == 0)
        continue;

    Console.WriteLine($"Apenas ímpares: {c}");
}