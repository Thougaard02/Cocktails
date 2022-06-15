using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Cocktails.Models
{
    public class Context : DbContext
    {
        public Context() : base("name=DBCocktail")
        {
        }

        public DbSet<Cocktail> Cocktails{ get; set; }
        public DbSet<Liquid> Liquids{ get; set; }
        public DbSet<Addition> Additions{ get; set; }
        public DbSet<Unit> Units{ get; set; }
    }
}
