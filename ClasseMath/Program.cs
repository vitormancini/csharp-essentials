// OPERADORES ARTMÉTICOS
/*
 
+ adição
- subtração
* multipliacação
/ divisão
% módulo (resto da divisão)

Math.Sqrt(x) raiz quadrada
Math.Pow(x,y) exponenciação
Math.Max(x,y) valor máximo
Math.Min(x,y) valor mínimo

 */

Console.Write("Informe o primeiro número: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o segundo número: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int soma = n1 + n2;
int subtracao = n1 - n2;
int multiplicacao = n1 * n2;
float divisao = n1 / n2;
double potenciacao = Math.Pow(n1, n2);
int max = Math.Max(n1, n2);
int min = Math.Min(n1,n2);

Console.WriteLine($"Soma: {soma}\nSubtração: {subtracao}\nMultiplicação: {multiplicacao}\nDivisão: {divisao}\nPotenciação: {potenciacao}\nMax: {max}\nMin: {min}");

// Incremento de variável
int x = 10;
x++; // incrmeenta uma unidade
x = x + 5; // incrementa 5 unidades
x--; // decrementa uma unidade;
x -= 3; // decrementa 3 unidades