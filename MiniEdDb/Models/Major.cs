using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MiniEdDb.Models {
    
    [Table("Majors")]
    [Index(nameof(Code), IsUnique = true)]
    public class Major {
        [Key]
        public int Id { get; set; }
        [StringLength(4)]
        public string Code { get; set; } = null!;
        [StringLength(30)]
        public string Description { get; set; } = null!;

        public override string ToString() {
            return $"{Id,5} {Code,-7} {Description,-30}";
        }
    }
}
