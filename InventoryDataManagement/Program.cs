using System;


namespace InventoryDataManagement
{
     class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/FelloshipProgram/Inventory.json";
            Console.WriteLine("Welcome to the Inventory Data Management.!!!");

            ReadInventoryData readInventoryData = new ReadInventoryData();
            InventoryManagement data = readInventoryData.Read(path);

            for (int i = 0; i < data.Rice.Count; i++)
            {
                Console.WriteLine("Rice Details");
                Console.WriteLine("Name : " + data.Rice[i].name + " Weight : " + data.Rice[i].weight + " Price : " + data.Rice[i].Price);
                Console.WriteLine("---------------------------------------------------------");
            }


            for (int i = 0; i < data.Pulses.Count; i++)
            {
                Console.WriteLine("Pulses Details");
                Console.WriteLine("Name : " + data.Pulses[i].name + " Weight : " + data.Pulses[i].weight + " Price : " + data.Pulses[i].Price);
                Console.WriteLine("---------------------------------------------------------");
            }


            for (int i = 0; i < data.Wheat.Count; i++)
            {
                Console.WriteLine("Wheat Details");
                Console.WriteLine("Name : " + data.Wheat[i].name + " Weight : " + data.Wheat[i].weight + " Price : " + data.Wheat[i].Price);
                Console.WriteLine("---------------------------------------------------------");
            }
        }

        
    }
}
         