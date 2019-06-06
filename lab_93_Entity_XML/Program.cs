using System;
using System.Xml.Linq;
using System.Linq;

namespace lab_93_Entity_XML
{
    class Program
    {
        static void Main(string[] args) { 
            using (var db = new Northwind())
            {
                var products = db.Products.ToList();
                products.ForEach(p => Console.WriteLine(p.ProductName));
            }
        }
    }
}
