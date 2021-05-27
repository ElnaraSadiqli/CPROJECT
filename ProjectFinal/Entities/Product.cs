
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Entities
{
    public  class Product : BaseEntite
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get;  set; }
        int Quantity = 0;
        #region Product Categories(enum)
        enum Categories
        {
            Meat,
            Vegetables,
            Dairy,
            Bakery,
            Sweet,
            Drinks,

        }
        #endregion

        public Product()
        {

            Quantity++;
            No = Quantity;


        }

       
    }
}

 
 
 