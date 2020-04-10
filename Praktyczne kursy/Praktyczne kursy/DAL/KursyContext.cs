using Praktyczne_kursy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace Praktyczne_kursy.DAL
{
    public class KursyContext : DbContext 
    {
        public KursyContext() : base("KursyContext")
        {

        }

        public DbSet<Kurs> Kursy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamownienia> PozycjaZamownienia { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // using System.Data.Entity.ModelConfiguration.Conventions;
            // Włącza konwersję, która automatycznie tworzy liczbę mnogą dla nazw tabel w bazie danych
            // Zamiast Kategorie zostałoby stworzona tabela o nazwie Kategories
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

    }
}