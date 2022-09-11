namespace ObiektyDziedziczenie3
{

    class Postac
    {
        public Postac()
        {


        }
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }
        public string imie;
        public int punktyHP;

        public void Ruch()
        {
            Console.WriteLine("Ruch Postaci");
        }

    }

    class Mag : Postac
    {
        public Mag(string imie, int punktyHP, int moc) : base(imie, punktyHP) //base czyli dziedziczenie po metodzie
        {
            this.moc = moc;
        }
        public int moc;
    }

    class Ogr : Postac
    {
        public Ogr(string imie, int punktyHP, int mlot) : base(imie, punktyHP)//dziedziczenie po metodzie
        {
            this.mlot = mlot;
        }

        public int mlot;

    }


    class program
    {
        public static void Main(string[] arg)
        {
            Postac p1 = new Postac("Tomasz", 200);
            Console.WriteLine(p1.imie + "   " + p1.punktyHP);
            p1.Ruch();

            Console.WriteLine();

            Mag m1 = new Mag("MAG", 200, 50);
            Console.WriteLine(m1.imie + "   " + m1.punktyHP + "  " + m1.moc);
            m1.Ruch();

            Console.WriteLine();

            Ogr o1 = new Ogr("Brutal", 100, 100);
            Console.WriteLine(o1.imie + "   " + o1.punktyHP + "  " + o1.mlot);
            o1.Ruch();


        }

    }
}