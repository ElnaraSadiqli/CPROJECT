
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Entities
{
    public  class Product : BaseEntite
    {   
       
        public double ProPrice { get; set; }
        public short ProCount { get; private set; }
      
        private short _ProCount = 0;
        private short _Procount;

        //Product Categories(enum)

        #region
        enum Categories
        {
            Meat,
            Vegetables,
            Dairy,
            Bakery,
            Sweet

        }
        #endregion

        public  Product()
        {

            _Procount++;
            No = _ProCount;


        }

       
    }
}

 
 
 