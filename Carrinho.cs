using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_G2
{
    public class Carrinho
    {
        private List<ItemCarrinho> itens = new List<ItemCarrinho>();

        public void AdicionarItem(Produto produto, int quantidade)
        {
            if (produto == null || quantidade <= 0)
                return;

            var itemExistente = itens.Find(i => i.GetProduto() == produto);

            if (itemExistente != null)
            {
                itemExistente.AtualizarQuantidade(itemExistente.Quantidade + quantidade);
            }
            else
            {
                itens.Add(new ItemCarrinho(produto, quantidade));
            }
        }

        public void RemoverItem(Produto produto)
        {
            var item = itens.Find(i => i.GetProduto() == produto);

            if (item != null)
            {
                itens.Remove(item);
            }
        }

        public double CalcularTotal()
        {
            double total = 0;

            foreach (var item in itens)
            {
                total += item.Subtotal();
            }

            return total;
        }
    }
}