// Uma classe é uma representação (modelo) de algo do mundo real

class Veiculo // Declaração
{
    public string Marca; // Atributo
    public string Modelo; // Atributo
    public int Ano; // Atributo
}

// Usamos um objeto para instanciar uma classe (modelo) que terá todos seus atributos
Veiculo v1 = new Veiculo();
v1.Marca = "Chevrolet";
v1.Modelo = "S10";
v1.Ano = 1997;

Console.WriteLine($"Veículo marca {v1.Marca} de modelo {v1.Modelo} e ano {v1.Ano}");