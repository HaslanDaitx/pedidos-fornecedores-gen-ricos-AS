# Gerenciamento de Fornecedores e Pedidos

Este projeto é uma aplicação baseada em .NET Core para o gerenciamento de fornecedores e pedidos, implementando boas práticas de desenvolvimento de APIs RESTful. Ele inclui funcionalidades para CRUD (Create, Read, Update, Delete) de fornecedores e pedidos, seguindo os princípios de organização, reutilização de código e integração eficiente.

## 🛠️ Tecnologias Utilizadas
- **C#** com .NET Core
- **Entity Framework Core** para persistência de dados
- **SQL Server** como banco de dados
- **Swagger** para documentação da API
- **Bootstrap** para layout e responsividade do front-end

## 🚀 Funcionalidades
### Fornecedores
- **GET** `/fornecedores` - Retorna todos os fornecedores.
- **GET** `/fornecedores/{id}` - Retorna um fornecedor pelo ID.
- **POST** `/fornecedores` - Adiciona um novo fornecedor.
- **PUT** `/fornecedores/{id}` - Atualiza as informações de um fornecedor.
- **DELETE** `/fornecedores/{id}` - Remove um fornecedor pelo ID.

### Pedidos
- **GET** `/pedidos` - Retorna todos os pedidos.
- **GET** `/pedidos/{id}` - Retorna um pedido pelo ID.
- **POST** `/pedidos` - Adiciona um novo pedido.
- **PUT** `/pedidos/{id}` - Atualiza as informações de um pedido.
- **DELETE** `/pedidos/{id}` - Remove um pedido pelo ID.


### Extrair o código do git
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/gerenciamento-fornecedores-pedidos.git
   cd gerenciamento-fornecedores-pedidos

