using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Produtos
{
    internal class TesteProduto
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o nome do produto: ");
            string nome1 = Console.ReadLine();

            Console.Write("Insira o preço do produto: ");
            double preco1 = double.Parse(Console.ReadLine());

            Console.Write("Insira a marca: ");
            string marca1 = Console.ReadLine();

            Console.Write("Insira o tamanho: ");
            string tamanho1 = Console.ReadLine();
            Console.WriteLine();


            Etiqueta produto1Etiqueta = new Etiqueta(marca1, tamanho1);
            Produto produto1 = new Produto(nome1, preco1, produto1Etiqueta);
            Console.WriteLine(produto1.Nome);
            Console.WriteLine(produto1.Preco);
            Console.WriteLine(produto1Etiqueta.Marca);
            Console.WriteLine(produto1Etiqueta.Tamanho);

            Console.WriteLine();

            Console.Write("Insira o nome do produto: ");
            string nome2 = Console.ReadLine();

            Console.Write("Insira o preço do produto: ");
            double preco2 = double.Parse(Console.ReadLine());

            Console.Write("Insira a marca: ");
            string marca2 = Console.ReadLine();

            Console.Write("Insira o tamanho: ");
            string tamanho2 = Console.ReadLine();

            Console.WriteLine();

            Etiqueta produto2Etiqueta = new Etiqueta(marca2, tamanho2);
            Produto produto2 = new Produto(nome2, preco2, produto2Etiqueta);
            Console.WriteLine(produto2.Nome);
            Console.WriteLine(produto2.Preco);
            Console.WriteLine(produto2Etiqueta.Marca);
            Console.WriteLine(produto2Etiqueta.Tamanho);

            Console.WriteLine();

            produto2.Nome = "Calça";
            produto2.Preco = 200;
            produto2Etiqueta.Marca = "Calvin Klein";
            produto2Etiqueta.Tamanho = "40";

            Console.WriteLine("Modificado");
            Console.WriteLine(produto2.Nome);
            Console.WriteLine(produto2.Preco);
            Console.WriteLine(produto2Etiqueta.Marca);
            Console.WriteLine(produto2Etiqueta.Tamanho);


            Console.ReadKey();
        }
    }
}

