using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Application_Stas
{
    class Warehouse
    {
        public List<string> warehouseList = new List<string>() { };
        public List<string> baseMaterialList = new List<string>() { "Wood", "Steel", "Glass", "Rubber" };
    public void WarehouseList()
        {
            for (int i = 0; i < warehouseList.Count; i++)
            {
                Console.WriteLine($"{warehouseList[i]}");
            }
        }
        public void BaseMaterialList()
        {
            for (int i = 0; i < baseMaterialList.Count; i++)
            {
                Console.WriteLine($"[{i+1}] {baseMaterialList[i]}");
            }
        }
        
        public void AddMaterialType()
        {
            Console.WriteLine("\nWhat Material Do you want to add?");
            for (int i = 0; i < baseMaterialList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {baseMaterialList[i]}");
            }
        }

        public void AddMaterialNumber()
        {
            Console.WriteLine("\nHow Many?");
        }

        public void AddNewMaterial(int baseMaterialAmountInput, int baseMaterialInput)
        {
            for (int i = 0; i < baseMaterialAmountInput; i++)
            {
                warehouseList.Add(baseMaterialList[baseMaterialInput - 1]);
            }
        }

    }
}
