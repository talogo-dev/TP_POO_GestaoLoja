using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utils;

namespace BusinessObjectsLib
{
    /// <summary>
    /// The Person class represents a person, with the attributes: name, address and email.
    /// Created by: Marco Cardoso
    /// Created on: 14/11/2024 
    /// </summary>
    [Serializable]
    public class Person
    {
        #region Attributes
        private string name;
        private string address;
        private string email;
        #endregion

        #region Properties
        /// <summary>
        /// Propertie for Name
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        /// <summary>
        /// Propertie for Address
        /// </summary>
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        /// <summary>
        /// Propertie for Email
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if(MyValidations.IsEmail(value))
                {
                    this.email = value;
                }
                else
                {
                    this.Email = "EMPTY@gmail.com";
                }
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Person()
        {
            this.Name = "Empty Name";
            this.Address = "Empty Address";
            this.Email = "emptyEmail@gmail.com";
        }

        /// <summary>
        /// First Constructor
        /// </summary>
        /// <param name="newName">Name</param>
        /// <param name="newAddress">Address</param>
        /// <param name="newEmail">Email</param>
        public Person(string newName, string newAddress, string newEmail)
        {
            this.Name = newName;
            this.Address = newAddress;
            this.Email = newEmail;
        }
        #endregion

        #region Methods

        #endregion
    }
}
