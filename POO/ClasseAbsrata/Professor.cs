using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbsrata
{
    internal class Professor : Funcionario
    {
        public override void CalculaAumento()
        {
            Salario += (Salario * 0.1);
        }
    }
}
