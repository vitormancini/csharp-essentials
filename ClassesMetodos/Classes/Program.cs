namespace Classes;

// Uma classe é uma representação (modelo). São alocadas na memória Heap, portanto são do tipo de referência
class Veiculo // Declaração
{
    public string? marca; // Atributo
    public string? modelo; // Atributo
    public int ano; // Atributo
}

class Program
{
    static void Main(string[] args)
    {
        // Utilizamos os objetos para instaciar as classes e ter acesso aos seus atributos
        Veiculo v1 = new Veiculo();
        v1.marca = "Chevrolet";
        v1.modelo = "S10";
        v1.ano = 1997;

        Console.WriteLine($"Foi instanciado um objeto do tipo Veiculo de marca {v1.marca} e modelo {v1.modelo} e ano {v1.ano}");

        Veiculo v2 = new Veiculo();
        v2.marca = "Nissan";
        v2.modelo = "HB20";
        v2.ano = 2022;

        Console.WriteLine($"Foi instanciado um objeto do tipo Veiculo de marca {v2.marca} e modelo {v2.modelo} e ano {v2.ano}");

        Veiculo v3 = v1;

        Console.WriteLine($"Foi instanciado um objeto do tipo Veiculo de marca {v3.marca} e modelo {v3.modelo} e ano {v3.ano}");
    }
}

/*
 
 Objeto                     Memória Stack                      Memória Heap
--------                   ---------------                    --------------
 Veiculo v1                      v1               marca: Chevrolet, modelo: S10, Ano: 1997
 Veiculo v2                      v2               marca: Nissan, modelo: HB20, Ano: 2022
 Veiculo v1                      v3               marca: Chevrolet, modelo: S10, Ano: 1997

 */






