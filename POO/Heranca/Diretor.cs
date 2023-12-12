// Classe Diretor está herdando da classe Funcionario
// Envia os atributos ao construtor da classe base (Funcionario)

namespace Heranca
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, double salario) : base(nome, salario)
        {
            Console.WriteLine("Diretor sendo instanciado...");
        }

        // Sobreescrevendo o método virtual da classe base
        public override void Trabalhar()
        {
            Console.WriteLine($"O diretor {base.Nome} está trabalhando...");
        }
    }
}
