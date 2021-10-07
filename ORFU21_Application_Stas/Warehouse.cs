using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Application_Stas
{
    class Warehouse : DB
    {
        //public List<string> warehouseList = new List<string>() { "Wood" };
        

        DB DBClass = new DB();

        public void GetList() //Simple getlist
        {
            List<string> calledList = DBClass.GetInventory();
        }

        public void InventoryList()
        {
            List<string> calledList = DBClass.GetInventory();

            for (int i = 0; i < calledList.Count; i++)
            {
                Console.WriteLine($"{calledList[i]}");
            }
        }

        public void BaseMaterialList()
        {
            List<string> calledList = DBClass.GetBaseMaterial();

            for (int i = 0; i < calledList.Count; i++)
            {
                Console.WriteLine($"[{i+1}] {calledList[i]}");
            }
        }

        public void AddMaterialType()
        {
            List<string> calledList = DBClass.GetBaseMaterial();

            Console.WriteLine("\nWhat Material Do you want to add?");
            for (int i = 0; i < calledList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {calledList[i]}");
            }
        }

        public void AddMaterialNumber()
        {
            Console.WriteLine("\nHow Many?");
        }

        public void AddNewMaterial()
        {
            List<string> calledList = DBClass.GetInventory();

            for (int i = 0; i < 3; i++) //Just to see a definite change in the list.
            {
                //warehouseList.Add(baseMaterialList[baseMaterialInput - 1]);
                calledList.Add("Woohoo");//Gddmnit
                inventoryList.Add("Woohoo2");//wrywntthswrk
                DBClass.inventoryList.Add("Woohoo");//mthrfkr
            }
        }

    }
}
