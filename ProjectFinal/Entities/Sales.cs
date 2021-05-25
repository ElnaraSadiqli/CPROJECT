
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Entities
{
    class Sales 
    {
       
     
    public DateTime Date { get; set; }
    public int Number { get; private set; }
    public double  TotalPrice { get; set; }
   
    List<SalesItem> SalesItems = new List<SalesItem>();


    }


}

