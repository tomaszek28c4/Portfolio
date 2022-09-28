namespace ObiektyTABLICE
{
    class filtr
    {
        public int Wiek { get; private set; }

        public void Rocznik(human[] people)
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Podaj wiek");
                int num = Convert.ToInt32(Console.ReadLine());
                Wiek = num;

                Console.WriteLine("Osoby starsze to  ");
                foreach (human h in people)
                {
                    if (h.Wiek > num)
                    {
                        Console.WriteLine($" { h.imie} { h.nazwisko} {h.Wiek} {h.gender}");
                    }
                }
            }
        }
    }

}

