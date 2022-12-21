using System;

namespace Interface_Ornek
{
    public class Focus:IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
           return Marka.Ford;
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
