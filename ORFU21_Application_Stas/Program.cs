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
            List<string> warehouseList = new List<string>() { "Wood", "Wood", "Steel" };
            List<string> baseMaterialList = new List<string>() { "Wood", "Steel", "Glass", "Rubber" };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------Magiska Fabriken------------\n");

                Console.WriteLine("Currently your warehouse holds:");
                for (int i = 0; i < warehouseList.Count; i++)
                {
                    Console.WriteLine($"{warehouseList[i]}");
                }

                Console.WriteLine("\nWhat Material Do you want to add?");
                for (int i = 0; i < baseMaterialList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {baseMaterialList[i]}");
                }
                
                int baseMaterialInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"How many do you wish to add?");
                int baseAmountInput = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < baseAmountInput; i++)
                {
                    warehouseList.Add(baseMaterialList[baseMaterialInput-1]);
                }
            }
        }
    }
}
