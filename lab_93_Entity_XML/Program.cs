using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace lab_93_Entity_XML
{
    class Program
    {

        static List<Product> products;
        static Product product = new Product();
        static Product product2 = new Product();

        static void Main(string[] args) { 
            using (var db = new Northwind())
            {
                products = db.Products.Include("Category").ToList();
                products.ForEach(p => Console.WriteLine(p.ProductName));

                // just get first product
                product = products.FirstOrDefault();
                product2 = products.Skip(1).FirstOrDefault();

                Console.WriteLine("\n\nFirst Product\n");
                var xmlProduct = new XElement("Product",
                    new XElement("ProductID",product.ProductID),
                    new XElement("ProductName",product.ProductName),
                    new XElement("UnitPrice",product.Cost),
                    new XElement("CategoryID",product.CategoryID)
                    );
                Console.WriteLine(xmlProduct);

                // save to file
                xmlProduct.Save("xmlOneProduct.xml");


                var xmlProductSave = new XDocument(XElement.Parse(xmlProduct.ToString()));
                var xmlProductSave2 = new XDocument(xmlProduct);

                xmlProductSave.Save("xmlOneProductv2.xml");
                 





                Console.WriteLine("\n\nNow listing all products");
                Console.WriteLine("============================\n");
                var xmlProducts = new XElement("Products",
                    from p in products
                    select new XElement("Product",
                        new XElement("ProductID", p.ProductID),
                        new XElement("ProductName", p.ProductName),
                        new XElement("UnitPrice", p.Cost),
                        new XElement("CategoryID", p.CategoryID))
                    );
                Console.WriteLine(xmlProducts);


                Console.WriteLine("\n\nNow listing all products");
                Console.WriteLine("============================\n");
                var xmlProductsWithCategory = new XElement("Products",
                    from p in products
                    select new XElement("Product",
                        new XElement("ProductID", p.ProductID),
                        new XElement("ProductName", p.ProductName),
                        new XElement("UnitPrice", p.Cost),
                        new XElement("Category",p.Category.CategoryName)                        
                        )
                    );
                Console.WriteLine(xmlProductsWithCategory);
                xmlProductsWithCategory.Save("Products.xml");


            }
        }
    }
}
