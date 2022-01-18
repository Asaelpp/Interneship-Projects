using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var cliente = contexto
                    .Clientes
                    .Include(c => c.EnderecoDeEntrega)//informando que queremos entidades relacionadas explicitamente por meio de métodos.
                    .FirstOrDefault();
                Console.WriteLine($"Endereço de entrega: {cliente.EnderecoDeEntrega.Logradouro}");

                var produto = contexto
                   .Produtos
                   .Where(p => p.Id == 4)
                   .FirstOrDefault();

                //carregamento explicito com outras condições
                contexto.Entry(produto)
                    .Collection(p => p.Compras)
                    .Query()
                    .Where(c => c.Preco > 10)
                    .Load();

                Console.WriteLine($"Mostrando as compras do produto {produto.Nome}");
                foreach (var item in produto.Compras)
                {
                    Console.WriteLine("\t" + item);
                }
                Console.ReadKey();
            }
        }

        private static void ExibeProdutosDaPromocao()
        {
            using (var contexto2 = new LojaContext())
            {
                var promocao = contexto2
                    .Promocoes
                    .Include(p => p.Produtos)//informando que queremos entidades relacionadas explicitamente por meio de métodos.
                    .ThenInclude(pp => pp.Produto)//informando que queremos entidades relacionadas explicitamente por meio de métodos.
                    .FirstOrDefault();
                Console.WriteLine("\nMostrando os produtos da promoção...");
                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }
            }
        }
        private static void IncluirPromocao()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Queima Total 2017";
                promocao.DataInicio = new DateTime(2017, 1, 1);
                promocao.DataTermino = new DateTime(2017, 1, 31);

                //var produtos = contexto.Produtos.ToList(); //faz um select all
                //fazendo um select com condicao
                var produtos = contexto
                .Produtos
                .Where(p => p.Categoria == "Bebidas")
                .ToList();

                foreach (var item in produtos)
                {
                    promocao.IncluiProduto(item);
                }

                contexto.Promocoes.Add(promocao);
                contexto.SaveChanges();
            }
        }


        private static void Teste(){

            //compra de 6 pães franceses
            var paoFrances = new Produto();
            paoFrances.Nome = "Pão Francês";
            paoFrances.PrecoUnitario = 0.40;
            paoFrances.Unidade = "Unidade";
            paoFrances.Categoria = "Padaria";

            var compra = new Compra();
            compra.Quantidade = 6;
            compra.Produto = paoFrances;
            compra.Preco = paoFrances.PrecoUnitario * compra.Quantidade;

            using (var contexto = new LojaContext())
            {
                contexto.Compras.Add(compra);
                contexto.SaveChanges();
            }
            
        }
        private static void MuitosPAraMuitos(){
            var p1 = new Produto() { Nome = "Suco de Café", Categoria = "Bebidas", PrecoUnitario = 20.79, Unidade = "Gramas" };
            var p2 = new Produto() { Nome = "RedBull", Categoria = "Bebidas", PrecoUnitario = 20.79, Unidade = "Litros" };
            var p3 = new Produto() { Nome = "Suco de feijão", Categoria = "Bebidas", PrecoUnitario = 0.79, Unidade = "Gramas" };

            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;//apartir de 
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);//ate 3 meses

            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext()){
                contexto.Promocoes.Add(promocaoDePascoa);
                contexto.SaveChanges();
            }
        }
        private static void UmParaUm()
        {
            var fulano = new Cliente();
            fulano.Nome = "Fulaninho de Tal";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua dos Inválidos",
                Complemento = "sobrado",
                Bairro = "Centro",
                Cidade = "Cidade"
            };

            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }
        }
    }
}