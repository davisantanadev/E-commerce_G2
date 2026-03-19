using E_commerce_G2;

// Produtos
Produto produto1 = new Produto("Mouse Gamer", 150.00, 20);
Produto produto2 = new Produto("Teclado Mecanico", 250.00, 15);

produto1.AplicarDesconto(10);
produto1.AjustarEstoque(-2);

produto2.AplicarDesconto(5);
produto2.AjustarEstoque(3);

// Itens e Carrinho
ItemCarrinho item1 = new ItemCarrinho(produto1, 2);
ItemCarrinho item2 = new ItemCarrinho(produto2, 1);

Carrinho carrinho = new Carrinho();
carrinho.AdicionarItem(item1.GetProduto(), item1.Quantidade);
carrinho.AdicionarItem(item2.GetProduto(), item2.Quantidade);

Console.WriteLine("Produto/Item/Carrinho");
Console.WriteLine($"Produto 1: {produto1.Nome}");
Console.WriteLine($"Preco base: {produto1.PrecoBase}");
Console.WriteLine($"Preco com desconto: {produto1.PrecoComDesconto()}");
Console.WriteLine($"Estoque: {produto1.Estoque}");
Console.WriteLine($"Quantidade no item: {item1.Quantidade}");
Console.WriteLine($"Subtotal do item: {item1.Subtotal()}");
Console.WriteLine();
Console.WriteLine($"Produto 2: {produto2.Nome}");
Console.WriteLine($"Preco base: {produto2.PrecoBase}");
Console.WriteLine($"Preco com desconto: {produto2.PrecoComDesconto()}");
Console.WriteLine($"Estoque: {produto2.Estoque}");
Console.WriteLine($"Quantidade no item: {item2.Quantidade}");
Console.WriteLine($"Subtotal do item: {item2.Subtotal()}");
Console.WriteLine($"Total do carrinho: {carrinho.CalcularTotal()}");

Console.WriteLine();

// Clientes
Cliente cliente1 = new Cliente();
cliente1.Nome = "Davi Santana";
cliente1.Telefone = "31999998888";
cliente1.AdicionarEndereco("Rua Central, 100 - Belo Horizonte");
cliente1.AdicionarFormaPagamento("Cartao de credito");

// Pedidos
Pedido pedido1 = new Pedido();
pedido1.Confirmar(carrinho, cliente1);
double frete1 = 20.0;
Console.WriteLine($"Total com frete ({frete1}): {pedido1.TotalComFrete(frete1)}");

