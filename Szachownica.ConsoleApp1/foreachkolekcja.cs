using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachownica.ConsoleApp1
{
    public class foreachkolekcja
    {
        public CitizenEntity[] example() //sygnatura metody wywoływanej z klasy foreachkolekcja
        {
            string[] citizens = new string[]
            {
                "Tomek" , "Bartek" , "Karol" , "Romek" , "Ania" , "Karolina" , "Basia" , "Romek"
            };

           
            CitizenEntity[] citizenEntities =new CitizenEntity[citizens.Length];
            int i = 0;
            int women = 0;
            int man = 0;

            foreach (string citizen in citizens)  // do zmiennej citizen wczytaj kolejne elementy tablicy/kolekcji cityzens
            {
                CitizenEntity citizenEntity = new CitizenEntity();
                citizenEntity.Name = citizen;
                revers(citizen);
                odwrotnie(citizen);
              //  if (citizen[citizen.Length-1] =='a' )
                if (IsFemale(citizen)  )
                {
                    citizenEntity.gender = 1;
                    women++;
                   
                }
                else { citizenEntity.gender = 2;
                man++;
                }
                citizenEntities[i] = citizenEntity;
                
                i++;
                
            }

            IsFemale("Adrianna");
            Console.WriteLine("Podaj imie");
            IsFemale(Console.ReadLine());
            Console.WriteLine($"mężczyzn:{man} , kobiet {women}");
            return citizenEntities;

        }

        public void revers(string item) //publiczna metoda revers
        {
            for (int i = item.Length - 1; i >= 0; i--)
            {
                Console.Write(item[i]);
            }
        }
        
        public bool IsFemale (string candidate)

        {
            

            if (candidate[candidate.Length - 1] == 'a') 
            {
                Console.WriteLine("Kobieta: " + candidate);  return true;
            }
            Console.WriteLine("Mężczyzna: " + candidate); return false;


            
        }
        public void odwrotnie(string odwrot)
        {
            for (int i = odwrot.Length-1; i>=0 ; i--)     
                Console.Write(odwrot[i]);
        }
    }  
}        
