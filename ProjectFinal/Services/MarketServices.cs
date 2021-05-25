using ProjectFinal.Entities;
using ProjectFinal.IMarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Services
{
    class MarketServices:IMarketAble

    {
        public List<Product> Products { get; private set; }
        public List<Sales> Sales { get; private set; }
        List<Product> IMarketAble.Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Sales> IMarketAble.Sales { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MarketServices()
        {
            Products = new();
            Sales = new();
           
        }

        void IMarketAble.Products()
        {
            throw new NotImplementedException();
        }

        public void Sales_add()
        {
            throw new NotImplementedException();
        }

        public void Return_FromSales()
        {
            throw new NotImplementedException();
        }

        public void Return_Allsales()
        {
            throw new NotImplementedException();
        }

        public void Return_DateRange()
        {
            throw new NotImplementedException();
        }

        public void Return_DateTime()
        {
            throw new NotImplementedException();
        }
    }
    
}
