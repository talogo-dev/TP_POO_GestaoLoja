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
    /// Class responsible for managing Clients, allowing you to add new client and find clients
    /// Created by: Marco Cardoso
    /// Created on: 26/11/2024
    /// </summary>
    public class Clients
    {
        #region Attributes
        
        #endregion

        #region Addition and Deletion
        /// <summary>
        /// Adds a client to a array of clients
        /// </summary>
        /// <param name="cli">Object of a client</param>
        /// <returns>Bool - If added</returns>
        public static bool TryAddClient(Client cli)
        {

            if (cli == null)
                return false;

            // Verifica se é cliente
            if(MyComparations.IsClient(cli))
            {
                // Se já estiver na lista, return false
                if(ExistClient(cli.Id))
                {
                    return false;
                }
                else
                {
                    return Shop.AddClient(cli);
                }
            }

            return false;
        }

        /// <summary>
        /// Removes a client from an array of clients
        /// </summary>
        /// <param name="codCli">Code of the client to remove</param>
        /// <returns>Bool - If removed</returns>
        public static bool TryRemoveClient(int id)
        {
            if (id == 0 || id == -1)
                return false;

            if(ExistClient(id))
            {
                return Shop.RemoveClient(id);
            }

            return false;
        }

        /// <summary>
        /// Verifies if a client is in a array of clients
        /// </summary>
        /// <param name="codCli">Code of the client to find</param>
        /// <returns>Bool - If the client is in the array</returns>
        private static bool ExistClient(int id)
        {
            if(id == 0 || id == -1)
                return false;

            return Shop.ExistClient(id);
        }

        #endregion

        /// <summary>
        /// Verifies if a client is in a list of clients
        /// </summary>
        /// <param name="codClient">Code of the client to find</param>
        /// <returns>String - Name of the client found</returns>
        public static string HasClient(int id)
        {
            if (id == 0 || id == -1)
                return "Empty Client";

            return Shop.HasClient(id);
        }

        /// <summary>
        /// Verifies if a client is in a list of clients
        /// </summary>
        /// <param name="codClient">Code of the client to find</param>
        /// <returns>Client - Objet of the client found</returns>
        public static Client HasClientObj(int id)
        {
            if (id == 0 || id == -1)
                return null;

            return Shop.HasClientObj(id);
        }
        #region Testes
        //public static void MostrarClientesTESTE()
        //{
        //    foreach(Client c in listClients)
        //    {
        //        Console.WriteLine("{0} - {1} vive em {2} - Contacto {3}\n",
        //            c.Id, c.Name, c.Address, c.Email);
        //    }
        //}
        #endregion
    }
}
