using Cocktails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cocktails.Business_Logic
{
    public class CocktailController
    {
        private CocktailManager _cocktailManager;
        public CocktailController(CocktailManager cocktailManager)
        {
            _cocktailManager = cocktailManager;
        }
        public string GetCocktail(string cocktailName)
        {
            if (cocktailName == string.Empty)
            {
                throw new InvalidOperationException("Cocktail name is null");
            }
            return _cocktailManager.GetDrink(cocktailName);
        }   
        
        public string CreateCocktail(string cocktailName, List<Liquid> liquids, List<Addition> additions)
        {
            if (cocktailName == string.Empty)
            {
                throw new InvalidOperationException("Cocktail name is null");
            }
            if (!liquids.Any() || liquids == null)
            {
                throw new InvalidOperationException("Liquid is empty or null");
            }
            if (!additions.Any() || additions == null)
            {
                throw new InvalidOperationException("Addition is empty or null");
            }
            return _cocktailManager.CreateCocktail(cocktailName, liquids, additions);
        }
    }
}
