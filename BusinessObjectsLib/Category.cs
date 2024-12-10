using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectsLib
{
    /// <summary>
    /// The Category class represents a category, with the attributes: id, name and description.
    /// Created by: Marco Cardoso
    /// Created on: 14/11/2024 
    /// </summary>
    [Serializable]
    public class Category
    {

        #region Attributes
        private static int newId = 1;

        private int id;
        private string name;
        private string description;
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
        /// Propertie for Description
        /// </summary>
        public string Description
        {
            get 
            { 
                return this.description; 
            }
            set 
            { 
                this.description = value; 
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Category()
        {
            this.Id = newId++;
            this.Name = "Empty - NAME";
            this.Description = "Empty - DESC";

        }
        /// <summary>
        /// First Constructor
        /// </summary>
        /// <param name="newName">Name</param>
        public Category(string newName)
        {
            this.Id = newId++;
            this.Name = newName;
            this.Description = "EMPTY - DESC";
        }
        /// <summary>
        /// Second Constructor
        /// </summary>
        /// <param name="newName">Name</param>
        /// <param name="newDescription">Description</param>
        public Category(string newName, string newDescription)
        {
            this.Id = newId++;
            this.Name = newName;
            this.Description = newDescription;
        }

        /// <summary>
        /// "Placeholder" Constructor
        /// </summary>
        /// <param name="newName"></param>
        public Category(int id)
        {
            this.Id = id;
        }
        #endregion

        #region Methods
        #endregion

    }

    #region OUTRAS COISAS
    /// <summary>
    /// Shows a list of products from a category (Listas)
    /// </summary>
    //public void ShowListProducts()
    //{
    //    int soma = 0;

    //    Console.WriteLine("Category {0}:\n",this.Name);
    //    if (listProducts.Count == 0)
    //    {
    //        Console.WriteLine("Empty list");
    //    }
    //    else
    //    {
    //        for (int i = 0; i < listProducts.Count; i++)
    //        {
    //            //// Crio uma variavel do tipo "Product" para armazenar cada item da lista de produtos
    //            //// E depois guardo o item convertido para a variavel criada
    //            Product p = new Product();
    //            p = (Product)listProducts[i];

    //            soma += p.Quantity.Quant;

    //            Console.WriteLine("ID: {0} - {1} - Quantity: {2} - For sale by: {3}", p.Id, p.Name, p.Quantity.Quant, p.Seller.Name);
    //        }
    //        Console.WriteLine("Quantity of Products: {0}", soma);
    //    }
    //}

    ///// <summary>
    ///// Shows a specific product in a category by an ID
    ///// </summary>
    ///// <param name="specId">Id of the product to find</param>
    ///// <returns>Product - The product found</returns>
    //public Product FindSpecId(int specId)
    //{
    //    for(int i = 0; i < 10; i++)
    //    {
    //        if (listProducts[i].Id == specId)
    //        {
    //            return listProducts[i];
    //        }
    //    }
    //    return null;
    //}


    ///// <summary>
    ///// Adds a product to a category
    ///// </summary>
    ///// <param name="product"></param>
    ///// <returns></returns>
    //public bool AddProduct(Product product)
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        if (listProducts[i] == null)
    //        {
    //            listProducts[i] = product;
    //            return true;
    //        }
    //    }
    //    return false;
    //}



    ///// <summary>
    ///// Shows a list of products from a category
    ///// </summary>
    //public void ShowListProducts()
    //{
    //    Console.WriteLine("{0}:\n",this.Name);
    //    for(int i = 0; i < 10; i++)
    //    {
    //        if (listProducts[i] != null)
    //            Console.WriteLine("{0} - {1}", listProducts[i].Id,listProducts[i].Name);
    //    }
    //}  
    #endregion
}
