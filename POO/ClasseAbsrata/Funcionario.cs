using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbsrata
{
    public abstract class Funcionario
    {
        public string? Nome { get; set; }
        public double Salario { get; set; }

        // Métodos abstratos
        public abstract void CalculaAumento();

        // Método comum
        public string Descricao() 
        {
            return "Eu sou a classe abstrata";
        }
    }
}
