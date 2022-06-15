using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models
{
    public class Cocktail
    {
        [Key]
        public int CocktailId { get; set ; }
        public string CocktailName { get; set; }
        public List<Liquid> Liquids { get; set; }
        public List<Addition> Additions { get; set; }
    }
}
