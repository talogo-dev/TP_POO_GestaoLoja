using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessRulesLib;

namespace BusinessObjectsLib
{
    /// <summary>
    /// The Seller class represents a salesperson, with the id attribute and with attributes inherited from the Person class.
    /// Created by: Marco Cardoso
    /// Created on: 14/11/2024 
    /// </summary>
    [Serializable]
    public class Seller : Person
    {
        #region Attibutes
        private static int newId = 1;

        private int id;
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
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Seller() 
            :base()
        {
            this.Id = newId++;
        }

        /// <summary>
        /// First Constructor
        /// </summary>
        /// <param name="newName">Name of the Seller</param>
        /// <param name="newAddress">Address of the seller</param>
        /// <param name="newEmail">Email of the seller</param>
        public Seller(string newName, string newAddress, string newEmail)
            : base(newName, newAddress, newEmail)
        {
            this.Id = newId++;
        }

        /// <summary>
        /// "Placeholder" Constructor
        /// </summary>
        public Seller(int id)
            : base()
        {
            this.Id = id;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Check if a list of sellers has a seller with the codeSeller
        /// </summary>
        /// <param name="codSeller">Code of the seller to find</param>
        /// <returns>String - Name of the seller</returns>
        public string HasSeller(int codSeller)
        {
            return Sellers.HasSeller(codSeller);
        }
        #endregion
    }
}
