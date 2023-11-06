/*
 Retornam sempre um booleano
 == igual a
!= diferente de
> maior que
< menor que
>= maior ou igual a
<= menor ou igual a

 */

int x = 10;
int y = 20;

bool igualdade1 = x == y; // false
bool igualdade2 = x != y; // true
bool igualdade3 = x > y; // false
bool igualdade4 = x < y; // true
bool igualdade5 = x >= y; // false
bool igualdade6 = x <= y; // true

string a = "Curso";
string b = "curso";

bool igualdade7 = a == b; // false
bool igualdade8 = a.Equals(b); // false


// OPERADORES LÓGICOS
/*

&& - and (retorna true se todas as condições forem satisfeitas)
|| - or (retorna true se pelo uma condição for satisfeita)
! - not (retorna true se a condição for false)

 */