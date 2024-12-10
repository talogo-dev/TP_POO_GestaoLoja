using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLib;

namespace BusinessRulesLib
{
    public class ShopRules
    {
        public static bool TryCreateDictionary()
        {
            return Shop.CreateDictionary();
        }

        // Mudar isto no futuro
        public static void MostrarTudo()
        {
            Shop.MostrarTudo();
        }
    }
}
