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

