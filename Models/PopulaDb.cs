using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace mvc1.Models
{
    public static class PopulaDb
    {
        public static void IncluiDadosDB(IApplicationBuilder app)
        {
            IncluiDadosDB(app.ApplicationServices.GetRequiredService<AppDbContext>());
        }

        public static void IncluiDadosDB(AppDbContext context)
        {
            System.Console.WriteLine("Aplicando Migrations...");
            context.Database.Migrate();

            if(!context.Produtos.Any())
            {
                System.Console.WriteLine("Criando dados...");
                context.Produtos.AddRange(
                    new Produto("PlayStation 4", "Video Game", 1699.99m),
                    new Produto("XBOX One", "Video Game", 1400.70m),
                    new Produto("Nintendo Switch", "Video Game", 1750.29m),
                    new Produto("PlayStation 3", "Video Game", 999.99m),
                    new Produto("XBOX 360", "Video Game", 700m)
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Dados já existem...");
            }
        }
    }
}