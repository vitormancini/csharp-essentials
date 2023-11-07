/* Os métodos representam os comportamentos das classes e são usados para executar ações. O método Main é o ponto de entrada para todos os aplicativos C#,
no qual é chamado pela CLR quando o programa é iniciado.

Todo método deve conter:

* Modificador de acesso
* Tipo de retorno
* Nome
* Lista de parâmetros
* Corpo do método

*/

namespace Metodos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo(); // Instancia a classe Veiculo
            v1.marca = "Chevrolet";
            v1.modelo = "S10";
            v1.ano = 1997;

            v1.Acelerar(); // Chama o método

            int ano = Convert.ToInt32(v1.ano); // Chama o método e armazena o retorno em uma variável
            Console.WriteLine(ano);

            v1.exibeProprietario("Vítor Mancini"); // Chama o parâmetro enviando uma string como parâmetro

            Veiculo.Estacionar(); // Chama um método estático sem necessidade de instanciar a classe antes
        }
    }

    class Veiculo
    {
        public string? marca; // Atributo
        public string? modelo; // Atributo
        public int ano; // Atributo

        // Método que não retorna nada e não recebe nenhum parâmetro
        public void Acelerar()
        {
            Console.WriteLine("O veículo está acelarando...");
        }

        // Método que retorna o ano do veiculo
        public int retornaAno()
        {
            return this.ano;
        }

        // Método com parâmetro (argumento)
        public void exibeProprietario(string nome)
        {
            Console.WriteLine($"Este veículo pertence ao {nome}");
        }

        // Método estático (não depende de uma estância da classe, pertence a classe em sim). Todos os objetos da classe terão acesso ao método
        public static void Estacionar()
        {
            Console.WriteLine("O carro está estacionado (método estático)");
        }
    }
}

