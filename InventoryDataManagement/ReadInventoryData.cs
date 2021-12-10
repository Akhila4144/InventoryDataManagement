using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace InventoryDataManagement
{
    class ReadInventoryData
    {
        public InventoryManagement Read(string path)
        {
            try
            {
                using var file = new StreamReader(path);
                string json = file.ReadToEnd();
                return JsonConvert.DeserializeObject<InventoryManagement>(json);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Problem in Getting data {0}", ex);
                return null;

            }
        }
    }
}

    

    