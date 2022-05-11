using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Broussard_Joshua
{
    public class OutsourcedPart : Part
    {
        [Required]
        public string CompanyName { get; set; }
        public OutsourcedPart(int partID, string name, decimal price, int inStock, int min, int max, string companyName) 
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}
