using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObjectsLib;
using BusinessRulesLib;

namespace trabalhoPOO_27969_Fase1
{
    /// <summary>
    /// Main class that executes the program
    /// Created by: Marco Cardoso
    /// Created on: 14/11/2024
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaration and Initialization of variables
            // Variaveis de tempo (Datas)
            DateTime d1 = new DateTime(2010, 8, 18);
            DateTime d2 = new DateTime(2005, 8, 4);
            DateTime d3 = new DateTime(2005, 10, 29);

            // Usar os construtores
            // Clientes
            Client cl1 = new Client("Roberto", "Rua das 12 casas nr 23", "client@gmail.com", d1);
            Client cl2 = new Client();
            Client cl3 = new Client("Mario", "ADSADADA", "client@gmail.com", d3);

            //// Vendedores
            Seller sl1 = new Seller("Rui", "Rua das marias", "seller@gmail.com");
            Seller sl2 = new Seller("Gustavo", "Rua das marias", "seller@gmail.com");

            //// Usar propriedades
            cl2.Name = "Marco";
            cl2.Address = "Arcozelo";
            cl2.Email = "client@gmail.com";
            cl2.DateBirth = d2;

            //// Categorias
            Category cTech = new Category("Technology", "DESC 1");
            Category cPhone = new Category("Phone", "DESC 2");
            Category cPeriphericals = new Category("Periphericals", "DESC 3");

            //// Produtos
            Product p1 = new Product(770.50, "Laptop", 1, 1, 50);
            Product p2 = new Product();
            Product p3 = new Product(770.50, "Computer", 1, 1, 20);

            Product p4 = new Product(300, "Xiaomi Redmi 10", 2, 2, 100);
            Product p5 = new Product(249.99, "Iphone X", 2, 2, 200);

            p2.Price = 10.50;
            p2.Name = "Cable";
            p2.Quantity = 10;
            p2.CodSeller = 1;
            p2.CodCategory = 1;

            #endregion

            #region Using BusinessRules
            ShopRules.TryCreateDictionary();

            Clients.TryAddClient(cl1);
            Clients.TryAddClient(cl2);
            Clients.TryAddClient(cl3);

            Categorys.TryAddCategory(cTech);
            Categorys.TryAddCategory(cPhone);
            Categorys.TryAddCategory(cPeriphericals);

            Products.TryAddProduct(p1);
            Products.TryAddProduct(p2);
            Products.TryAddProduct(p3);
            Products.TryAddProduct(p4);
            Products.TryAddProduct(p5);

            Sellers.TryAddSeller(sl1);
            Sellers.TryAddSeller(sl2);

            Sale s = new Sale(1, 5, DateTime.Now);
            Sale s2 = new Sale(2, 4, DateTime.Now);
            Sale s3 = new Sale(2, 3, DateTime.Now);
            Sale s4 = new Sale(3, 2, DateTime.Now);
            Sale s5 = new Sale(3, 1, DateTime.Now);
            Sale s6 = new Sale(3, 3, DateTime.Now);

            Sales.TryAddSale(s);
            Sales.TryAddSale(s2);
            Sales.TryAddSale(s3);
            Sales.TryAddSale(s4);
            Sales.TryAddSale(s5);
            Sales.TryAddSale(s6);

            //ShopRules.MostrarTudo();

            #endregion
        }
    }
}
