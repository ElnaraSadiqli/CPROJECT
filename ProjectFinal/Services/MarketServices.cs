

using ProjectFinal.IMarket;

namespace ProjectFinal.Services
{
    public class MarketServices : IMarketAble
    {
        public void AddProduct(string name, double price, int quantity, int no)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduct(int no, int quantity)
        {
            throw new System.NotImplementedException();
        }

        public void DisplayAllProduct()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayByCategories(string categories)
        {
            throw new System.NotImplementedException();
        }

        public void DisplaySales()
        {
            throw new System.NotImplementedException();
        }

        public void ProductAdjustByCode(int no, string name, double price, int quantity, string categories, int newNo)
        {
            throw new System.NotImplementedException();
        }

        public void ProductByPriceRange(double minPrice, double maxPrice)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveFromSales(string name, int count, int no)
        {
            throw new System.NotImplementedException();
        }

        public void SalesAdd(string name, int count, double price, int no)
        {
            throw new System.NotImplementedException();
        }

        public void SalesByDateRange(DateTime startDate, DateTime endDate)
        {
            throw new System.NotImplementedException();
        }

        public void SalesByDateTime(DateTime date)
        {
            throw new System.NotImplementedException();
        }

        public void SalesByPriceRange(double minPrice, double maxPrice)
        {
            throw new System.NotImplementedException();
        }

        public void SalesBySelectNum(int no)
        {
            throw new System.NotImplementedException();
        }

        public void SalesDelete(int no, int count)
        {
            throw new System.NotImplementedException();
        }

        public void SearchByName(string text)
        {
            throw new System.NotImplementedException();
        }
    }
}
