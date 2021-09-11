using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriasProductos
{
    class Product
    {
        public int codProduct { get; set; }

        public string productname { get; set; }

        public string productDescription { get; set; }

        public double buyPrice { get; set; }

        public string categorias { get; set; }


        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product{codProduct=3090, productname="Aceite Orisol", productDescription="750 ml", buyPrice= 1.75, categorias="Despensa"},
                new Product{codProduct=4100, productname="Gatorade", productDescription="350 ml", buyPrice=1.25,categorias="Bebidas"},
                new Product{codProduct=1035, productname="Men For San Champu", productDescription="750 ml", buyPrice=3.55,categorias="Mascota"},
                new Product{codProduct=9354, productname="Baby Dove Sensitive", productDescription="80 toallas y/o 600 gramos", buyPrice=4.85,categorias="Bebes"},
                new Product{codProduct=5501, productname="Servidor", productDescription="750 ml ", buyPrice=1.95,categorias="Limpieza"}
            };

            return products;


        }
    }
}
