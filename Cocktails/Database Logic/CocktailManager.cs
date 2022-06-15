using Cocktails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cocktails.Business_Logic
{

    public class CocktailManager
    {
        public string GetDrink(string cocktailName)
        {
            using (var con = new Context())
            {
                //Gets cocktail by cocktail name
                bool cocktailNameExist = con.Cocktails.Any(x => x.CocktailName == cocktailName);
                if (cocktailNameExist)
                {
                    Cocktail cocktail = con.Cocktails.Where(x => x.CocktailName == cocktailName).Single();
                    return cocktail.CocktailName;
                }
            }
            return null;
        }

        public string CreateCocktail(string cocktailName, List<Liquid> liquids, List<Addition> additions)
        {
            using (var con = new Context())
            {
                var cocktail = new Cocktail()
                {
                    CocktailName = cocktailName,
                    Liquids = con.Liquids.AddRange(liquids).ToList(),
                    Additions = con.Additions.AddRange(additions).ToList(),
                };
                con.Cocktails.Add(cocktail);
                //Console.WriteLine($"Cocktail has been created by the name {cocktail.CocktailName}");
                con.SaveChanges();
                return cocktail.CocktailName;
            }
        }
    }
}
