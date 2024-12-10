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
    /// Class responsible for managing categories, allowing you to add and remove new categories and find categories 
    /// Created by: Marco
    /// Created on: 14/11/2024
    /// </summary>
    public class Categorys
    {
        #region Attributes
        #endregion

        #region Addition and Deletion

        /// <summary>
        /// Adds a category to a array of categorys
        /// </summary>
        /// <param name="cat">Object of a category</param>
        /// <returns>Bool - If added</returns>
        public static bool TryAddCategory(Category cat)
        {
            if(cat == null) 
                return false;

            if(MyComparations.IsCategory(cat))
            {
                if(ExistCategory(cat.Id))
                {
                    return false;
                }
                else
                {
                    return Shop.AddCategory(cat);
                }
            }

            return false;
        }

        /// <summary>
        /// Removes a category from an array of categorys
        /// </summary>
        /// <param name="codCat">Code of the category to remove</param>
        /// <returns>Bool - If removed</returns>
        public static bool TryRemoveCategory(int id)
        {
            if (id == 0 || id == -1)
                return false;

            if(ExistCategory(id))
            {
                return Shop.RemoveCategory(id);
            }

            return false;
        }

        /// <summary>
        /// Verifies if a category is in a array of categorys
        /// </summary>
        /// <param name="codCat">Code of the client to find</param>
        /// <returns>Bool - If the category is in the array</returns>
        private static bool ExistCategory(int id)
        {
            if (id == 0 || id == -1)
                return false;

            return Shop.ExistCategory(id);
        }
        #endregion

        /// <summary>
        /// Verify if a list of category has a category by Id and returns which category is it
        /// </summary>
        /// <param name="codCat">Code of the category to find</param>
        /// <returns>String - The category name that was found</returns>
        public static string HasCategory(int id)
        {
            if (id == 0 || id == -1)
                return "Empty Category";

            return Shop.HasCategory(id);
        }

        /// <summary>
        /// Verify if a list of category has a category by Id and returns which category is it
        /// </summary>
        /// <param name="codCat">Code of the category to find</param>
        /// <returns>Category - The category name that was found</returns>
        public static Category HasCategoryObj(int id)
        {
            if (id == 0 || id == -1)
                return null;

            return Shop.HasCategoryObj(id);
        }
        #region Testes
        //public static void MostrarCategoriasTESTE()
        //{
        //    foreach (Category c in listCategorys)
        //    {
        //        Console.WriteLine("{0} - {1} : Descricao {2}\n",
        //            c.Id, c.Name, c.Description);
        //    }
        //}
        #endregion
    }
}
