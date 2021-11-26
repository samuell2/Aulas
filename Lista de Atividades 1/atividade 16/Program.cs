using System;

namespace atividade_16
{
    class Program
    {
        static void Main(string[] args)
        {           
           double paisa = 90000000;
           double paisb = 200000000;
           int anos = 0;
           
           while(paisa < paisb){
               paisa = (paisa * 1.03);
               paisb = (paisb * 1.015);
               anos++;
           }
           Console.WriteLine($"Anos: {anos}");
           Console.ReadLine();
                                  
        }
    }
}
