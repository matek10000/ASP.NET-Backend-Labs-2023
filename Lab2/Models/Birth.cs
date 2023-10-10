using Lab2.Controllers;

namespace Lab2.Models
{
    public class Birth
    {

        public string? imie { get; set; }
        public DateTime wiek { get; set; }

        public bool IsValid()
        {
            return imie != null && wiek < DateTime.Now;
        }

        public double CalcBirth()
        {
            DateTime datenow = DateTime.Now;

            int agenow = datenow.Year - wiek.Year;

            if (datenow.Month < wiek.Month || (datenow.Month == wiek.Month && datenow.Day < wiek.Day))
            {
                agenow--;
            }

            return agenow;
        }
    }
}