// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

KolekcjaImiona fk = new KolekcjaImiona();
fk.Exampel();
public class KolekcjaImiona //nazwa klasy
{
    public KolekcjaImion[] Exampel
        ()//sygnatura metody wywoływanej z klasy KolekcjaImiona
    {
        string[] mieszkancy = new string[] //tabela imion

        {
            "Tomek" , "Romek" , "Bartek" , "Julka" , "Zuzia" , "Ania"
        };

        KolekcjaImion[] KolekcjaImion = new KolekcjaImion[mieszkancy.Length]; //Klasa-Zmienna-nowaKlasa
        int i = 0;
        int women = 0; //zmiennna płeć
        int man = 0;   //zmiennna płeć
        foreach (string mieszkaniec in mieszkancy) // do zmiennej mieszkaniec wczytaj kolejne elementy tablicy/kolekcji mieszkancy
        {
            if (mieszkaniec[mieszkaniec.Length - 1] == 'a') //sprawdzanie ostatniego znaku w imieniu
            {
                Console.WriteLine("Kobieta: " + mieszkaniec); // jeśli ostatnia litera to A
            }
            else
            {
                Console.WriteLine("Mężczyzna: " + mieszkaniec); //jśli ostatnia litera inna niż A
            }
            
        }
        return KolekcjaImion; //!!!!zwracanie wyniku pętli FOREACH

    }


}