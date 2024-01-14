// Um modificador "abstract"  indica que a classe destina-se apenas a ser uma classe base de outras classes, ão podendo ser instanciada.
// Classes abstratas devem ser implementadas por classe não abstratas que derivam de uma classe abstrata.
// Uma classe abstrata não pode ser instanciada.

using ClasseAbsrata;

Professor p = new Professor();
Console.WriteLine(p.Descricao());

p.CalculaAumento();

Console.WriteLine(p.Salario);