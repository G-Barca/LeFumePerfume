namespace LojaPerfumes.Domain.Entities;

// 1:1
public class Estoque
{
    public Guid EstoqueId { get; set; } = Guid.NewGuid();

    public Guid PerfumeId { get; set; } // FK obrigatória (1:1)
    public Perfume Perfume { get; set; } = null!;

    public int Quantidade { get; set; }
}
