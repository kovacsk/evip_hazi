using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evip_hazi_A
{
    class Shop
    {
        IDictionary<string, int> productlist = new Dictionary<string, int>();


        public void RegisterProduct(String nev, int ertek)
        {
            productlist.Add(new KeyValuePair<string, int>(nev, ertek));

        }

        public int GetPrice(string n)
        {
            string[] characters = n.Split();
            int price = 0;

            for (int i = 0; i < characters.Length; i++) { 
                foreach (KeyValuePair<string, int> item in productlist)
                {
                    if (characters[i] == item.Key)
                    {
                        price += item.Value;
                    }
                }
        }
            return price;
        }
    }
}
