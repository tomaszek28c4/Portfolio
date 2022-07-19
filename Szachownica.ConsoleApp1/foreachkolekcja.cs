using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachownica.ConsoleApp1
{
    public class foreachkolekcja
    {
        public CitizenEntity[] example()
        {
            string[] citizens = new string[]
            {
                "Tomek" , "Bartek" , "Karol" , "Ania"
            };
            CitizenEntity[] citizenEntities =new CitizenEntity[citizens.Length];
            int i = 0;
            int women = 0;
            int man = 0;

            foreach (string citizen in citizens)  // do zmiennej citizen wczytaj kolejne elementy tablicy/kolekcji cityzens
            {
                CitizenEntity citizenEntity = new CitizenEntity();
                citizenEntity.Name = citizen;


                if (citizen[citizen.Length-1] =='a' )
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
    }
}
