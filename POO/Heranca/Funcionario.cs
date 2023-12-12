/*
 MODIFICADORES DE ACESSO

* public: visiveis por todas as classes do programa
* protected: acessíveis somente pela classe base e pelas classe filhas
* private: acessíveis somente pela classe 

* sealed: quando não queremos que uma classe, método ou propriedade sejam herdados
Ex: sealed class Funcionario

*/

namespace Heranca
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        protected double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Console.WriteLine("Funcionário sendo instanciado...");
            Nome = nome;
            Salario = salario;
        }

        // Como a propriedade Salario é protected, precisamos ter um método acessor publico
        public double retornaSalario()
        {
            return Salario;
        }

        public string Saudacao()
        {
            return "Eu sou um funcionário!";
        }

        // Método que pode ser sobreescrito pelas classes filhas
        public virtual void Trabalhar()
        {
            Console.WriteLine("O funcionário está trabalhando...");
        }
    }
}
