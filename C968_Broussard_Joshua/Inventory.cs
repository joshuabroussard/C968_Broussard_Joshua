using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace C968_Broussard_Joshua
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public Inventory(BindingList<Product> products, BindingList<Part> allParts) 
        {
            Products = products;
            AllParts = allParts;
        }
        public void addProduct(Product product)
        {
            Products.Add(product);
        }
        public bool removeProduct(int productID) 
        {
            var product = lookupProduct(productID);
            return Products.Remove(product);
        }
        Product lookupProduct(int productID) 
        {
            foreach (Product product in Products)
            {
                if (productID == product.ProductID)
                {
                    return product;
                }
            }
            return new Product();
        }
        public void updateProduct(int productID, Product updatedProduct) 
        {
            //Product product = lookupProduct(productID);
            //product.AssociatedParts = updatedProduct.AssociatedParts;
            //product.Name = updatedProduct.Name;
            //product.InStock = updatedProduct.InStock;
            //product.Price = updatedProduct.Price;
            //product.Max = updatedProduct.Max;
            //product.Min = updatedProduct.Min;
            var product = lookupProduct(productID);
            int i = Products.IndexOf(product);
            if (i == -1) return;
            Products[i] = updatedProduct;


        }
        public void addPart(Part part) 
        {
            AllParts.Add(part);
        }
        public bool deletePart(Part part) 
        {
            return AllParts.Remove(part);
        }
        Part lookupPart(int partID) 
        {
            foreach (Part part in AllParts)
            {
                if(partID == part.PartID) return part;
            }
            return new InhousePart();
        }
        public void updatePart(int partID, Part updatedPart) 
        {
            var part = lookupPart(partID);
            int i = AllParts.IndexOf(part);
            if (i == -1) return;
            AllParts[i] = updatedPart;
            

        }

    }
}
