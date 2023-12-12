// Instanciando a classe Professor e Diretor, que herda de Funcionario
// Podemos observar que o construtor da classe base é executado antes do construtor da classe filha

using Heranca;

Professor professor = new Professor("João", 3500.50);

Diretor diretor = new Diretor("Carlos", 5600.00);

// Sobreescrita
diretor.Trabalhar();