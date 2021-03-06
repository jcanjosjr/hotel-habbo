using Models;
using System;

namespace Controllers
{
    public class ProdutoController
    {
        public static Produto IncluirProduto(
            string Nome,
            double ValorProduto
        )
        {
            if (String.IsNullOrEmpty(Nome))
            {
                throw new Exception("Campo referente ao Nome esta inválido.");
            }

            if (ValorProduto <= 0)
            {
                throw new Exception("Valor do produto não pode ser negativo ou igual a zero.");
            }

            return new Produto(Nome, ValorProduto);
        }

        public static void AlterarProduto(
            int Id,
            string Nome,
            double ValorProduto
        )
        {
            Produto produto = Produto.GetProdutoById(Id);

            if (!String.IsNullOrEmpty(Nome))
            {
                Nome = produto.Nome;
            }

            if (ValorProduto <= 0)
            {
                throw new Exception("O valor não poderá ser negativo ou igual a zero.");
            }
            else
            {
                ValorProduto = produto.ValorProduto;
            }

            Produto.AlterarProduto(Id, Nome, ValorProduto);
        }

        public static Produto RemoveProduto(int Id)
        {
            try
            {
                Produto produto = Produto.GetProdutoById(Id);
                Produto.RemoverProduto(produto);
                return produto;
            }
            catch
            {
                throw new Exception("Possuímos um erro ao remover o Produto.");
            }
        }
    }
}