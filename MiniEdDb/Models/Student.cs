﻿

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniEdDb.Models {
    
    public class Student {

        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = null!;
        [StringLength(2)]
        public string StateCode { get; set; } = null!;
        public int? SAT { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal GPA { get; set; }

        public int? MajorId { get; set; }
        public virtual Major Major { get; set; } = null!;

        public override string ToString() {
            return $"{Id,3} {Name,-30} {StateCode,2} {(SAT is null ? 0 : SAT),4}"
                + $"{GPA,5} {(MajorId is null ? "Undeclared" : Major.Description),-30}";

        }
    }
}
