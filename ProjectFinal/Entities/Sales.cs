
using ProjectFinal.IMarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Entities
{    
     public  class Sales : BaseEntite
    {


        public DateTime Date { get; set; }
        public double Cost { get; set; }

        List<SalesItem> SalesItems { get; private set; }

        public Sales()
        {
            SalesItems = new
            Date= DateTime.Now;
        }
       
    }
}

