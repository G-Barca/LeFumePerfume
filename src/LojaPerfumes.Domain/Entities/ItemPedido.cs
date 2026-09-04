namespace LojaPerfumes.Domain.Entities;

// N:N
public class ItemPedido
{
    public Guid ItemPedidoId { get; set; } = Guid.NewGuid();

    public Guid PedidoId { get; set; } // FK obrigatória
    public Pedido Pedido { get; set; } = null!;

    public Guid PerfumeId { get; set; } // FK obrigatória
    public Perfume Perfume { get; set; } = null!;

    public int Quantidade { get; set; }
}
