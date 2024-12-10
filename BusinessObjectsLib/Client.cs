using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utils;

namespace BusinessObjectsLib
{
    /// <summary>
    /// The Client class represents a client, with the id and dateBirth attributes and with attributes inherited from the Person class.
    /// Created by: Marco Cardoso
    /// Created on: 14/11/2024 
    /// </summary>
    [Serializable]
    public class Client : Person
    {
        #region Attributes
        private static int newId = 1;

        // Lista de produtos comprados
        List<Product> boughtProducts = new List<Product>();

        private int id;
        private DateTime dateBirth;
        #endregion

        #region Properties
        /// <summary>
        /// Propertie for Id
        /// </summary>
        public int Id
        {
            get 
            { 
                return id;
            }
            set
            {
                this.id = value;
            }
        }
        /// <summary>
        /// Propertie for DateBirth
        /// </summary>
        public DateTime DateBirth
        {
            get 
            {
                return this.dateBirth;
            }
            set
            {
                if (MyValidations.IsMinor(value))
                {
                    
                }
                else
                {
                    this.dateBirth = value;
                }
            }
        }
        /// <summary>
        /// Propertie of ClientsProducts
        /// </summary>
        public List<Product> BoughtProducts
        {
            get
            {
                return this.boughtProducts;
            }
            set
            {
                this.boughtProducts = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Client()
            :base()
        {
            this.Id = newId++;
        }

        /// <summary>
        /// First Constructor
        /// </summary>
        /// <param name="newName">Name</param>
        /// <param name="newAddress">Address</param>
        /// <param name="newEmail">Email</param>
        /// <param name="newDateBirth">Date of Birth</param>
        public Client(string newName, string newAddress, string newEmail, DateTime newDateBirth)
            :base(newName, newAddress, newEmail)
        {
            this.Id = newId++;
            this.DateBirth = newDateBirth;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Checks when is the client's birthday 
        /// </summary>
        /// <returns>Bool - If it's the client's birthday</returns>
        public bool IsBirthDay()
        {
            if(DateTime.Now.Day != this.DateBirth.Day || DateTime.Now.Month != this.DateBirth.Month)
            {
                return false;
            }
            return true;
        }

        ///// <summary>
        ///// Adds a product to the list of bought products
        ///// </summary>
        ///// <param name="p">Product to add</param>
        ///// <returns>Bool - If it adds</returns>
        public bool AddProduct(Product p)
        {
            if (p == null) return false;

            boughtProducts.Add(p);

            return false;
        }

        ///// <summary>
        ///// Shows a list of products bought by the client
        ///// </summary>
        public void ShowBoughtProducts()
        {
            double cost = 0;
            foreach (Product p in boughtProducts)
            {
                Console.WriteLine(p.Name + " - " + p.Price);
                cost += p.Price;
            }
            Console.WriteLine("\nGASTO: {0}", cost);
        }
        #endregion
    }
}
