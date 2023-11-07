/*

Os construtores são tipos especiais de métodos usados para criar e inicializar obejtos de uma classe.
Sempre que uma classe for instanciada usando a palavra new o seu construtor é chamado.
Quando não definimos um construtor, o .NET cria um construtor padrão que atribui o valor null/zero para os atributos da classe

 */

namespace Construtores;

class Program
{
    public static void Main(string[] args)
    {
        Veiculo v1 = new Veiculo("Chevrolet", "S10", 1997);
        Console.WriteLine($"Instanciado um objeto do tipo Veiculo de marca {v1.marca} modelo {v1.modelo} e ano {v1.ano} e chassi {Veiculo.chassi}.");

        // Nesta instância da classe Veiculo, o construtor estático já não será mais executado
        Veiculo v2 = new Veiculo();
        Console.WriteLine($"Instanciado um objeto do tipo Veiculo de marca {v2.marca} modelo {v2.modelo} e ano {v2.ano} e chassi {Veiculo.chassi}.");
    }

    class Veiculo
    {
        public string? marca; // Atributo
        public string? modelo; // Atributo
        public int ano; // Atributo

        public static string chassi; // Atributo estático

        // Construtor
        public Veiculo(string _marca, string _modelo, int _ano)
        {
            Console.WriteLine("Construtor COM parâmetros sendo executado");
            this.marca = _marca; // Atribui valores aos atributos que foram enviados via parâmetros
            this.modelo = _modelo;
            this.ano = _ano;
        }

        // Sobrecarga de construtores (temos mais de um construtor dentro de uma classe). Podemos criar sobrecargas para qualquer método de uma classe, não apenas para construtores
        public Veiculo()
        {
            Console.WriteLine("Construtor SEM parâmetros sendo executado");
        }

        // Construtor estático (é chamado automaticamente antes que a primeira instância seja criada ou que quaisquer membros estáticos sejam referenciados)
        // Não possui modificadores de acesso
        // Uma classe ou struct só pode ter um único modificador de acesso
        // Não pode ser chamado diretamente
        // O usuário não tem controle sobre quando o construtor estático é executado
        static Veiculo()
        {
            Console.WriteLine("Construtor estático sendo executado...");
            chassi = "12345678"; // Inicializa o atributo estático chassi
        }
    }
}