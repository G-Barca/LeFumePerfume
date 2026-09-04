namespace LojaPerfumes.Domain.Entities;

public class Cliente
{
    public Guid ClienteId { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
