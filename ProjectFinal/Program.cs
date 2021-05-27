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
 



        }
        
    }
}
