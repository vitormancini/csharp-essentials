// Classe Professor está herdando da classe Funcionario
// Envia os atributos ao construtor da classe base (Funcionario)

namespace Heranca
{
    public class Professor : Funcionario
    {
        public Professor(string nome, double salario) : base(nome, salario)
        {
            Console.WriteLine("Professor sendo instanciado...");
        }

        // Usamos o modificador new quando queremos informar ao compilador que estamos sobreescrevendo um método da classe base
        public new string Saudacao()
        {
            return "Eu sou um Professor";
        }
    }
}
