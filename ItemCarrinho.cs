using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_G2
{
   public class ItemCarrinho
{
    private Produto Produto;
    public int Quantidade { get; private set; }

    public ItemCarrinho(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }

    public void AtualizarQuantidade(int novaQuantidade)
    {   if (novaQuantidade > 0)
        Quantidade = novaQuantidade;

        else
        {
            throw new ArgumentException("A quantidade deve ser maior que zero.");
        }
    }

    public Produto GetProduto()
    {
        return Produto;
    }

    public double Subtotal()
    {
        return Produto.PrecoComDesconto() * Quantidade;
    }
}
}