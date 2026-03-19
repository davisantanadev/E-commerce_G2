using System;

namespace E_commerce_G2
{
    public class Pedido
    {
        private bool confirmado;
        private double total;
        private Carrinho carrinho;
        private Cliente cliente;

        public bool Confirmado
        {
            get { return confirmado; }
        }

        public double Total
        {
            get { return total; }
        }

        public void Confirmar(Carrinho carrinho, Cliente cliente)
        {
            if (carrinho == null || cliente == null)
            {
                Console.WriteLine("Carrinho ou cliente inválido.");
                return;
            }
            if (carrinho.CalcularTotal() == 0)
            {
                Console.WriteLine("Carrinho vazio! Não é possível confirmar o pedido.");
                return;
            }

            this.carrinho = carrinho;
            this.cliente = cliente;
            this.total = carrinho.CalcularTotal();
            this.confirmado = true;

            Console.WriteLine("Pedido confirmado!");
            Console.WriteLine("Cliente: " + cliente.Nome);
            Console.WriteLine("Contato: " + cliente.GetContato());
            Console.WriteLine("Total: " + total);
        }

        public void Cancelar()
        {
            if (!confirmado)
            {
                Console.WriteLine("Pedido ainda não foi confirmado.");
                return;
            }

            confirmado = false;
            Console.WriteLine("Pedido cancelado.");
        }

        public double TotalComFrete(double frete)
        {
            return total + frete;
        }
    }
}