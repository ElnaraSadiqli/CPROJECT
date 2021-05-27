using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Entities
{
    public class SalesItem :BaseEntite
    {    

      public Product Product { get; set; }
      private int _Count = 0;
        
    public SalesItem()

    {
           
       _Count++;
       No = _Count;
    }



    }
    
}
