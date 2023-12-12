// Diferente do Array, o ArrayList não tem tamanho fixo, sua dimensão aumenta conforme necessidade

using System.Collections;

// Inicia um arrayList com elementos (não precisam ser do mesmo tipo)
ArrayList arrayList = new ArrayList() { "texto", 5, false, null, 5.3 };

ArrayList lista; // null
lista = new ArrayList(); // Count = 0 e Capacity = 0

// Adiciona elemento no fim da list
lista.Add("Vitor");
lista.Add("Lucas");
lista.Add("Maria");

// Adiciona elemento em um índice específico
lista.Insert(2, "João");
lista.Insert(3, "Pedro");

// A propriedade Capacity aumenta de 4 em 4 unidades. Portanto a capacidade da variavel lista é 8
int count = lista.Count; // 5
int capacity = lista.Capacity; // 8

// Podemos incluir em um array list uma coleção de elementos no final (InsertRange para inserir em um indice específico)
int[] arrayInteiros = { 1, 2, 3, 4, 5 };
lista.AddRange(arrayInteiros);

// Remoção de elementos
lista.Remove("Pedro"); // Remove a primeira ocorrência do elemento
lista.RemoveAt(3); // Remove por índice
lista.RemoveRange(0, 3); // Remove um range (remove 3 elementos partindo da posição 0)

// Verifica se um elemento existe (retorna true se existir e false se não existir)
bool contem = lista.Contains("Vitor");
