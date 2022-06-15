using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models
{
    public class Addition
    {
        [Key]
        public int AdditionId { get; set; }
        public string AdditionName { get; set; }
        public int Amount { get; set; }
        public Unit UnitType { get; set; }

        public Addition()
        {

        }
        public Addition(string additionName, int amount, Unit unitType)
        {
            AdditionName = additionName;
            Amount = amount;
            UnitType = unitType;
        }
    }
}
