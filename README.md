# LeFumePerfume (Perfumaria)

## Integrantes

- Guilherme Barca - RM568517
- Juliana Marques - RM566795
- Lucas Gomes Kosio - RM566828

## Domínio

Loja de perfumes: o cliente faz pedidos de perfumes, que pertencem a uma categoria e têm controle de estoque.
Entidades: Cliente, Pedido, ItemPedido, Perfume, Categoria e Estoque (MER em `/docs`).

## SGBD

MySQL com Framework 9.

## Como rodar

# 1. Subir o MySQL (se o container já existir: docker start TDSPB)
docker run --name TDSPB -e MYSQL_ROOT_PASSWORD=TDSPB123 -p 3306:3306 -d mysql:latest

# 2. Restaurar pacotes

dotnet restore

# 3. Aplicar as migrations

dotnet ef database update --project src/LojaPerfumes.Infrastructure --startup-project src/LojaPerfumes.Api

# 4. Rodar a API

dotnet run --project src/LojaPerfumes.Api

#Migrations

Uma única migration (`InitialCreate`) com o esquema completo.
