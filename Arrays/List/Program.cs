/*
 
 É equivalente a coleção ArrayList, porém é mais eficiente e deve ser utilizada.
 Uma List pode ser declarada com um tipo específico ou como uma List genérica (List<T>)
 São do tipo de referência (memória Heap)
 
 */

// Instancia a lista
List<string> listaStrings = new List<string>();

// Adiciona elementos no final
listaStrings.Add("Vitor");
listaStrings.Add("Lucas");
listaStrings.Add("Maria");

int tamanho = listaStrings.Count; // 3
int capacidade = listaStrings.Capacity; // 4

// Itera sobre a lista
foreach (string elemento in listaStrings)
{
    Console.WriteLine(elemento);
}

// Adiciona no inicio
listaStrings.Insert(0, "João");

// Remove elemento (primeira ocorrência)
listaStrings.Remove("Vitor");

// Remove por posição
listaStrings.RemoveAt(2);

// Remove um range (inicio, quantidade)
listaStrings.RemoveRange(1, 1);

// Remove todos os elementos
listaStrings.Clear();

// Acessa elemento pelo indice
string str = listaStrings[1];

// Veirifica se elemento está na lista (retorna true caso exista e false caso não exista)
listaStrings.Contains("João");

// Ordena ascendente
listaStrings.Sort();

// Retorna o primeiro elemento que corresponde ao predicado fornecido (FindLast retorna o ultimo) EXPRESSÃO LAMBDA
listaStrings.Find(item => item.Contains("a")); // primeiro elemento com a

// Retorna o index do primeiro elemento encontrado (retorna -1 se não encontrar) (FindLastIndex retorna o indice do ultimo)
listaStrings.FindIndex(item => item.Contains("tor"));

// Retorna todos os elementos que correspondem a busca
listaStrings.FindAll(item => item.StartsWith("V")); // Encontra todos que começam com V (retorna uma lista)

// IEnumerables: são listas read-only, nas quais não conseguimos acessar os elementos diretamente pelo indica (é necessário fazer um cast ToList())
// IEnumerables não carregam todos os elementos da coleção na memória, isso é vantajoso para quando o retorno for uam lista com muitos elementos
// Os elementos são carregados na memória apenas se fizermos o cast para ToList()
var nomes = listaStrings.Where(nome =>  nome.Contains("a")); // Retorna os nomes que possuem letra a

// nomes[0]; causaria um erro em tempo de compilação

var nomesList = nomes.ToList();

string a = nomesList[0];