# LeFumePerfume (Perfumaria)

## Integrantes

Guilherme Barca - RM568517
Juliana Marques - RM566795
Lucas Gomes Kosio - RM566828


## Domínio escolhido
**Loja de Perfumes** — O cliente faz pedidos de perfumes em geral, que pertencem a uma categoria e tem controle de estoque.

## Entidades modeladas:
1. **Cliente**
2. **Pedido**
3. **ItemPedido** 
4. **Perfume**
5. **Categoria**
6. **Estoque**

## Resumo dos relacionamentos

Cliente - Pedido | 1:N | Pedido obrigatório p/ Cliente; Cliente opcional p/ Pedido |
Pedido - ItemPedido | 1:N | Obrigatório nos dois lados |
Perfume - ItemPedido | 1:N | ItemPedido obrigatorio p/ Perfume; Perfume opcional p/ ItemPedido |
Categoria - Perfume | 1:N | Perfume obrigatório p/ Categoria; Categoria opcional p/ Perfume |
Perfume - Estoque | 1:1 | Obrigatório nos dois lados |