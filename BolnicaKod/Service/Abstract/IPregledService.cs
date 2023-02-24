using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Utill;

namespace bolnica.Service
{
    public interface IPregledService
    {
        bool DaLiJePrioritetLekar();

        List<Pregled> PrikaziPreglede();

        List<Pregled> PrikaziBuduce();

        List<Pregled> PronadjiPoImenuIliPrezimenu(String parametarpretrage);

        List<Pregled> PronadjiPoDatumu(DateTime pocetak, DateTime kraj);

        List<Pregled> PronadjiPoOrdinaciji(int brOrdinacije);

        Lekar IzaberiLekara(List<Lekar> lekar);

        DateTime IzaberiVremenskiPeriodTermina(DateTime pocetak, DateTime kraj);

        void IzaberiPrioritet(String lekar, String vremenskiInterval);

        List<Pregled> NadjiSlobodanTerminPoVremenu(DateTime pocetak, DateTime kraj);

        List<Pregled> NadjiSlobodanTerminPoLekaru(Lekar lekar);

        List<Pregled> NadjiSlobodanTerminPoLekaruIVremenu(DateTime pocetak, Lekar lekar, DateTime kraj);

        void OdbijZakazivanje(Pregled pregled);

        void PomeriSvePregledeOd(Trajanje termin);

        Prostorija NadjiPoTerminuIOrdinaciji(Trajanje termin, int id);
    }
}
