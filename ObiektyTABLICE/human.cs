namespace ObiektyTABLICE
{
    internal class human
    {
        public string imie;
        public string nazwisko;
        public string gender;
        private int wiek;
        public int Wiek
        {
            get { return wiek; }
            set
            {

                if (value > 0 && value < 200)
                    wiek = value;
                else wiek = 0;
            }

        }


    }
}
