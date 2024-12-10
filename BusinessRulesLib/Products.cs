using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObjectsLib;
using DataLib;
using Utils;

namespace BusinessRulesLib
{
    /// <summary>
    /// Class responsible for managing Products, allowing you to add new products and find products
    /// Created by: Marco Cardoso
    /// Created on: 14/11/2024
    /// </summary>
    public class Products
    {
        #region Attributes
        #endregion

        #region Addition and Deletion
        /// <summary>
        /// Adds a Product to a array of Products
        /// </summary>
        /// <param name="prod">Object of a product</param>
        /// <returns>Bool - If added</returns>
        public static bool TryAddProduct(Product prod)
        {
            if (prod == null)
                return false;

            // Verifica se é cliente
            if (MyComparations.IsProduct(prod))
            {
                // Se já estiver na lista, return false
                if (ExistProduct(prod.Id))
                {
                    return false;
                }
                else
                {
                    return Shop.AddProduct(prod);
                }
            }

            return false;
        }

        /// <summary>
        /// Removes a product from an array of products
        /// </summary>
        /// <param name="codProd">Code of the product to remove</param>
        /// <returns>Bool - If removed</returns>
        public static bool TryRemoveProduct(int id)
        {

            if (id == 0 || id == -1)
                return false;

            if (ExistProduct(id))
            {
                return Shop.RemoveProduct(id);
            }

            return false;
        }

        /// <summary>
        /// Verifies if a product is in a array of products
        /// </summary>
        /// <param name="codProd">Code of the product to find</param>
        /// <returns>Bool - If the product is in the array</returns>
        private static bool ExistProduct(int id)
        {
            if (id == 0 || id == -1)
                return false;

            return Shop.ExistProduct(id);
        }
        #endregion
        /// <summary>
        /// Verify if a list of Product has a Product by Id and returns what Product is it
        /// </summary>
        /// <param name="codProd">Code of the Product to find</param>
        /// <returns>Product - The Product found</returns>
        public static Product HasProductObj(int id)
        {
            if (id == 0 || id == -1)
                return null;

            return Shop.HasProductObj(id);
        }
        #region Testes
        //public static void MostrarProdutosTESTE()
        //{
        //    foreach (Product c in listProducts)
        //    {
        //        Console.WriteLine("{0} - {1} custa {2} e tem {3}\n",
        //            c.Id, c.Name, c.Price, c.Quantity);
        //    }
        //}
        #endregion
    }
}
