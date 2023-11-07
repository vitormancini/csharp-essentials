/*
 
 Diferente das classes, as esruturas de dados Structs são tipos de valor, e não de referência. Portanto, são criadas na memória Stack.
 São uma alternativa mais leve para as classes
 
 */

// Instancia a struct
Pessoa pessoa = new Pessoa("Vitor", 29);
pessoa.Falar();

public struct Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    } 

    public void Falar()
    {
        Console.WriteLine($"A pessoa {Nome} da Struct está falando");
    }
}