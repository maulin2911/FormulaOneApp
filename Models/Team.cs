using System.ComponentModel.DataAnnotations;

namespace FormulaOneApp.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string TeamPrinciple { get; set; }
    }
}
