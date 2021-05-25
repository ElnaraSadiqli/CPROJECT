using ProjectFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.IMarket
{
    interface IMarketAble
    {
        #region List
        public List<Product> Products { get;  set; }
        public List<Sales> Sales { get;  set; }
        #endregion

        #region Sales Metods
        void Sales_add(int No,int ProCount);
        void Sales_delete(int Code);

        void Remove_FromSales(int ProductName,int ProCount,double TotalPrice);

        void Display_Sales(int ProCount, DateTime Date, int Number, double ProPrice, double TotalPrice);
        void Return_DateRange(int Number,double TotalPrice,DateTime Date,int ProCount); // Satışların tarix aralığına görə geri qaytarılması
        /// <summary>
        /// 
        /// </summary>
        void Return_PriceRange(DateTime date, int ProCount, double TotalPrice, int Number);
       void Return_DateTime(int Number,double TotalPrice,int ProCount,DateTime Date);
        void Display_SNumber(int Number, int ProCount, DateTime date, double TotalPrice, ); //Display Select Sales of Number


        #endregion
    }
//    (nomresi, meblegi, mehsul sayi, tarixi, satis itemlari (nomresi, mehsul adi, sayi))

////2 secildikde satislar uzerinde aparila bilinecek emeliyyatlarla bagli secimler gosterilir:
    
////    - 1 Yeni satis elave etmek - istifadeciden satis yaradilmasi ucun lazimi meulatlarin daxil edilmesi istenilir(mehsullarin kodlari)
////    - 2 Satisdaki hansisa mehsulun geri qaytarilmasi(satisdan cixarilmasi) - userden satisin, cixarilacaq mehsulun ve sayinin daxil edilmesi istenilir
////    - 3 Satisin silinmesi - satisin nomresine esasen silinmesi
////    - 4 Butun satislarin ekrana cixarilmasi(nomresi, meblegi, mehsul sayi, tarixi)
////    - 5 Verilen tarix araligina gore satislarin gosterilmesi - userden qebul edilen iki tarix araligindaki satislarin gosterilmesi(nomresi, meblegi, mehsul sayi, tarixi)
//    - 6 Verilen mebleg araligina gore satislarin gosterilmesi - userden qebul edilen iki mebleg araligindaki satislarin gosterilmesi(nomresi, meblegi, mehsul sayi, tarixi)
//    - 7 Verilmis bir tarixde olan satislarin gosterilmesi  - userden qebul edilmis bir tarixde olan satislarin gosterilmesi(nomresi, meblegi, mehsul sayi, tarixi)
//    //- 8 Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi - userden qebul edilmis nomdereye esasen hemin nomreli satisin melumatlarinin gosterilmesi(nomresi, meblegi, mehsul sayi, tarixi, satis itemlari (nomresi, mehsul adi, sayi))







}

//Satislar
//- Mehsullar
//- Satis elave etmek - satis elave edilerken hansi mehsullardan hansi sayda satis oldugu gonderilir
// - Satisdan mehsulun geri qaytarilmasi
// - Umumi satisin geri qaytarilmasi
// - Verilen tarix araligina gore hemin tarix araligina olan satislarin qaytarilmasi
// - Verilen bir tarixe gore hemin tarix (il, ay, gun) ucun olan satislarin qaytarilmasi



// - Verilmis mebleg araligina gore edilmis satislarin qaytarilmasi
// - Verilmis nomreye esasen satisin qaytarilmasi
// - Yeni mehsul elave etmek
// - Mehsulun adini, sayini ve meblegini, categoriyasini deyismek (code-a gore tapilacaq)
// -Verilmis kateqoriyaya esasen hemin kateqoriyada olan mehsullarin qaytarilmasi
// - Verilmis qiymet araligina esasen hemin araliqda olan mehsullarin qaytarilmasi
// - Verilmis ada esasen mehsullarin search edilib qaytarilmasi