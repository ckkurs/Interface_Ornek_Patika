using System;

namespace Interface_Ornek
{
    public class Corolla:IOtomobil
    {
       public Marka HangiMarkaninAraci()
        {
           return Marka.Toyota;
        }

        public int KacTekerlekOlusur()
        {
           return 4;
        }

        public Renk StandartRengiNe()
        {
           return Renk.Beyaz;
        }
    }
        
}