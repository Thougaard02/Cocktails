using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        public string UnitType { get; set; }
    }
}
