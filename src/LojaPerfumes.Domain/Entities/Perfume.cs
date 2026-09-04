namespace LojaPerfumes.Domain.Entities;

public class Perfume
{
    public Guid PerfumeId { get; set; } = Guid.NewGuid();

    public Guid CategoriaId { get; set; } // FK obrigatóriaa
    public Categoria Categoria { get; set; } = null!;

    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }

    public Estoque? Estoque { get; set; } // 1:1
    public ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();
}
