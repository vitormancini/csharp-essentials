/*
 
 Uma propriedade é a combinação de um campo privado e dois acessador, get (leitura) e set (escrita).
 Permitem uma classe expor apenas os atributo desejados e encapsular os demais.
 
 */

// Modo convencional (não utilizado mais)
public class Veiculo
{
    // Os atributos são criados de maneira privada, ou seja, apenas a própria classe tem poder de leitura e escrita
    private string marca;
    private string modelo;

    // Para permitir a leitura e escrita dos atributo em outros pontos do código, criamos os acessores get e set
    public string getMarca() // Leitura do atributo marca
    {
        return marca;
    }
    public string getModelo() // Leitura do atributo modelo
    {
        return modelo;
    }
    public void setMarca(string marca) // Escrita do atributo marca
    {
        this.marca = marca;
    }
    public void setModelo(string modelo) // Escrita do atributo modelo
    {
        this.modelo = modelo;
    }
}

// Na linguagem C# podemos criar propriedades com os acessadores get e set de maneira simplificada
public class Pessoa
{
    public string CPF { get; } // Proproedade somente leitura
    public string nome { get; set; } // Propriedade leitura e escrita
    public int idade { set { idade = value; } } // Propriedade somente escrita
}