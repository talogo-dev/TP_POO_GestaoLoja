using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessRulesLib;

namespace BusinessObjectsLib
{
    /// <summary>
    /// The Product class represents a product, with the attributes: id, price, name, quantity, codSeller and codCategory.
    /// Created by: Marco Cardoso
    /// Created on: 14/11/2024 
    /// </summary>
    [Serializable]
    public class Product
    {
        #region Attributes
        private static int newId = 1;

        private int id;
        private double price;
        private string name;
        private int quantity;

        private int codSeller;
        private int codCategory;
        #endregion

        #region Properties
        /// <summary>
        /// Propertie of Id
        /// </summary>
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Property of Price
        /// </summary>
        public double Price
        {
            get { return this.price; }
            set
            {
                this.price = value;
            }
        }

        /// <summary>
        /// Propertie of Name
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }
        /// <summary>
        /// Propertie of Quantity
        /// </summary>
        public int Quantity
        {
            get 
            { 
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }

        /// <summary>
        /// Propertie of CodSeller
        /// </summary>
        public int CodSeller
        {
            get
            { 
                return this.codSeller; 
            }
            set 
            {
                this.codSeller = value;
            }
        }

        /// <summary>
        /// Propertie of CodCategory
        /// </summary>
        public int CodCategory
        {
            get
            {
                return this.codCategory;
            }
            set
            {
                this.codCategory = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Product()
        {
            this.Id = newId++;
            this.Price = 0.0;
            this.Name = "Empty Name";
            this.Quantity = 0;
            this.CodSeller = 0;
        }

        /// <summary>
        /// First Constructor
        /// </summary>
        /// <param name="newPrice">Price</param>
        /// <param name="newName">Name</param>
        /// <param name="newCodSeller">Code of the seller</param>
        /// <param name="newCodCategory">Code of the category</param>
        public Product(double newPrice, string newName, int newCodSeller, int newCodCategory)
        { 
            this.Id = newId++;
            this.Price = newPrice;
            this.Name = newName;
            this.Quantity = 0;

            this.CodSeller = newCodSeller;
            this.CodCategory = newCodCategory;

        }

        /// <summary>
        /// Second Constructor
        /// </summary>
        /// <param name="newPrice">Price</param>
        /// <param name="newName">Name</param>
        /// <param name="newCodSeller">Code of the seller</param>
        /// <param name="newCodCategory">Code of the category</param>
        /// <param name="newStock">Quantity of products</param>
        public Product(double newPrice, string newName, int newCodSeller, int newCodCategory, int newStock)
        {
            this.Id = newId++;
            this.Price = newPrice;
            this.Name = newName;
            this.Quantity = newStock;

            this.CodSeller = newCodSeller;
            this.CodCategory = newCodCategory;
        }

        /// <summary>
        /// "Placeholder" Constructor
        /// </summary>
        public Product(int id)
        {
            this.Id = id;
        }

        #endregion

        #region Methods
        ///// <summary>
        ///// Find the product category 
        ///// </summary>
        ///// <returns>String - Name of the category</returns>
        public string FindCategory()
        {
            return Categorys.HasCategory(this.CodCategory);
        }

        ///// <summary>
        ///// Find the product seller 
        ///// </summary>
        ///// <returns>String - Name of the seller</returns>
        //public string FindSeller()
        //{
        //    return Shop.HasSeller(this.CodSeller);
        //}

        ///// <summary>
        ///// Find the sale where a product is 
        ///// </summary>
        ///// <returns>Int - Id of the sale</returns>
        //public int FindProductInSale()
        //{
        //    return Shop.HasProductInSale(this.id);
        //}

        ///// <summary>
        ///// Find which client bought the product
        ///// </summary>
        ///// <returns>String - Name of the client</returns>
        //public string FindClientInSale()
        //{
        //    return Shop.HasClientInSale(this.id);
        //}

        #endregion
    }
}
