using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//using Utils;
using BusinessObjectsLib;

namespace DataLib
{
    public class Shop
    {
        // Dictionario
        private static Dictionary<string, List<Object>> shop = new Dictionary<string, List<Object>>();
        // Keys
        private static List<String> keys = new List<string>();

        /// <summary>
        /// Propertie for Keys
        /// </summary>
        public static List<String> Keys
        {
            get
            {
                return keys;
            }
            set
            {
                keys = value;
            }
        }

        /// <summary>
        /// Create the keys for the dictionary
        /// </summary>
        private static void CreateKeys()
        {
            if(!Keys.Contains("Category"))
            {
                Keys.Add("Category");
            }
            if (!Keys.Contains("Sale"))
            {
                Keys.Add("Sale");
            }
            if (!Keys.Contains("Client"))
            {
                Keys.Add("Client");
            }
            if (!Keys.Contains("Seller"))
            {
                Keys.Add("Seller");
            }
            if (!Keys.Contains("Product"))
            {
                Keys.Add("Product");
            }
        }
        /// <summary>
        /// Adds the keys and creates lists for the dictionary
        /// </summary>
        /// <returns>Bool - True or false</returns>
        public static bool CreateDictionary()
        {
            // Ver melhor maneira disto
            CreateKeys();

            for (int  i = 0; i < Keys.Count; i++)
            {
                shop[Keys[i]] = new List<Object>();
            }
            return true;
        }

