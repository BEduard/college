using System;

public class Clienti
{
    private static int idCounter = 0;
    public int Id { get; private set; }
    public string Nume { get; set; } 
    public bool StareCivila { get; set; }
    public string Adresa { get; set; }
    public string Telefon { get; set; }
    public float Venit { get; set; } // Venitul pe ultimele 3 luni

    public Clienti(string nume, bool stareCivila, string adresa, string telefon, float venit)
    {
        Id = ++idCounter;
        Nume = nume; // Modificare: de la 'name' la 'nume'
        StareCivila = stareCivila;
        Adresa = adresa;
        Telefon = telefon;
        Venit = venit;
    }


}
