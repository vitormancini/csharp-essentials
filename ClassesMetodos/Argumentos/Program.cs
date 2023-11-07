/*
 
Passagem de argumento por valor (padrão): uma cópia do valor do argumento é criada e passada para o parâmetro do método chamado.
As alterações na cópia não afetam o valor da variável original.

Passagem de argumento por referência: envia para o método a refer^wncia de memória da variável original do chamador. Para fezer
isso usamos as palavras ref e out.
 
 */

// Passagem por valor
Calculo calculo = new Calculo();

int x = 20;

Console.WriteLine($"Valor de x antes de passar por valor: {x}");
calculo.Dobrar( x );
Console.WriteLine($"Valor de x depois de passar por valor: {x}"); // Vemos que o valor da variável original não foi alterado

// Passagem por referência (ref)
int y = 50;

Console.WriteLine($"Valor de y antes de passar por valor: {y}");
calculo.Dividir(ref y);
Console.WriteLine($"Valor de y depois de passar por valor: {y}"); // Vemos que o valor da variável original foi alterado

// Passagem por referência (out)
double circunferencia = calculo.CalculaAreaPerimetro(5, out double area);
Console.WriteLine($"Área de circunferência: {area}"); // A variável area foi exposta pelo método, nãp foi preciso inicializa-la
Console.WriteLine($"Perímetro da circunferência: {circunferencia}");

// Argumentos nomeados (informamos os nomes dos argumentos que serão recebidos no método, dessa forma não é necessário respeitar a ordem)
calculo.Soma(n2: 10, n1: 45);

// Argumentos opacionais
calculo.Opcionais("Vitor", 29);

public class Calculo
{
    public void Dobrar(int valor)
    {
        valor *= 2;
        Console.WriteLine($"Valor do argumento no método Dobrar: {valor}");
    }

    public void Dividir(ref int valor)
    {
        valor /= 2;
        Console.WriteLine($"Valor do argumento no método dividir: {valor}");
    }

    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2); // variável que será exposta pelo out
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }

    // Argumentos nomeados
    public void Soma(double n1, double n2)
    {
        Console.WriteLine($"Argumento n1: {n1}, argumento n2: {n2}");
    }

    // Argumentos opcionais (recebem um valor padrão caso não sejam enviados pelo chamador). Devem sempre vir após os argumentos obrigatórios
    public void Opcionais(string nome, double numero, string operacao = "soma")
    {
        Console.WriteLine($"Argumento nome: {nome}, argumento numero: {numero}, argumento operacao: {operacao}");
    }
}