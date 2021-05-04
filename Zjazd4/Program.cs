// Przygotuj niewielką strukturę danych w .NET Core. Stwórz klasę abstrakcyjną Osoba z polami Id, Imię i Nazwisko. Następnie stwórz dwie klasy dziedziczące z Osoby - Klient i Pracownik. Pracownik powinien mieć DatęZatrudnienia i (null'owalną) DatęZwolnienia. Klient powinien posiadać pola NrTelefonu i NrRejestracyjny (pojazdu). Przygotuj dwa konteksty - z zastosowaniem TPH i z zastosowaniem TPT. Dodaj do obu kontekstów kilka osób. Polecam również rzucić okiem jak EF zapisuje dane w bazie.


using System;
using Microsoft.EntityFrameworkCore;

namespace Zjazd4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Database.EnsureCreated();
            
            tph.Osoby.Add(new Klient()
                {Imie = "Joahim", Nazwisko = "Petarda", NrRejestracyjny = "SWD24978", NrTelefonu = "796796796"});
            tph.Osoby.Add(new Pracownik() {Imie = "Czarus", Nazwisko = "Lasowski", DatęZatrudnienia = DateTime.Now});
            tph.SaveChanges();


            var tpt = new TPTContext();
            tpt.Database.EnsureCreated();
            
            tpt.Osoby.Add(new Klient()
                {Imie = "Joahim", Nazwisko = "Petarda", NrRejestracyjny = "SWD24978", NrTelefonu = "796796796"});
            tpt.Osoby.Add(new Pracownik() {Imie = "Czarus", Nazwisko = "Lasowski", DatęZatrudnienia = DateTime.Now});
            tpt.SaveChanges();
        }
    }
}