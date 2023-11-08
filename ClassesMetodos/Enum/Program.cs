/*
 * Usamos enum quando queremos definir constantes relacionadas (tipo de valor)
 * Por padrão, os valores associados aos elemtos de um enum são do tipo int. O primeiro tem valor 0 e cada elemento seguinte tem seu valor incrementado em 1
*/

// Exibe os elementos
Console.WriteLine(Categoria.Esportes); // Esportes
Console.WriteLine(Categoria.Eletrônicos); // Eletrônicos

Console.WriteLine(CodigoErro.ConexaoFalhou); // ConexaoFalhou

// Exibe o elemento e seu valor
Console.WriteLine($"Elemento: {Categoria.Esportes} - Valor: {(int)Categoria.Esportes}"); // Fazemos um cast do elemento para obter seu valor
Console.WriteLine($"Elemento: {CodigoErro.DadosInvalidos} - Valor: {(int)CodigoErro.DadosInvalidos}");

// Itera sobre os elementos de um enum
var categorias = Categoria.GetValues(typeof(Categoria));
foreach (var categoria in categorias)
{
    Console.WriteLine(categoria);
    Console.WriteLine((int)categoria);
}

// Obtem um elemento pelo valor
Console.Write("Selecione a categoria: ");
int valor = Convert.ToInt32(Console.ReadLine());
var elementoCategoria = (Categoria)valor;

Console.WriteLine($"Você selecionou a categoria {elementoCategoria.ToString()}");

enum Categoria
{
    Esportes,
    Eletrônicos,
    Presentes,
    Limpeza,
    Higiene
}

enum CodigoErro
{
    Nenhum = 0,
    Desconhecido = 1,
    ConexaoFalhou = 100,
    DadosInvalidos = 200
}


