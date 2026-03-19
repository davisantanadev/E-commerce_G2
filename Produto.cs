using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_G2
{
    public class Produto
    {
        public string Nome { get; set; } = string.Empty;
        public double PrecoBase { get; set; }
        public int Estoque { get; set; }
        private double DescontoPercentual { get; set; }

        public Produto(string nome, double precoBase, int estoque)
        {
            Nome = nome;
            PrecoBase = precoBase;
            Estoque = estoque;
            DescontoPercentual = 0;
        }

        public void AplicarDesconto(double percentual)
        {
            DescontoPercentual = percentual;
        }

        public void AjustarEstoque(int quantidade)
        {
            Estoque += quantidade;
        }

        public double PrecoComDesconto()
        {
            return PrecoBase - (PrecoBase * (DescontoPercentual / 100));
        }
    }
}
