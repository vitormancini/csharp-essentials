/*
 
* Coleções não genéricas presentes no namespace System.Collectons (legadas)
*   ArrayList, Stack, SortedList, Queue, Hashtable, ...
*   
*   Coleções genéricas presentes no namespace System.Collection.Generic
*       List, SortedList, Stack, Queue, LinkedList, HashSet, SortedSet, Dictionary, SortedDictionary
 

 */

// Inicia um array de números inteiros com 5 posições (inicia na posição 0)
int[] arrayInteiros = new int[5] {1, 2, 3, 4, 5};

// Inicia um array de strings com 3 posições
string[] arrayStrings = new string[3] { "Palavra1", "Palavra2", "Palavra3" };

// Acessa elementos do array pelo índice
Console.WriteLine(arrayInteiros[0]); // 1
Console.WriteLine(arrayInteiros[4]); // 5
Console.WriteLine(arrayStrings[0]); // Palavra1

// Obtem a quantidade de elementos de um array
int tamanho = arrayStrings.Length; // 3

// Percorre todos os elementos de um array
for (int i = 0;i < tamanho; i++)
    Console.WriteLine(arrayStrings[i]);

// Percorrendo usando o foreach
foreach (int inteiro in arrayInteiros)
{
    Console.WriteLine(inteiro);
}

// CLASSE ARRAY

// Inverte a sequencia do array
Array.Reverse(arrayInteiros); //5,4,3,2,1

// Ordena um array
Array.Sort(arrayInteiros);

// Busca um elemento dentro de um array ordenado (retorna o indice do elemento. Se não encontrar retorna -1)
Array.BinarySearch(arrayInteiros, 3); //2

// Modificador params (podemos enviar uma lista de parâmetros para uma função)
Soma(45, 78, 98, 10);
static void Soma(params int[] numeros)
{
    int total = 0;
    foreach (int i in numeros)
    {
        total += i;
    }

    Console.WriteLine($"Soma: {total}");
}
