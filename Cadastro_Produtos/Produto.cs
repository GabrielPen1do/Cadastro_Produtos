using Cadastro_Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Produtos
{
    internal class Produto
    {
        private string nome;
        private double preco;
        private Etiqueta etiqueta;

        public Produto(string nome, double preco, Etiqueta etiqueta)
        {
            this.nome = nome;
            this.preco = preco;
            this.etiqueta = etiqueta;
        }

        public Etiqueta Etiqueta
        {
            get { return etiqueta; }
            set { etiqueta = value; }
        }


        public Produto(string nome, double preco, string marca, string tamanho)
        {
            this.nome = nome;
            this.preco = preco;
            this.etiqueta = new Etiqueta(marca, tamanho);
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }



    }
}
