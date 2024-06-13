using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_lab_6
{
    public class Phonelab6
    {
        public int id;
        public string name;     
        public string shop_id;
        public int price;
        public int des;

        public Phonelab6 ( int id, int shop_id, string name, int price, string des ) 
        {
           this.id = id;
           this.shop_id = shop_id;
           this.name = name;
           this.price = price;
           this.des = des;
        }

        List<Phonelab6> listShop = new List<Phonelab6>();
        ListSortDescription

        static void Main(string[] args)
        {

        }
    }
}
