using System;
namespace Uppgift_5_4
{
    class program
    {
        static void Main(string[] args)
        {
            string a = " ";
            char tecken;
            char tecken1;
            string[] Namn = new string[5];
            Namn[0] = ("Patrik");
            Namn[1] = ("Adam");
            Namn[2] = ("kalle");
            Namn[3] = ("Göran");
            Namn[4] = ("Bella");
            


            for (int i = 0; i < Namn.Length; i++)
            {
                
                
                tecken = Namn[i] [0];
                i++;
               
                if ( i == 0)
                {
                    a = Namn[i];
                    
                }
               
              else  if (tecken > )
                {
                    Console.WriteLine();
                   a = Namn[i] ;
                }
                i--;
                
            }
            Console.WriteLine(a +"ggg");
        }
    }
}