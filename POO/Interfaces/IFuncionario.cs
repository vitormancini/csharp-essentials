namespace Interfaces
{
    public interface IFuncionario
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public void Descricao();
    }
}
