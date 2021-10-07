using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Application_Stas
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> baseMaterialList = new List<string>() { "Wood", "Steel", "Glass", "Rubber" };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------Magiska Fabriken------------\n");

                Console.WriteLine("Currently your warehouse holds:");
                Warehouse showWarehouse = new Warehouse();
                showWarehouse.WarehouseList();

                Warehouse addMaterialType = new Warehouse();
                addMaterialType.AddMaterialType();
                int typ = Convert.ToInt32(Console.ReadLine());

                Warehouse addMaterialNumber = new Warehouse();
                addMaterialNumber.AddMaterialNumber();
                int num = Convert.ToInt32(Console.ReadLine());

                Warehouse addNewMaterialToList = new Warehouse();
                addNewMaterialToList.AddNewMaterial(typ, num);

                //Console.WriteLine("\nWhat Material Do you want to add?");
                //Warehouse showMaterials = new Warehouse();
                //showWarehouse.BaseMaterialList();

                //int baseMaterialInput = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine($"How many do you wish to add?");
                //int baseAmountInput = Convert.ToInt32(Console.ReadLine());

                //for (int i = 0; i < baseAmountInput; i++)
                //{
                //    warehouseList.Add(baseMaterialList[baseMaterialInput - 1]);
                //}
            }
        }
    }
}