        #region Create Lists
        #region Categorys Related
        public static bool AddCategory(Category c)
        {
            if (shop["Category"].Contains(c))
            {
                return false;
            }
            else
            {
                shop["Category"].Add(c);
                return true;
            }
        }
        public static bool RemoveCategory(int id)
        {
            if(ExistCategory(id))
            {
                Category category = HasCategoryObj(id);
                shop["Category"].Remove(category);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ExistCategory(int id)
        {
            foreach(Category c in shop["Category"])
            {
                if(c.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// Extra
        public static string HasCategory(int id)
        {
            foreach (Category c in shop["Category"])
            {
                if (c.Id == id)
                {
                    return c.Name;
                }
            }
            return "Empty";
        }

        public static Category HasCategoryObj(int id)
        {
            foreach (Category c in shop["Category"])
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }
        #endregion
        #region Clients Related
        public static bool AddClient(Client c)
        {
            if (shop["Client"].Contains(c))
            {
                return false;
            }
            else
            {
                shop["Client"].Add(c);
                return true;
            }
        }
        public static bool RemoveClient(int id)
        {
           if(ExistClient(id))
           {
               Client cli = HasClientObj(id);
               shop["Client"].Remove(cli);
               return true;
           }
           else
           {
               return false; 
           }
        }
        public static bool ExistClient(int id)
        {
            foreach (Client c in shop["Client"])
            {
                if (c.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        // Extra
        public static string HasClient(int id)
        {
            foreach (Client c in shop["Client"])
            {
                if (c.Id == id)
                {
                    return c.Name;
                }
            }
            return "Empty";
        }
        public static Client HasClientObj(int id)
        {
            foreach (Client c in shop["Client"])
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }
        #endregion
        #region Sale Related
        public static bool AddSale(Sale s)
        {
            if (shop["Sale"].Contains(s))
            {
                return false;
            }
            else
            {
                shop["Sale"].Add(s);
                return true;
            }
        }
        public static bool RemoveSale(int id)
        {
            if(ExistSale(id))
            {
                Sale s = HasSaleObj(id);
                shop["Sale"].Remove(s);
                return true;
            }
            return false;
        }
        public static bool ExistSale(int id)
        {
            foreach(Sale s in shop["Sale"])
            {
                if(s.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        // Extra
        public static int HasSale(int id)
        {
            foreach (Sale s in shop["Sale"])
            {
                if (s.Id == id)
                {
                    return s.Id;
                }
            }

            return -1;
        }
        public static Sale HasSaleObj(int id)
        {
            foreach (Sale s in shop["Sale"])
            {
                if (s.Id == id)
                {
                    return s;
                }
            }

            return null;
        }
        public static int HasProductInSale(int id)
        {
            foreach (Sale s in shop["Sale"])
            {
                if (s.CodProduct == id)
                {
                    return s.Id;
                }
            }

            return -1;
        }
        public static string HasClientInSale(int id)
        {
            foreach (Sale s in shop["Sale"])
            {
                if (s.CodProduct == id)
                {
                    return HasClient(s.CodClient);
                }
            }

            return "Empty";
        }

        #endregion
        #region Product Related
        public static bool AddProduct(Product p)
        {
            if (shop["Product"].Contains(p))
            {
                return false;
            }
            else
            {
                shop["Product"].Add(p);
                return true;
            }
        }
        public static bool RemoveProduct(int id)
        {
            if (ExistProduct(id))
            {
                Product s = HasProductObj(id);
                shop["Product"].Remove(s);
                return true;
            }
            return false;
        }
        public static bool ExistProduct(int id)
        {
            foreach (Product p in shop["Product"])
            {
                if (p.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        // Extra
        public static Product HasProductObj(int id)
        {
            foreach (Product p in shop["Product"])
            {
                if (p.Id == id)
                {
                    return p;
                }
            }

            return null;
        }
        #endregion
        #region Sellers Related
        public static bool AddSeller(Seller s)
        {
            if (shop["Seller"].Contains(s))
            {
                return false;
            }
            else
            {
                shop["Seller"].Add(s);
                return true;
            }
        }
        public static bool RemoveSeller(int id)
        {
            if (ExistSeller(id))
            {
                Seller s = HasSellerObj(id);
                shop["Seller"].Remove(s);
                return true;
            }
            return false;
        }
        public static bool ExistSeller(int id)
        {
            foreach (Seller s in shop["Seller"])
            {
                if (s.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        // Extra
        public static string HasSeller(int id)
        {
            foreach (Seller s in shop["Seller"])
            {
                if (s.Id == id)
                {
                    return s.Name;
                }
            }

            return "Empty";
        }
        public static Seller HasSellerObj(int id)
        {
            foreach (Seller s in shop["Seller"])
            {
                if (s.Id == id)
                {
                    return s;
                }
            }

            return null;
        }
        #endregion
        #endregion

        /// <summary>
        /// Saves a dictionary into a binary file
        /// </summary>
        /// <param name="path">Path to save</param>
        /// <exception cref="InvalidFileException"></exception>
        public static bool SaveDictionary(string path)
        {
            try
            {
                // Tenta abrir o ficheiro
                FileStream f = new FileStream(path, FileMode.Create);
                
                try
                {
                    // Tenta guardar
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(f, shop);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }

                f.Close();
            }
            catch (Exception) // Apenas TESTE - Nao da
            {
                //Console.WriteLine(ex.Message);
                //throw new InvalidFileException();
                return false;
            }
        }
        /// <summary>
        /// Loads a dictionary from a binary file
        /// </summary>
        /// <param name="path">Path</param>
        public static bool LoadDictionary(string path)
        {
            try
            {
                FileStream f = new FileStream(path, FileMode.Open);

                try
                {
                    BinaryFormatter b = new BinaryFormatter();
                    Shop.shop = (Dictionary<string, List<Object>>)b.Deserialize(f);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }

                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        /// <summary>
        /// Shows All the lists's keys
        /// </summary>
        public static void MostrarKeys()
        {
            //CreateKeys();

            foreach (string key in Keys)
            {
                if (shop.ContainsKey(key))
                {
                    Console.WriteLine(key.ToUpper());
                }
            }
        }

        /// <summary>
        /// Mostra todo o conteúdo do dicionário dividido pelas keys.
        /// </summary>
        public static void MostrarTudo()
        {
            CreateKeys();

            Console.WriteLine("========== LOJA ==========\n");
            foreach (string key in Keys)
            {
                if (shop.ContainsKey(key))
                {
                    Console.Write("========== Key: {0} ==========\n", key.ToUpper());
                    foreach (var item in shop[key])
                    {
                        if (item is Category)
                        {
                            Category category = (Category)item;
                            Console.WriteLine("{0} - {1} - {2}",
                                    category.Id, category.Name, category.Description);
                        }
                        if (item is Sale)
                        {
                            Sale sale = (Sale)item;

                            Console.WriteLine("Sale ID: {0} - {1} bought {2}",
                                sale.Id, sale.FindClient().Name, sale.FindProduct().Name);
                        }
                        if (item is Client)
                        {
                            Client client = (Client)item;
 
                            Console.WriteLine("{0} - {1} lives in {2} - Email: {3}",
                                client.Id, client.Name, client.Address, client.Email);
                            Console.WriteLine("Lista de compras:");
                            client.ShowBoughtProducts();
                        }
                        if (item is Seller)
                        {
                            Seller s = (Seller)item;

                            Console.WriteLine("{0} - {1} lives in {2} - Email: {3}",
                                s.Id, s.Name, s.Address, s.Email);
                        }
                        if (item is Product)
                        {
                            Product p = (Product)item;

                            Console.WriteLine("{0} - {1} costs {2} and has {3} units",
                                p.Id, p.Name, p.Price, p.Quantity);
                            
                        }
                    }
                }
            }
        }

    }
}
