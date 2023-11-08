// Exibe texto na tela
Console.WriteLine("Hello, World!");

// Declara variável do tipo numérico inteiro e exibe na tela
int idade = 29;
Console.WriteLine("Minha idade: " + idade);

// Interpolação de strings
Console.WriteLine($"Eu tenho {idade} anos de idade");

// Declara uma variável do tipo numérico decimal
double valorDecimal1 = 12.4;
float valorDecimal2 = 12.4F;
decimal valorDecimal3 = 12.4M;

// Tipo boolean pode armazenar verdadeiro ou false
bool variavelBooleana = true;

// Armazena uma letra, apenas
char letra = 'v';
char unicode = '\u0041'; // Letra A na representação unicode

// Armazena textos
string nome = "Vítor Mancini"; // Imutável

// Tipo objetct suporta todos os demais tipos de dados
object text = "Meu texto";
object numero = 30;
object condicao = false;
object variavel = 'Z';

// Nullable Types permitem receber valores null (suportam o valor do tipo e null)
Nullable<int> i = null; // int?
Nullable<bool> b = null; // bool?

// Operador de coalescência nula
int? ab = null;
int cd = ab ?? 0; // Caso "ab" não seja nula, "cd" recebe "ab". Se "ab" for nulo, "cd" recebe 0

// Constantes (após declaradas, não podem ter seu valor alterado)
const double PI = 3.14;

// Tipo anônimo
var aluno = new
{
	Nome = "Vitor",
	Idade = 43
};


/* 
Tipos de valor (armazenam diretamente a informação e cada variável tem sua própria cópia dos dados. Os tipos de valor são armazenados na memória Stack - LIFO)
bool
char
Datetime
decimal
int
enum
byte
short
long
float
double
*/

/*
Tipos de referência (não armazenam dados diretamente, cada variável contém uma referência ao local da memória onde os dados estão armazenados. Os tipos de referência são amrazenados na memória Heap)
object
string
dynamic
class
*/


