using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models
{
    public class Liquid
    {
        [Key]
        public int LiquidId { get; set; }
        public string LiquidName { get; set; }
        public int Amount { get; set; }
        public Unit UnitType { get; set; }

        public Liquid()
        {

        }
        public Liquid(string liquidName, int amount, Unit unitType)
        {
            LiquidName = liquidName;
            Amount = amount;
            UnitType = unitType;
        }
    }
}
