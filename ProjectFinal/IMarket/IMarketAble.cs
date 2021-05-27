using ProjectFinal.Entities;


namespace ProjectFinal.IMarket
{
    interface IMarketAble
    {
        #region Lists
        public List<Product> Products { get; private set; }
        public List<Sales> Sales { get; private set; }
       
        #endregion

        #region Product Metods
        void AddProduct(string name, double price, int quantity, int no);
        void ProductAdjustByCode(int no,string name,double price,int quantity,string categories,int newNo);

        void DeleteProduct(int no, int quantity);
        void DisplayAllProduct();
        void DisplayByCategories(string categories);
        void ProductByPriceRange(double minPrice, double maxPrice);
        void SearchByName(string text);

        #endregion

        #region Sales Metods
        void SalesAdd(string name, int count, double price, int no);
        void SalesDelete(int no,int count);
        void RemoveFromSales(string name, int count, int no);
        void DisplaySales();
        void SalesByDateRange(DateTime startDate,DateTime endDate );
        void SalesByPriceRange(double minPrice,double maxPrice);
        void SalesByDateTime(DateTime date);
        void SalesBySelectNum(int no);


        #endregion
   
    }
   
}
