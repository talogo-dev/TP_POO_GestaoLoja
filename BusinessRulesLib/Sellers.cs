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
    /// Class responsible for managing Sellers, allowing you to add new sellers and find sellers
    /// Created by: Marco Cardoso
    /// Created on: 26/11/2024
    /// </summary>
    public class Sellers
    {
        #region Attributes
        
        #endregion

        #region Addition and Deletion
        /// <summary>
        /// Adds a seller to a array of sellers
        /// </summary>
        /// <param name="sel">Object of a seller</param>
        /// <returns>Bool - If added</returns>
        public static bool TryAddSeller(Seller sel)
        {
            if (sel == null)
                return false;

            // Verifica se é cliente
            if (MyComparations.IsSeller(sel))
            {
                // Se já estiver na lista, return false
                if (ExistSeller(sel.Id))
                {
                    return false;
                }
                else
                {
                    return Shop.AddSeller(sel);
                }
            }

            return false;
        }

        /// <summary>
        /// Removes a seller from an array of sellers
        /// </summary>
        /// <param name="codSel">Code of the seller to remove</param>
        /// <returns>Bool - If removed</returns>
        public static bool TryRemoveSeller(int id)
        {
            if (id == 0 || id == -1)
                return false;

            if (ExistSeller(id))
            {
                return Shop.RemoveSeller(id);
            }

            return false;
        }

        /// <summary>
        /// Verifies if a seller is in a list of sellers
        /// </summary>
        /// <param name="codSeller">Code of the seller to find</param>
        /// <returns>Bool - If the seller is in the array</returns>
        private static bool ExistSeller(int id)
        {
            if (id == 0 || id == -1)
                return false;

            return Shop.ExistSeller(id);
        }
        #endregion


        /// <summary>
        /// Verifies if a seller is in a list of sellers
        /// </summary>
        /// <param name="codSeller">Code of the seller to find</param>
        /// <returns>String - Name of the seller found</returns>
        public static string HasSeller(int id)
        {
            if (id == 0 || id == -1)
                return "Empty Seller";

            return Shop.HasSeller(id);
        }

        /// <summary>
        /// Verifies if a seller is in a list of sellers
        /// </summary>
        /// <param name="codSeller">Code of the seller to find</param>
        /// <returns>String - Name of the seller found</returns>
        public Seller HasSellerObj(int id)
        {
            if (id == 0 || id == -1)
                return null;

            return Shop.HasSellerObj(id);
        }
        #region Testes
        //public static void MostrarVendedoresTESTE()
        //{
        //    foreach(Seller s in listSellers)
        //    {
        //        Console.WriteLine("{0} - {1} vive em {2} - Contacto {3}\n",
        //            s.Id, s.Name, s.Address, s.Email);
        //    }
        //}
        #endregion
    }
}
