using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataManagement
{
   public class InventoryManagement
    {
        public List<Rice> Rice;
        public List<Pulses> Pulses;
        public List<Wheat> Wheat;
        }
        public class Rice
        {
            public string name;
            public int weight;
            public int Price;
        }
   
          public class Pulses
          {
            public string name;
            public int weight;
            public int Price;
          }
          public class Wheat
           {
            public string name;
           public int weight;
          public int Price;
            }

}
