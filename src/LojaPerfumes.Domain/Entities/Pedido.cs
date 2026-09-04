namespace LojaPerfumes.Domain.Entities;

public class Pedido
{
    public Guid PedidoId { get; set; } = Guid.NewGuid();

    public Guid ClienteId { get; set; } // FK obrigatória
    public Cliente Cliente { get; set; } = null!;

    public DateTime DataPedido { get; set; } = DateTime.UtcNow;
    public string StatusPedido { get; set; } = "Aguardando pagamento";

    public ICollection<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
}
