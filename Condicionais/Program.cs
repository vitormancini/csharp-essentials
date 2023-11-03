// OPERADOR TERNÁRIO (avalia uma expressão booleana)
// condição ? expressão_se_true : expressão_se_false
double temperatura = 30;
string resultado = temperatura > 27 ? "Quente" : "Frio";

int x = 10;
int y = 20;

// Conferindo várias possibilidades
string comparacao = x > y ? "x é maior" :
                    x < y ? "x é menor" :
                    x == y ? "x e y são iguais" :
                    "Sem resultado";

// INSTRUÇÃO IF ELSE (apenas uma das verificações será executada)
if (x > y)
{
    Console.WriteLine("x é maior"); // Primeira verificação
}
else if (x < y)
{
    Console.WriteLine("x é menor"); // Segunda verificação
}
else
{
    Console.WriteLine("X e y são iguais"); // Caso nenhuma das verificações nateriores sejam satisfeitas
}

// INSTRUÇÃO SWITCH CASE (apenas uma das verificações será executada)
string? nome = null;

switch (nome)
{
    case "Lucas":
        Console.WriteLine("O nome é Lucas");
    break;

    case "João":
        Console.WriteLine("O nome é João");
    break;

    case "Maria":
        Console.WriteLine("O nome é Maria");
    break;

    default: // Quando nenhum dos casos anteriores foi satisfeito
    Console.WriteLine("O nome é nulo");
    break;
}

// Quando mais de um valor satisfaz a condição
switch (nome)
{
    case "Vitor":
    case "Vinicius":
        Console.WriteLine("O nome começa com a letra V");
    break;

    case "Luis":
    case "Lucas":
    case "Lindomar":
        Console.WriteLine("O nome começa com a letra L");
    break;

    default:
    Console.WriteLine("O nome é nulo");
    break;
}