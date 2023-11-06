/*
 * A linguagem C# é estaticament tipada em tempo de compilação. 
 * Após uma variável ser declarada, não pode ser declarada novamente e não pode armazenar valores de outros tipos.
 * A menos que esse tipo seja convertido.
*/

// Conversão implícita (realizada pelo próprio compilador)
int varInteiro = 100;
double varDouble = varInteiro;

// Conversão explícita (precisa ser forçada pelo dev)
double varDouble2 = 100.4;
int varInteiro2 = (int)varDouble2; // Perdemos as casas decimais

// Numérico para string
int varInteiro3 = 55;
double varDouble3 = 55.5;

string varString1 = varInteiro3.ToString();
string varString2 = varDouble3.ToString();

/*
Classe Convert
Convert.ToString(variavel);
Convert.ToBoolean(variavel);
Convert.ToChar(variavel);
Convert.ToDouble(variavel);
Convert.ToInt32(variavel);
*/