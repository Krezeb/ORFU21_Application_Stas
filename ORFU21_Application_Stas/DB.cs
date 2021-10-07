using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Application_Stas
{
    class DB
    {
        public List<string> inventoryList { get; set; } = new List<string>() { "Wood" };

        public List<string> GetInventory()
        {
            return inventoryList;
        }

        private List<string> baseMaterialList = new List<string>() { "Wood", "Steel", "Glass", "Rubber" };

        public List<string> GetBaseMaterial()
        {
            return baseMaterialList;
        }
    }
}
