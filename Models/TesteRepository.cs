using System.Collections.Generic;

namespace mvc1.Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] produtos = new Produto[]
        {
            new Produto { ProdutoId = 1, Nome = "Caneta", Categoria = "Material", Preco = 2.5M },
            new Produto { ProdutoId = 2, Nome = "Borracha", Categoria = "Material", Preco = 4.75M },
            new Produto { ProdutoId = 3, Nome = "Estojo", Categoria = "Material", Preco = 6.55M }
        };

        public TesteRepository()
        {
        }

        public IEnumerable<Produto> Produtos { get => produtos; }
        
    }
}