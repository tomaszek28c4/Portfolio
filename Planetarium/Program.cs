using System;
using System.ComponentModel;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace Planetarium
{

    public abstract class CialoNiebieskie
    {
        public void Cialo()
        {
            string line;
            try
            {
                
                StreamReader sr = new StreamReader("C:\\Users\\HP\\Desktop\\planetarium.Cialoniebieskie.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line); //write the line to console window
                    line = sr.ReadLine(); //Read the next line
                }
                 sr.Close(); //close the file
               // Console.ReadLine();
            }
            catch (Exception e )
            {

                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
             //  Console.WriteLine("Executing finally block.");
               
            }
            
        }
        
        public virtual void Pokaz()
        {

        }
    }

    public  class Planeta : CialoNiebieskie
    {
        public override void Pokaz()
        {
            String line;
            try
            {
              StreamReader sr = new StreamReader("C:\\Users\\HP\\Desktop\\planetarium.Planeta.txt"); //Pass the file path and file name to the StreamReader constructor
              line = sr.ReadLine(); //Read the first line of text
               
                while (line != null)  //Continue to read until you reach end of file
                {
                  Console.WriteLine(line); //write the line to console window
                  line = sr.ReadLine();//Read the next line
                }
               
                sr.Close(); //close the file
               // Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                //Console.WriteLine("Executing finally block.");
            }
        }


    }

    public  class Ksiezyc : CialoNiebieskie
    {
        public override void Pokaz()
        {
            Console.WriteLine("Naturalny satelita (księżyc) – ciało niebieskie pochodzenia naturalnego," +
                " obiegające planetę, planetę karłowatą lub planetoidę. Słowo „Księżyc” pisane wielką literą" +
                " oznacza naturalnego satelitę Ziemi.\r\n\r\nŚciśle rzecz biorąc planeta i jej księżyce krążą" +
                " wokół wspólnego środka masy. Tradycyjnie tylko największy obiekt z takiego układu jest" +
                " nazywany planetą, lecz w przypadku planety i księżyca o zbliżonych rozmiarach mówi się" +
                " czasem o planetach podwójnych (układ Ziemia-Księżyc). Analogicznie układ Pluton−Charon" +
                " może być określany jako podwójna planeta karłowata.");

        }
    }


    class program
    {
      

        public static void Main(string[] args)
        {
            Console.WriteLine("START PROGRAMU");
            
            Planeta planeta = new Planeta(); 
            
            Ksiezyc ksiezyc = new Ksiezyc();
            planeta.Cialo();
            Console.WriteLine();
            planeta.Pokaz();
            Console.WriteLine();
            ksiezyc.Pokaz();


        }
    }
}
