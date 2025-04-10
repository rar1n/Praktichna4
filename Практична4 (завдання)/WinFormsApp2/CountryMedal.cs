using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class CountryMedal
    {
        string craina;
        int kilkistsport;
        int zoloto;
        int sriblo;
        int bronza;
        public CountryMedal(string craina)
        {
            this.craina = craina;
        }
        public CountryMedal(string craina, int kilkistsport)
        {
            this.craina = craina;
            this.kilkistsport = kilkistsport;
        }
        public CountryMedal(string craina, int kilkistsport, int zoloto)
        {
            this.craina = craina;
            this.kilkistsport = kilkistsport;
            this.zoloto = zoloto;
        }
        public CountryMedal(string craina, int zoloto, int sriblo, int bronza)
        {
            this.craina = craina;
            this.zoloto = zoloto;
            this.sriblo = sriblo;
            this.bronza = bronza;
        }
        public CountryMedal(string craina, int kilkistsport, int zoloto, int sriblo, int bronza)
        {
            this.craina = craina;
            this.kilkistsport = kilkistsport;
            this.zoloto = zoloto;
            this.sriblo = sriblo;
            this.bronza = bronza;
        }
        public string GetInformation()
        {
            string information;
            information = "Країна: " + this.craina + ";" + " Кількість спортсменів: " + this.kilkistsport + ";" + " Кількість золотих медалей: " + this.zoloto + ";" + " Кількість срібних медалей: " + this.sriblo + ";" + " Кількість бронзових медалей: " + this.bronza;
            return information;
        }
    }
}
