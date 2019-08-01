using System.Collections.Generic;

namespace mvc1.Models
{
    public class ProdutoRepository : IRepository
    {
        public AppDbContext context;

        public ProdutoRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Produto> Produtos => context.Produtos;
    }
}