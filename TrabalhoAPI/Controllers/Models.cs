namespace TrabalhoAPI.Models
{
    public class NewBaseType
    {
        public decimal Preco { get; set; }
    }

    public class Produto : NewBaseType
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}