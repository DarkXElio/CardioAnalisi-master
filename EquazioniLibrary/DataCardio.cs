using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class DataCardio
    {
        public static double FrequenzaBattitoCardiacoMAX(string eta, ref string errore)
        {
            double x = 0, max = 0;


            try
            {
                x = 220 - Convert.ToInt32(eta);
                max = x * 0.7;
            }
            catch
            {
                errore = "Non hai inserito un numero";
            }

            if (x > 220)
            {
                max = 0;
                errore = "Non esiste l'eta minire di 0 ";
            }
            return max;
        }



        public static double FrequenzaBattitoCardiacoMIN(string eta, ref string errore)
        {
            double x = 0, min = 0;


            try
            {
                x = 220 - Convert.ToInt32(eta);
                min = x * 0.9;
            }
            catch
            {
                errore = "Non hai inserito un numero";
            }

            if (x > 220)
            {
                min = 0;
                errore = "Non esiste l'eta minire di 0 ";
            }
            return min;
        }

        public static string cardiacariposo(int cardiacanumero)
        {
            string msg = " ";
            if (cardiacanumero < 60) msg = " Badicardia ";

            if (59 < cardiacanumero && cardiacanumero < 101) msg = " Normale ";

            if (cardiacanumero > 100) msg = " Tachicardia ";

            return msg;
        }









    }
}
