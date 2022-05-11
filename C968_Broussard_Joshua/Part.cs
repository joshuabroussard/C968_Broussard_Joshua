using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Broussard_Joshua
{
    public abstract class Part
    {
        [Required]
        public int PartID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\d*(\.\d+)?$")]
        public decimal Price { get; set; }
        [Required]
        [RegularExpression(@"/^\d+$/")]
        public int InStock { get; set; }
        [Required]
        [RegularExpression(@"/^\d+$/")]
        public int Min { get; set; }
        [Required]
        [RegularExpression(@"/^\d+$/")]
        public int Max { get; set; }


    }
}
