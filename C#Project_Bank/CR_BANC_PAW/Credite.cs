using System;

namespace CR_BANC_PAW
{
    [Serializable]
    public class Credite
    {
        public static int idCounter = 0;
        public int ID { get; set; }
        public float SumaImprumutata { get; set; }
        public float Dobanda { get; set; }
        public int TermenRambursare { get; set; }
        public bool EsteActiv { get; set; }

        public Credite()
        {
            // Initialize properties with default values
            ID = 0;
            SumaImprumutata = 0;
            Dobanda = 0;
            TermenRambursare = 0;
            EsteActiv = false;
        }

        public Credite(float sumaImprumutata, float dobanda, int termenRambursare)
        {
            ID = ++idCounter;
            SumaImprumutata = sumaImprumutata;
            Dobanda = dobanda;
            TermenRambursare = termenRambursare;
            EsteActiv = true;
        }

        // Method to check if the credit is active
        public bool VerificaCreditActiv()
        {
            return EsteActiv;
        }

        // Method to deactivate the credit
        public void DezactiveazaCredit()
        {
            EsteActiv = false;
        }

        // Method to activate the credit
        public void ActiveazaCredit()
        {
            EsteActiv = true;
        }

        // Method to update the loan amount
        public void ActualizeazaSumaImprumutata(float sumaNoua)
        {
            SumaImprumutata = sumaNoua;
        }

        // Method to calculate the total repayment amount
        public float CalculeazaSumaTotalaPlata()
        {
            // Simple calculation example: loan amount + interest
            return SumaImprumutata * (1 + Dobanda);
        }

        // Method to extend the repayment term
        public void ProlongeazaTermenRambursare(int perioadaPrelungire)
        {
            TermenRambursare += perioadaPrelungire;
        }
    }
}
