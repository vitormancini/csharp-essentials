// Podemos dividir uma classe em mais de um arquivo e continuar tendo acesso as propriedades e métodos desta classe
// Todas as partes da partial class devem possuir a mesma acessibilidade public ou private.
// O modificador partial somente pode ser usado antes de class, struct ou interface 

// Instancia partial class
ClasseParcial cp = new ClasseParcial();

// Acessa as propriedades
cp.DataNascimento = new DateTime(1994, 09, 12);
cp.Nome = "Vitor";

// Acessa os métodos
TimeSpan idade = cp.CalculaIdade(cp.DataNascimento);
TimeSpan diferenca = cp.DiferecaEntreDatas(new DateTime(2023, 11, 08), new DateTime(2013, 02, 03));

Console.WriteLine(idade);
Console.WriteLine(diferenca);