// Operador "as" é utilizado para realizar a conversão entre tipos de referência ou tipos anuláveis compatíveis
// Retorna o objeto quando ele é compatível com o tipo de dado e retorna null se a conversão não for possível

// Operador "is" é responsavel por verificar se um tipo de um objeto é compatível com o tipo especificado ou não
// Retorna "true" se o obejeto especificado for do mesmo tipo , caso contrário, retorna "false". Retorna "false" também para objetos nulos.

Professor professor = new Professor();
Funcionario funcionario = professor;

Professor p = funcionario as Professor; // dowcasting
// Professor p = (Professor)p;

if (p == null)
{
    Console.WriteLine("Falha ao realizar downcasting");
}

if (professor is Funcionario)
{
    Console.WriteLine("Conversão possível");
}

class Funcionario 
{
    public int Id { get; set; }
    public string? Nome { get; set; }
}

class Professor : Funcionario
{
    public double Salario { get; set; }
}



