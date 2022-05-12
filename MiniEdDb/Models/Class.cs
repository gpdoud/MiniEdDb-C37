using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEdDb.Models {

    [Index(nameof(Code), IsUnique = true)]
    public class Class {

        public int Id { get; set; }
        [StringLength(6)]
        public string Code { get; set; }
        [StringLength(30)]
        public string Subject { get; set; }
        public int Section { get; set; }

        public int? InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public override string ToString() {
            return $"{Subject,-20} {Code,-6} {Section,3} {Instructor,30}";
        }

    }
}
