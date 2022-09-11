namespace Enumerator
{


    enum PoryRoku
    {
        Wiosna = 15, Lato = 25, Jesień = 10, Zima = -5  /*enumerator , wyznaczamy jedyne zmienne
                                                         * i przypisujemy in wartość liczbową */
    }

    enum DniTygodnia
    {
        Poniedziałek = 1 , Wtorek, Sroda, Czwartek , Piątek , Sobota , Niedziela
    }


    class program
    {
        public static void Main(string[] args)
        {
            PoryRoku poraRoku1 = (PoryRoku.Wiosna);  //metoda wywołania zmiennej
            Console.Write("Pora Roku  "+ poraRoku1); //wypisanie zmiennej po nazwie
            Console.WriteLine(" Srednia Temperatura  " + (int)PoryRoku.Wiosna); /*wypisanie zmienne po
                                                                                  wartości liczbowej*/

            PoryRoku poraRoku2 = (PoryRoku.Lato);
            Console.Write("Pora Roku  "+ poraRoku2);
            Console.WriteLine("   Srednia Temperatura  "+ (int)PoryRoku.Lato);

            PoryRoku poraRoku3 = (PoryRoku.Jesień);
            Console.Write("Pora Roku  "+ poraRoku3);
            Console.WriteLine(" Srednia Temperatura  " + (int)PoryRoku.Jesień);

            PoryRoku poraRoku = (PoryRoku.Zima);
            Console.Write("Pora Roku  "+ poraRoku);
            Console.WriteLine("   Srednia Temperatura  " + (int)PoryRoku.Zima);



            DniTygodnia dzienTygodnia1 = (DniTygodnia.Poniedziałek);
            Console.Write(dzienTygodnia1  );
            Console.WriteLine((int)DniTygodnia.Poniedziałek);

            DniTygodnia dzienTygodnia2 = (DniTygodnia.Wtorek);
            Console.Write(dzienTygodnia2 );
            Console.WriteLine((int)DniTygodnia.Wtorek);

            DniTygodnia dzienTygodnia3 = (DniTygodnia.Sroda);
            Console.Write(dzienTygodnia3);
            Console.WriteLine((int)DniTygodnia.Sroda);

            DniTygodnia dzienTygodnia4 = (DniTygodnia.Czwartek);
            Console.Write(dzienTygodnia4);
            Console.WriteLine((int)DniTygodnia.Czwartek);

            DniTygodnia dzienTygodnia5 = (DniTygodnia.Piątek);
            Console.Write(dzienTygodnia5);
            Console.WriteLine((int)DniTygodnia.Piątek);

            DniTygodnia dzienTygodnia6 = (DniTygodnia.Sobota);
            Console.Write(dzienTygodnia6);
            Console.WriteLine((int)DniTygodnia.Sobota);

            DniTygodnia dzienTygodnia7 = (DniTygodnia.Niedziela);
            Console.Write(dzienTygodnia7);
            Console.WriteLine((int)DniTygodnia.Niedziela);
        }


    }
}
