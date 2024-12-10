using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessRulesLib;

namespace BusinessObjectsLib
{
    /// <summary>
    /// The Sale class represents a sale, with the attributes: id, codClient, codProduct and date.
    /// Created by: Marco Cardoso
    /// Created on: 14/11/2024 
    /// </summary>
    [Serializable]
    public class Sale
    {
        #region Atributtes
        private static int newId = 1;     

        private int id;
        private int codClient;
        private int codProduct;
        private DateTime date;
        #endregion

        #region Properties
        /// <summary>
        /// Propertie for Id
        /// </summary>
        public int Id
        {
            get 
            { 
                return this.id; 
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Propertie for CodClient
        /// </summary>
        public int CodClient
        {
            get 
            { 
                return this.codClient; 
            }
            set
            {
                this.codClient = value;
            }
        }

        /// <summary>
        /// Propertie for CodProduct
        /// </summary>
        public int CodProduct
        {
            get 
            { 
                return this.codProduct; 
            }
            set
            {
                this.codProduct = value;
            }
        }

        /// <summary>
        /// Propertie of Date
        /// </summary>
        public DateTime Date
        {
            get 
            { 
                return this.date; 
            }
            set 
            { 
                this.date = value; 
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Sale()
        {
            this.Id = newId++;

            this.CodClient = 0;
            this.CodProduct = 0;

            this.Date = DateTime.Now;
        }

        /// <summary>
        /// First Constructor
        /// </summary>
        /// <param name="newCodClient">Client</param>
        /// <param name="newCodProduct">Product</param>
        /// <param name="date">Date</param>
        public Sale(int newCodClient, int newCodProduct, DateTime date)
        {
            this.Id = newId++;
            this.CodClient = newCodClient;
            this.CodProduct = newCodProduct;
            this.Date = date;

            AddProductToListClient();
        }

        /// <summary>
        /// "Placeholder" Constructor
        /// </summary>
        public Sale(int id)
        {
            this.Id = id;
        }

        #endregion

        #region Methods
        ///*
        // * Melhorar
        // */

        ///// <summary>
        ///// Remove 1 from the product stock
        ///// </summary>
        public void FindProductRemoveStock()
        {
            
            Product p = Products.HasProductObj(this.CodProduct);
            p.Quantity -= 1;
        }

        ///// <summary>
        ///// Finds a product by the code
        ///// </summary>
        ///// <returns>Product - Product found</returns>
        public Product FindProduct()
        {
            Product p = Products.HasProductObj(this.CodProduct);
            if (p == null) return null;
            return p;
        }

        ///// <summary>
        ///// Finds a client by the code
        ///// </summary>
        ///// <returns>Client - Client found</returns>
        public Client FindClient()
        {
            Client c = Clients.HasClientObj(this.CodClient);
            if (c == null) return null;

            return c;
        }

        ///// <summary>
        ///// ADICIONA O PRODUTO A LISTA DE PRODUTOS COMPRADOS por UM CLIENTE
        ///// </summary>
        ///// <returns></returns>
        public bool AddProductToListClient()
        {
            Client c = FindClient();
            if (c == null) return false;
            Product p = FindProduct();
            if (p == null) return false;

            if (c.Id == this.codClient)
            {
                c.AddProduct(p);
                // Remove 1 do stock do produto
                FindProductRemoveStock();
                return true;
            }

            return false;
        }
        #endregion

    }
}
