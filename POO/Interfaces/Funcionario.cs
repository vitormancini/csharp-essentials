namespace Interfaces
{
    internal class Funcionario : IFuncionario
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Descricao()
        {
            Console.WriteLine("Eu sou um funcionário");
        }
    }
}
