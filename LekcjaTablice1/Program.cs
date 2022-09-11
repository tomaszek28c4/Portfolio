namespace Tablice1
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] tablica = new int[365];//tablica musi miec z gory przyjety w nawiasach [] rozmiar
            string[] dniTygodnia = /* tablica typu string */
                { "poniedziałek   ", "wtorek   ", "sroda   ", "czwartek   ",
                 "piatek   ", "sobota   ", "niedziela   " };

            for (int i = 0; i < dniTygodnia.Length; i++)
            {
                System.Console.Write(dniTygodnia[i]);
            }
            System.Console.WriteLine();
            program tab = new program();
            tab.tablicaDruga();

        }

        public void tablicaDruga()
        {
            int[,] tablica = new int [5,15] ;
            tablica[0, 0] = 1;
            tablica[0, 1] = 3;
            tablica[0, 2] = 4;
            tablica[1, 0] = 5;
            tablica[1, 1] = 6;
            tablica[1, 2] = 7;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {

                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    System.Console.Write(tablica [i, j] +  "  ");
                }
                System.Console.WriteLine();
            }

        }

    }

}