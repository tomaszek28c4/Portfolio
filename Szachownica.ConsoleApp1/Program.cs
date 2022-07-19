// See https://aka.ms/new-console-template for more information
using Szachownica.ConsoleApp1;

Console.WriteLine("Hello World!");

for (int i = 1; i <=1 ;i++ )
{ 
    Console.WriteLine("SZACHOWNICA!");

    for (int j = 1; j <= 4; j++)
    {
        Console.WriteLine("10101010");
        Console.WriteLine("01010101");
    }


}    

 for ( int i = 1; i<=3;i++ )
{
Console.WriteLine("Będę Programistą");
}



 

    for (int i = 0; i < 8; i++)
    {
        
          for (int x =0 ; x<8 ;x++) 
            {
                Console.Write((i+x)%2);  
               
                
            }

    Console.WriteLine();

     }



//pętla z palca
Console.WriteLine("Pętla z palca");
for (int i = 0; i < 8; i++)
{
    for (int x = 0; x < 8; x++)
    {
        Console.Write((i + x) % 2);

       
        if (i + x == 14)  //warunek w pętli
        {
            Console.WriteLine();
            Console.WriteLine("Tomek");

        }
    }
    Console.WriteLine();
}
Console.WriteLine("Sukces");
foreachkolekcja fk = new foreachkolekcja();
fk.example();