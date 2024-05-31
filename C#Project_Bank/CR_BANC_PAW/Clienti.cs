using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CR_BANC_PAW
{
    [Serializable]
    public class Clienti
    {
        public static int idCounter = 0;
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Email { get; set; }
        public bool StareCivila { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public float Venit { get; set; } // Venitul pe ultimele 3 luni
        public List<Credite> ListaCredite { get; set; }

        public Clienti(string nume, string mail, bool stareCivila, string adresa, string telefon, float venit)
        {
            ID = ++idCounter;
            Nume = nume;
            Email = mail;
            StareCivila = stareCivila;
            Adresa = adresa;
            Telefon = telefon;
            Venit = venit;
            ListaCredite = new List<Credite>();
        }

        public Clienti()
        {
            ID = ++idCounter;
        }

        // Adăugarea unui credit în lista de credite a clientului
        public void AdaugaCredit(Credite credit)
        {
            ListaCredite.Add(credit);
        }

        // Metoda pentru a verifica dacă clientul are credite active
        public bool AreCrediteActive()
        {
            foreach (var credit in ListaCredite)
            {
                if (credit.EsteActiv)
                {
                    return true;
                }
            }
            return false;
        }

        // Metoda pentru a calcula suma totală a creditelor clientului
        public float CalculeazaSumaTotalaCredite()
        {
            float sumaTotala = 0;
            foreach (var credit in ListaCredite)
            {
                sumaTotala += credit.SumaImprumutata;
            }
            return sumaTotala;
        }

        // Metoda pentru a șterge un credit din lista de credite a clientului
        public void StergeCredit(Credite credit)
        {
            ListaCredite.Remove(credit);
        }

        // Metoda pentru a afișa detalii despre client (nume, ID, adresa, etc.)
        public void AfiseazaDetalii()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nume: {Nume}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Adresa: {Adresa}");
            Console.WriteLine($"Telefon: {Telefon}");
            Console.WriteLine($"Venit: {Venit}");
            Console.WriteLine($"Număr de credite: {ListaCredite.Count}");
        }


    }
}
