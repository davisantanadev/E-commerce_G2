using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_G2
{
    public class Cliente
    {
        private string? nome;
        private string? endereco;
        private string? telefone;
        private string? formaDePagamento;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string FormaDePagamento
        {
            get { return formaDePagamento; }
            set { formaDePagamento = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public void AdicionarEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public void AdicionarFormaPagamento(string formaDePagamento)
        {
            this.formaDePagamento = formaDePagamento;
        }

        public string GetContato()
        {
            return telefone;
        }
    }
}