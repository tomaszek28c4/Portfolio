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
                "Tomek" , "Bartek" , "Karol" , "Ania" , "Karolina" , "Basia" , "Romek"
            };
            CitizenEntity[] citizenEntities =new CitizenEntity[citizens.Length];
            int i = 0;
            int women = 0;
            int man = 0;

            foreach (string citizen in citizens)  // do zmiennej citizen wczytaj kolejne elementy tablicy/kolekcji cityzens
            {
                CitizenEntity citizenEntity = new CitizenEntity();
                citizenEntity.Name = citizen;


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
            Console.WriteLine($"mężczyzn:{man} , kobiet {women}");
            return citizenEntities;
        }


        public bool IsFemale (string candidate)

        {    if (candidate[candidate.Length - 1] == 'a') 
            {
                Console.WriteLine("Is female"); return true;
            }
            Console.WriteLine("Is not a female"); return false;
               


        }
    }
}
