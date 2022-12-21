using System;

namespace Interface_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Focus******");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlekOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("*****Civic*****");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlekOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine("*****Corolla*****");
            Corolla corolla=new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla.KacTekerlekOlusur().ToString());
            Console.WriteLine(corolla.StandartRengiNe().ToString());
            
        }
    }
}
