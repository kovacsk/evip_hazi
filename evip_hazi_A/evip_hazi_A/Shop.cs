using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evip_hazi_A
{
    public class Shop
    {
        IDictionary<string, int> productlist = new Dictionary<string, int>();
        IDictionary<string, List<int>> discountlist = new Dictionary<string, List<int>>();

        public void RegisterProduct(String nev, int ertek)
        {
            productlist.Add(new KeyValuePair<string, int>(nev, ertek));

        }

        public int GetPrice(string n)
        {
            char[] characters = n.ToCharArray();
            int price = 0;

            for (int i = 0; i < characters.Length; i++) { 
                foreach (KeyValuePair<string, int> item in productlist)
                {
                    if ((characters[i].ToString()).Equals(item.Key))
                    {
                        price += item.Value;
                    }
                }
        }
            return price;
        }

        public void RegisterCountDiscoun(string n, int c, int d)
        {
            List<int> lista = new List<int>();
            lista.Add(c);
            lista.Add(d);
            discountlist.Add(new KeyValuePair<string, List<int>>(n, lista));
        }

        public int getVal(string sz)
        {
            if (productlist.ContainsKey(sz))
            {
                return productlist[sz];
            }
            else
            {
                return 0;
            }
        }
    }
}
