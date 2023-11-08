public partial class ClasseParcial
{
    public TimeSpan CalculaIdade(DateTime dataNascimento)
    {
        return (DateTime.Now.Date - DataNascimento);
    }

    public TimeSpan DiferecaEntreDatas(DateTime data1, DateTime data2)
    {
        return data1.Subtract(data2);
    }
}