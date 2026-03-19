using E_commerce_G2;

Produto produto1 = new Produto("Mouse", 150.00, 20);
Produto produto2 = new Produto("Teclado", 250.00, 15);

produto1.AplicarDesconto(10);
produto1.AjustarEstoque(-2);

produto2.AplicarDesconto(5);
produto2.AjustarEstoque(5);

Console.WriteLine($"Produto: {produto1.Nome}");
Console.WriteLine($"Preco base: {produto1.PrecoBase}");
Console.WriteLine($"Preco com desconto: {produto1.PrecoComDesconto()}");
Console.WriteLine($"Estoque: {produto1.Estoque}");

Console.WriteLine();

Console.WriteLine($"Produto: {produto2.Nome}");
Console.WriteLine($"Preco base: {produto2.PrecoBase}");
Console.WriteLine($"Preco com desconto: {produto2.PrecoComDesconto()}");
Console.WriteLine($"Estoque: {produto2.Estoque}");
