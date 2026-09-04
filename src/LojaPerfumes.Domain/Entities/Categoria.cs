namespace LojaPerfumes.Domain.Entities;

public class Categoria
{
    public Guid CategoriaId { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;

    public ICollection<Perfume> Perfumes { get; set; } = new List<Perfume>();
}
