using System;
using System.Text;

namespace ProjectFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            #region console
            Console.OutputEncoding = Encoding.UTF8;
            int selection = 0;
            do
            {
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************Bravo Supermarket******************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine(" ");
                Console.WriteLine("1.Məhsullar üzərində əməliyyat aparmaq");
                Console.WriteLine(" ");
                Console.WriteLine("2.Satışlar üzərində əməliyyat aparmaq");
                Console.WriteLine(" ");
                Console.WriteLine("3.Sistemdən çıxmaq");
                Console.WriteLine("  ");
                Console.WriteLine("Zəhmət olmasa seçiminizi edin");

                int selectionStr = Convert.ToByte(Console.ReadLine());

                selection = byte.Parse(Console.ReadLine());

                switch (selection=1)
                {
                    case 1:

                    
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                }


            } while (selection!=0);



            #endregion
 //           1 Yeni mehsul elave et  -userden yeni mehsul yaradilmasi ucun lazim olan melumatlari daxil edilmelidir
 // - 2 Mehsul uzerinde duzelis et -duzelis edilecek mehsulun code - u ve duzelis melumatlari daxil edilmelidir
 // - 3 Mehsulu sil -mehsulu kodu daxil edilmelidir
 //- 4 Butun mehsullari goster - butun mehsullar gosterilecek(kodu, adi, categoriyasi, sayi, qiymeti)
 //   -5 Categoriyasina gore mehsullari goster -usere var olan kateqoriyalar gosteilecek ve onlar arasinda bir secim etmelidir ve secilmis kateqoriyadan olan butun mehsullar gosterilir(kodu, adi, categoriyasi, sayi, qiymeti)
 // - 6 Qiymet araligina gore mehsullari goster - userden minmum ve maximum qiymetleri daxil etmesi istenilir ve hemin qiymet araliginda olan mehsullar gosterilir(kodu, adi, categoriyasi, sayi, qiymeti)
 //   -7 Mehsullar arasinda ada gore axtaris et -useden text daxil etmesi istenilir ve adinda hemin text olan butun mehsullar gosterilir(kodu, adi, categoriyasi, sayi, qiymeti)



        }
        
    }
}
