using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Broussard_Joshua
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        
        public Product()
        {
            AssociatedParts = new BindingList<Part>();
            Name = "Default";
            Price = 0m;
            InStock = 0;
            Min = 0;
            Max = 0;
        }
        public Product(BindingList<Part> associatedParts, int productID, string name, decimal price, int inStock, int min, int max) 
        { 
            AssociatedParts = associatedParts;
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public void addAssocaitedPart(Part part) 
        {
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int partID)
        {
            var part = lookupAssociatedPart(partID);
            return AssociatedParts.Remove(part);
        }
        Part lookupAssociatedPart(int partID) 
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return new InhousePart();
        }
    }
}
