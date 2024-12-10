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
    /// Class responsible for managing Sales, allowing you to add new sales and find sales
    /// Created by: Marco Cardoso
    /// Created on: 14/11/2024
    /// </summary>
    public class Sales
    {
        #region Attributes
        #endregion

        #region Addition and Deletion
        /// <summary>
        /// Adds a sale to a array of sales
        /// </summary>
        /// <param name="sale">Object of a sale</param>
        /// <returns>Bool - If added</returns>
        public static bool TryAddSale(Sale sale)
        {
            if(sale == null)
                return false;

            if(MyComparations.IsSale(sale))
            {
                if(ExistSale(sale.Id))
                {
                    return false;
                }
                else
                {
                    return Shop.AddSale(sale);
                }
            }

            return false;
        }

        /// <summary>
        /// Removes a sale from an array of sales
        /// </summary>
        /// <param name="codSale">Code of the sale to remove</param>
        /// <returns>Bool - If removed</returns>
        public bool TryRemoveSale(int id)
        {
            if (id == 0 || id == -1)
                return false;

            if(ExistSale(id))
            {
                return Shop.RemoveSale(id);
            }

            return false;
        }

        /// <summary>
        /// Verifies if a sale is in a array of sales
        /// </summary>
        /// <param name="codSale">Code of the sale to find</param>
        /// <returns>Bool - If the sale is in the array</returns>
        private static bool ExistSale(int id)
        {
            if (id == 0 || id == -1)
                return false;
            
            return Shop.ExistSale(id);
        }
        #endregion

        /// <summary>
        /// Find a specific sale in a array of sales
        /// </summary>
        /// <param name="codSale">Code of the sale to find</param>
        /// <returns>Int - Code of the sale</returns>
        public static int HasSale(int id)
        {
            if (id == 0 || id == -1)
                return -1;

            return Shop.HasSale(id);
        }

        /// <summary>
        /// Find a specific sale in a array of sales
        /// </summary>
        /// <param name="codSale">Code of the sale to find</param>
        /// <returns>Sale - Object of the sale</returns>
        public static Sale HasSaleObj(int id)
        {
            if (id == 0 || id == -1)
                return null;

            return Shop.HasSaleObj(id);
        }

        /// <summary>
        /// Checks if a product is in a sale
        /// </summary>
        /// <param name="codProd"></param>
        /// <returns>Int - Id of the sale</returns>
        public static int HasProductInSale(int id)
        {
            if (id == 0 || id == -1)
                return -1;

            return Shop.HasProductInSale(id);
        }

        /// <summary>
        /// Checks what client bought a specific product
        /// </summary>
        /// <param name="codProd">Code of the product to check</param>
        /// <returns>String - Name of the client</returns>
        public static string HasClientInSale(int id)
        {
            if (id == 0 || id == -1)
                return "Empty Client in Sale";

            return Shop.HasClientInSale(id);
        }
        #region Testes
        //public static void MostrarVendasTESTE()
        //{
        //    foreach (Sale s in listSales)
        //    {
        //        Console.WriteLine("{0} - {1} comprou {2}\n",
        //            s.Id, s.CodClient, s.CodProduct);
        //    }
        //}
        #endregion
    }
}
