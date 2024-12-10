using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObjectsLib;

namespace Utils
{
    public class MyComparations
    {
        /// <summary>
        /// Verifies if an object is a client
        /// </summary>
        /// <param name="a">Object to verify</param>
        /// <returns>Bool - If its a client</returns>
        public static bool IsClient(Object a)
        {
            Client cli = new Client();
            if(a is Client)
            {
                cli = (Client)a;

                // Verifica se o id é valido
                if(cli.Id != 0 && cli.Id != -1)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        /// <summary>
        /// Verifies if an object is a category
        /// </summary>
        /// <param name="a">Object to verify</param>
        /// <returns>Bool - If its a category</returns>
        public static bool IsCategory(Object a)
        {
            Category cat = new Category();

            if (a is Category)
            {
                cat = (Category)a;

                // Verifica se o id é valido
                if (cat.Id != 0 && cat.Id != -1)
                {
                    return true;
                }
                return false;
            }

            return false;
        }

        /// <summary>
        /// Verifies if an object is a Product
        /// </summary>
        /// <param name="a">Object to verify</param>
        /// <returns>Bool - If its a product</returns>
        public static bool IsProduct(Object a)
        {
            Product prod = new Product();

            if (a is Product)
            {
                prod = (Product)a;

                // Verifica se o id é valido
                if (prod.Id != 0 && prod.Id != -1)
                {
                    return true;
                }
                return false;
            }

            return false;
        }

        /// <summary>
        /// Verifies if an object is a Sale
        /// </summary>
        /// <param name="a">Object to verify</param>
        /// <returns>Bool - If its a sale</returns>
        public static bool IsSale(Object a)
        {
            Sale sa = new Sale();

            if (a is Sale)
            {
                sa = (Sale)a;

                // Verifica se o id é valido
                if (sa.Id != 0 && sa.Id != -1)
                {
                    return true;
                }
                return false;
            }

            return false;
        }

        /// <summary>
        /// Verifies if an object is a Seller
        /// </summary>
        /// <param name="a">Object to verify</param>
        /// <returns>Bool - If its a seller</returns>
        public static bool IsSeller(Object a)
        {
            Seller sel = new Seller();

            if (a is Seller)
            {
                sel = (Seller)a;

                // Verifica se o id é valido
                if (sel.Id != 0 && sel.Id != -1)
                {
                    return true;
                }
                return false;
            }

            return false;
        }
    }
}
