using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace TuristickaAgencijaWebAPI.Database
{
    public partial class MyContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zaposlenici>().HasData(new TuristickaAgencijaWebAPI.Database.Zaposlenici()
            {
                ZaposlenikId = 1,
                Email = "alem.peco@edu.fit.ba",
                Ime = "Alem",
                Kontakt = "svakikon",
                KorisnickoIme = "alem",
                LozinkaHash = "Hkygp3aJFIgOMtbHckDaXN5HYBA=",
                LozinkaSalt = "DMUTs++b9XRsy8TQxXWtzw==",
                Prezime = "Peco"
            });
            modelBuilder.Entity<PutniciKorisnici>().HasData(new TuristickaAgencijaWebAPI.Database.PutniciKorisnici()
            {

                PutnikKorisnikId = 1,
                Email = "amila.peco@gmail.com",
                Ime = "Amila",
                Kontakt = "123 456 745",
                KorisnickoIme = "amila",
                LozinkaHash = "nX3I2MXaMLX9oQegdQ6Yz31sI9Q=",
                LozinkaSalt = "LD4329GODyCIepothCV5HQ==",
                Prezime = "Peco"
            });

            modelBuilder.Entity<Drzave>().HasData(
                new Drzave() { DrzaveId = 1, NazivDrzave = "Bosna i Hercegovina" },
                new Drzave() { DrzaveId = 2, NazivDrzave = "Hrvatska" },
                new Drzave() { DrzaveId = 3, NazivDrzave = "Švicarska" },
                new Drzave() { DrzaveId = 4, NazivDrzave = "Grcka" },
                new Drzave() { DrzaveId = 5, NazivDrzave = "Italija" },
                new Drzave() { DrzaveId = 6, NazivDrzave = "Spanija" },
                new Drzave() { DrzaveId = 7, NazivDrzave = "Portugal" },
                new Drzave() { DrzaveId = 8, NazivDrzave = "Francuska" });


            modelBuilder.Entity<Gradovi>().HasData(
            new Gradovi() { GradId = 1, NazivGrada = "Travnik", DrzaveId = 1 },
              new Gradovi() { GradId = 2, NazivGrada = "Sanski Most", DrzaveId = 1 },
              new Gradovi() { GradId = 3, NazivGrada = "Turbe", DrzaveId = 1 },
              new Gradovi() { GradId = 4, NazivGrada = "Sarajevo", DrzaveId = 1 },
              new Gradovi() { GradId = 5, NazivGrada = "Tuzla", DrzaveId = 1 },
              new Gradovi() { GradId = 6, NazivGrada = "Bihac", DrzaveId = 1 },
              new Gradovi() { GradId = 7, NazivGrada = "Instabul", DrzaveId = 1 },
              new Gradovi() { GradId = 8, NazivGrada = "Visoko", DrzaveId = 1 },
              new Gradovi() { GradId = 9, NazivGrada = "Makarska", DrzaveId = 2 },

              new Gradovi() { GradId = 10, NazivGrada = "Zürich", DrzaveId = 3 },
              new Gradovi() { GradId = 11, NazivGrada = "Zenica", DrzaveId = 1 },
              new Gradovi() { GradId = 12, NazivGrada = "Mostar", DrzaveId = 1 },
              new Gradovi() { GradId = 13, NazivGrada = "Jajce", DrzaveId = 1 },
              new Gradovi() { GradId = 14, NazivGrada = "Zakintos", DrzaveId = 4 },
              new Gradovi() { GradId = 15, NazivGrada = "Palermo", DrzaveId = 5 },
              new Gradovi() { GradId = 16, NazivGrada = "Tucepi", DrzaveId = 2 },
              new Gradovi() { GradId = 17, NazivGrada = "Tucepi", DrzaveId = 2 },
              new Gradovi() { GradId = 18, NazivGrada = "Barselona", DrzaveId = 6 },
              new Gradovi() { GradId = 19, NazivGrada = "Lisabon", DrzaveId = 7 },
              new Gradovi() { GradId = 20, NazivGrada = "Pariz", DrzaveId = 8 });




            modelBuilder.Entity<Firme>().HasData(
               new Firme() { FirmaId = 1, NazivFirme = "Travnik Trans" },
               new Firme() { FirmaId = 2, NazivFirme = "Autoprevoz Mostar" },
               new Firme() { FirmaId = 3, NazivFirme = "Globtour" },
               new Firme() { FirmaId = 4, NazivFirme = "Airlens" });

            //string datumkomentara5 = "24.02.2021";
            //string datumkomentara1 = "10.02.2021";
            //string datumkomentara2 = "11.02.2021";
            //string datumkomentara3 = "11.02.2021";
            //string datumkomentara4 = "15.02.2021";

            modelBuilder.Entity<Komentari>().HasData(



                 new Komentari() { KomentarId = 1, PutnikKorisnikId = 1, PutovanjeId = 9, Sadrzaj = "Odlicno", Vrijeme = DateTime.Now.AddDays(-10) },
             new Komentari() { KomentarId = 2, PutnikKorisnikId = 1, PutovanjeId = 9, Sadrzaj = "Top", Vrijeme = DateTime.Now.AddDays(-9) },
             new Komentari() { KomentarId = 3, PutnikKorisnikId = 1, PutovanjeId = 9, Sadrzaj = "Top", Vrijeme = DateTime.Now.AddDays(-9) },
             new Komentari() { KomentarId = 4, PutnikKorisnikId = 1, PutovanjeId = 9, Sadrzaj = "Super putovanje ..preporuka", Vrijeme = DateTime.Now.AddDays(-9) },
             new Komentari() { KomentarId = 5, PutnikKorisnikId = 1, PutovanjeId = 9, Sadrzaj = "Izgleda wooow", Vrijeme = DateTime.Now.AddDays(-7) });






            modelBuilder.Entity<Novosti>().HasData(
               new Novosti()
               {
                   NovostId = 1,
                   DatumVrijeme = DateTime.Now.AddDays(-10),
                   Naslov = "Vazna obavjest",
                   PutovanjeId = 2,
                   Sadrzaj = "Termin putovanja se pomjena sa 11h na 13h",
                   Slika = null,

                   ZaposlenikId = 1
               },
               new Novosti()
               {
                   NovostId = 2,
                   DatumVrijeme = DateTime.Now.AddDays(-5),
                   Naslov = "Vazna obavjest",
                   PutovanjeId = null,
                   Sadrzaj = "Sva putovavanja uslijed pogorsanja epidemioloske situacije se odgađaju do daljnjeg.",
                   Slika = null,
                   ZaposlenikId = 1
               },
               new Novosti()
               {
                   NovostId = 3,
                   DatumVrijeme = DateTime.Now.AddDays(-7),
                   Naslov = "Pomjera satnice za putnike u Barselonu",
                   PutovanjeId = 2,
                   Sadrzaj = "Pomjeranje putovanja satnice sa predviđenih 7:00h na 8:30h.",
                   Slika = null,
                   ZaposlenikId = 1
               },
               new Novosti()
               {
                   NovostId = 7,
                   DatumVrijeme = DateTime.Now.AddDays(-12),
                   Naslov = "Kako se obuci za putovanje",
                   PutovanjeId = null,
                   Sadrzaj = "Obuci se sto laganije za sva putovanja",
                   Slika = null,

                   ZaposlenikId = 1
               });





            modelBuilder.Entity<Ocjene>().HasData(
               new Ocjene() { OcjenaId = 2, Vrijednost = "Ocjena 1/5", VrijednostBrojcano = 1 },
               new Ocjene() { OcjenaId = 3, Vrijednost = "Ocjena 2/5", VrijednostBrojcano = 2 },
               new Ocjene() { OcjenaId = 4, Vrijednost = "Ocjena 3/5", VrijednostBrojcano = 3 },
               new Ocjene() { OcjenaId = 5, Vrijednost = "Ocjena 4/5", VrijednostBrojcano = 4 },
               new Ocjene() { OcjenaId = 6, Vrijednost = "Ocjena 5/5", VrijednostBrojcano = 5 });


            modelBuilder.Entity<OcjenePutovanja>().HasData(
               new OcjenePutovanja() { OcjenaPutovanjeId = 1, OcjenaId = 6, PutnikKorisnikId = 1, PutovanjeId = 2 },
               new OcjenePutovanja() { OcjenaPutovanjeId = 2, OcjenaId = 6, PutnikKorisnikId = 1, PutovanjeId = 9 },
               new OcjenePutovanja() { OcjenaPutovanjeId = 3, OcjenaId = 6, PutnikKorisnikId = 1, PutovanjeId = 9 },
               new OcjenePutovanja() { OcjenaPutovanjeId = 4, OcjenaId = 6, PutnikKorisnikId = 1, PutovanjeId = 9 },
               new OcjenePutovanja() { OcjenaPutovanjeId = 5, OcjenaId = 6, PutnikKorisnikId = 1, PutovanjeId = 9 });



            modelBuilder.Entity<OnlinePay>().HasData(
             new OnlinePay()
             {
                 OnlinePayId = 6,
                 KorisnickoIme = "amila",
                 Iznos = 55,
                 DatumUplate = DateTime.Now.AddDays(-6),
                 Svrha = "Instabul 16.02.2021"
             },
             new OnlinePay()
             {
                 OnlinePayId = 7,
                 KorisnickoIme = "amila",
                 PutniciKorisniciId = 0,
                 Iznos = 200,
                 DatumUplate = DateTime.Now.AddDays(-6),
                 Svrha = "BanjaLuka 17.2.2020"
             },
             new OnlinePay()
             {
                 OnlinePayId = 8,
                 KorisnickoIme = "amila",
                 PutniciKorisniciId = 0,
                 Iznos = 25,
                 DatumUplate = DateTime.Now.AddDays(+5),
                 Svrha = "BanjaLuka 10.02.2021"
             },
              new OnlinePay()
              {
                  OnlinePayId = 9,
                  KorisnickoIme = "amila",
                  PutniciKorisniciId = 0,
                  Iznos = 30,
                  DatumUplate = DateTime.Now.AddDays(+20),
                  Svrha = "BanjaLuka 10.02.2021"
              });

            modelBuilder.Entity<Pretplate>().HasData(
              new Pretplate() { PretplataId = 2, Aktivno = null, PutnikKorisnikId = 1, VrstaPutovanjaId = 5 },
              new Pretplate() { PretplataId = 4, Aktivno = null, PutnikKorisnikId = 1, VrstaPutovanjaId = 7 },
              new Pretplate() { PretplataId = 6, Aktivno = null, PutnikKorisnikId = 1, VrstaPutovanjaId = 4 },
              new Pretplate() { PretplataId = 7, Aktivno = null, PutnikKorisnikId = 1, VrstaPutovanjaId = 6 });


            modelBuilder.Entity<Prevoz>().HasData(
             new Prevoz() { PrevozId = 1, BrojMjesta = 10, CijenaPoMjestu = 10, FirmaId = 1, TipPrevozaId = 1 },
             new Prevoz() { PrevozId = 3, BrojMjesta = 50, CijenaPoMjestu = 11, FirmaId = 2, TipPrevozaId = 1 },
             new Prevoz() { PrevozId = 4, BrojMjesta = 49, CijenaPoMjestu = 10, FirmaId = 1, TipPrevozaId = 1 },
             new Prevoz() { PrevozId = 5, BrojMjesta = 120, CijenaPoMjestu = 60, FirmaId = 3, TipPrevozaId = 1 },
             new Prevoz() { PrevozId = 6, BrojMjesta = 50, CijenaPoMjestu = 50, FirmaId = 1, TipPrevozaId = 1 },
             new Prevoz() { PrevozId = 7, BrojMjesta = 10, CijenaPoMjestu = 10, FirmaId = 2, TipPrevozaId = 1 },
             new Prevoz() { PrevozId = 8, BrojMjesta = 10, CijenaPoMjestu = 10, FirmaId = 3, TipPrevozaId = 1 },
             new Prevoz() { PrevozId = 9, BrojMjesta = 49, CijenaPoMjestu = 6, FirmaId = 1, TipPrevozaId = 1 },
             new Prevoz() { PrevozId = 10, BrojMjesta = 130, CijenaPoMjestu = 150, FirmaId = 4, TipPrevozaId = 2 });




            modelBuilder.Entity<Putovanja>().HasData(
              new Putovanja()
              {
                  PutovanjaId = 1,
                  GradId = 1,
                  Naziv = "Banja Luka",
                  Opis = "Skolska ekskurzija u Banja Luku",
                  VrstaPutovanjaId = 7,
                  ZaposlenikId = 1,
                  PrevozId = 5,
                  Slika = null,

              },
               new Putovanja()
               {
                   PutovanjaId = 2,
                   GradId = 19,
                   Naziv = "Putovanje u Barselonu",
                   Opis = "Super ponuda ",
                   VrstaPutovanjaId = 4,
                   ZaposlenikId = 1,
                   PrevozId = 10,
                   Slika = null,

               },
               new Putovanja()
               {
                   PutovanjaId = 3,
                   GradId = 20,
                   Naziv = "Let do Pariza",
                   Opis = "Najnovije putovanje ",
                   VrstaPutovanjaId = 4,
                   ZaposlenikId = 1,
                   PrevozId = 10,
                   Slika = null,


               },
                new Putovanja()
                {
                    PutovanjaId = 4,
                    GradId = 1,
                    Naziv = "Obilazak grada Travnika",
                    Opis = "Tvrđava Stari grad jedan je od najljepših i najočuvanijih fortifikacijskih objekata srednjovjekovne Bosne u kojem su naredni istorijski periodi ostavili svoja specifična obilježja",


                    VrstaPutovanjaId = 7,
                    ZaposlenikId = 1,
                    PrevozId = 9,
                    Slika = null,




                },
                  new Putovanja()
                  {
                      PutovanjaId = 5,
                      GradId = 14,
                      Naziv = "Vrelo Bune",
                      Opis = "Najnovije putovanje ",
                      VrstaPutovanjaId = 7,
                      ZaposlenikId = 1,
                      PrevozId = 5,
                      Slika = null,




                  },
                   new Putovanja()
                   {
                       PutovanjaId = 6,
                       GradId = 9,
                       Naziv = "Putovanje do Instabula",
                       Opis = "Upoznajte Instabul ",
                       VrstaPutovanjaId = 4,
                       ZaposlenikId = 1,
                       PrevozId = 8,
                       Slika = null,




                   },
                      new Putovanja()
                      {
                          PutovanjaId = 7,
                          GradId = 9,
                          Naziv = "Cari Instabula",
                          Opis = "Upoznajte Instabul ",
                          VrstaPutovanjaId = 4,
                          ZaposlenikId = 1,
                          PrevozId = 8,
                          Slika = null,




                      },
                   new Putovanja()
                   {
                       PutovanjaId = 8,
                       GradId = 18,
                       Naziv = "Ljetovanje Tucepi",
                       Opis = "Ljepote Jadrana ",
                       VrstaPutovanjaId = 5,
                       ZaposlenikId = 1,
                       PrevozId = 3,
                       Slika = null,



                   },
                   new Putovanja()
                   {
                       PutovanjaId = 9,
                       GradId = 15,
                       Naziv = "Ljetovanje Grcka",
                       Opis = "Super ponuda ",
                       VrstaPutovanjaId = 6,
                       ZaposlenikId = 1,
                       PrevozId = 10,
                       Slika = null,



                   },
                   new Putovanja()
                   {
                       PutovanjaId = 10,
                       GradId = 19,
                       Naziv = "Putovanje u Portugal",
                       Opis = " Lisabonje poznat po svojoj kolonijalističkoj povijesti.",

                       VrstaPutovanjaId = 4,
                       ZaposlenikId = 1,
                       PrevozId = 5,
                       Slika = null,



                   },
                    new Putovanja()
                    {
                        PutovanjaId = 11,
                        GradId = 6,
                        Naziv = "Ekskurzija školska Jajce",
                        Opis = " Tražite istorijske spomenike? Ne samo da ih ima, već je ovo jedan od gradova sa najviše nacionalnih spomenika u BiH! Jajce ima čak 30 nacionalnih spomenika.",


                        VrstaPutovanjaId = 7,
                        ZaposlenikId = 1,
                        PrevozId = 4,
                        Slika = null,



                    },



                    new Putovanja()
                    {
                        PutovanjaId = 12,
                        GradId = 15,
                        Naziv = "Putovanje na Siciliju",
                        Opis = " Ne porpustite jedno od najljepsih putovanja iz nase ponude",

                        VrstaPutovanjaId = 6,
                        ZaposlenikId = 1,
                        PrevozId = 5,
                        Slika = null,



                    },
                    new Putovanja()
                    {
                        PutovanjaId = 13,
                        GradId = 4,
                        Naziv = "Ljetovanje Makarska",
                        Opis = " Makarska je priobalni grad u Splitsko-dalmatinskoj županiji, smješten podno planine Biokovo. Središte je Makarskog primorja (poznato pod imenom, Makarska .",

                        VrstaPutovanjaId = 5,
                        ZaposlenikId = 1,
                        PrevozId = 4,
                        Slika = null,



                    });
            //string datumrezervacije1 = "2021.02.03";
            //string datumrezervacije2 = "2021.02.10";
            //string datumrezervacije3 = "2021.02.11";
            //string datumrezervacije4 = "2021.02.24";




            modelBuilder.Entity<Rezervacije>().HasData(
             new Rezervacije() { RezervacijaId = 2, PutnikKorisnikId = 1, TerminPutovanjaId = 3, Vrijeme = DateTime.Now.AddDays(+4) },
             new Rezervacije() { RezervacijaId = 3, PutnikKorisnikId = 1, TerminPutovanjaId = 6, Vrijeme = DateTime.Now.AddDays(+4) },
             new Rezervacije() { RezervacijaId = 4, PutnikKorisnikId = 1, TerminPutovanjaId = 3, Vrijeme = DateTime.Now.AddDays(-15) },
             new Rezervacije() { RezervacijaId = 8, PutnikKorisnikId = 1, TerminPutovanjaId = 9, Vrijeme = DateTime.Now.AddDays(-9) },
             new Rezervacije() { RezervacijaId = 9, PutnikKorisnikId = 1, TerminPutovanjaId = 10, Vrijeme = DateTime.Now.AddDays(-9) },
             new Rezervacije() { RezervacijaId = 10, PutnikKorisnikId = 1, TerminPutovanjaId = 11, Vrijeme = DateTime.Now.AddDays(-9) },
             new Rezervacije() { RezervacijaId = 11, PutnikKorisnikId = 1, TerminPutovanjaId = 10, Vrijeme = DateTime.Now.AddDays(-1) });


            modelBuilder.Entity<Smjestaj>().HasData(
              new Smjestaj()
              {
                  SmjestajId = 2,
                  GradId = 4,
                  Naziv = "Hotel Nacional",
                  Opis = "Hotel 3 zvjezdice",
                  CijenaNoc = 100,
                  TipSobe = "jednokrevetne",
                  Slika = null,

              },
              new Smjestaj()
              {



                  SmjestajId = 11,
                  GradId = 1,
                  Naziv = "Hotel Vezir Palace",
                  Opis = "Hotel 3 zvjezdice",
                  CijenaNoc = 100,
                  TipSobe = "dvokrevetna ",
                  Slika = null,

              },
              new Smjestaj()
              {



                  SmjestajId = 12,
                  GradId = 9,
                  Naziv = "Cheers Lighthouse",
                  Opis = "Hotel 3 zvjezdice",
                  CijenaNoc = 40,
                  TipSobe = "Tip ",
                  Slika = null,

              },
              new Smjestaj()
              {



                  SmjestajId = 13,
                  GradId = 19,
                  Naziv = "Hotel Rossio Garden Hotel ",
                  Opis = "Hotel 4 zvjezdice",
                  CijenaNoc = 100,
                  TipSobe = "Svi Tip ",
                  Slika = null,

              },
               new Smjestaj()
               {



                   SmjestajId = 14,
                   GradId = 16,
                   Naziv = "Phoenix Hotel  ",
                   Opis = "Hotel 5 zvjezdice",
                   CijenaNoc = 30,
                   TipSobe = "Svi Tip ",
                   Slika = null,

               },
                new Smjestaj()
                {



                    SmjestajId = 15,
                    GradId = 18,
                    Naziv = "Hotel Tamaris Tucepi  ",
                    Opis = "Hotel 3 zvjezdice",
                    CijenaNoc = 60,
                    TipSobe = "Svi Tip ",
                    Slika = null,

                },
                 new Smjestaj()
                 {



                     SmjestajId = 16,
                     GradId = 17,
                     Naziv = "Hotel Astoria Palace Hotel   ",
                     Opis = "Hotel 4 zvjezdice",
                     CijenaNoc = 50,
                     TipSobe = "Svi Tip ",
                     Slika = null,

                 });


            modelBuilder.Entity<TerminiPutovanja>().HasData(
             new TerminiPutovanja()
             {
                 TerminPutovanjaId = 1,
                 Aktivno = true,
                 BrojMjesta = 40,
                 Cijena = 10,
                 DatumPolaska = DateTime.Now.AddDays(-20),
                 DatumPovratka = DateTime.Now.AddDays(-18),
                 PutovanjeId = 1,
                 SmjestajId = 2,
                 VodicId = 2,
                 Slika = null,

             },
              new TerminiPutovanja()
              {
                  TerminPutovanjaId = 2,
                  Aktivno = true,
                  BrojMjesta = 30,
                  Cijena = 150,
                  DatumPolaska = DateTime.Now.AddDays(-20),
                  DatumPovratka = DateTime.Now.AddDays(-18),
                  PutovanjeId = 3,
                  SmjestajId = 2,
                  VodicId = 2,
                  Slika = null,

              },

              new TerminiPutovanja()
              {
                  TerminPutovanjaId = 3,
                  Aktivno = true,
                  BrojMjesta = 40,
                  Cijena = 50,
                  DatumPolaska = DateTime.Now.AddDays(-15),
                  DatumPovratka = DateTime.Now.AddDays(-14),
                  PutovanjeId = 1,
                  SmjestajId = 11,
                  VodicId = 3,
                  Slika = null,

              },
               new TerminiPutovanja()
               {
                   TerminPutovanjaId = 4,
                   Aktivno = true,
                   BrojMjesta = 12,
                   Cijena = 44,
                   DatumPolaska = DateTime.Now.AddDays(-12),
                   DatumPovratka = DateTime.Now.AddDays(-17),
                   PutovanjeId = 5,
                   SmjestajId = 2,
                   VodicId = 3,
                   Slika = null,

               },
                new TerminiPutovanja()
                {
                    TerminPutovanjaId = 5,
                    Aktivno = true,
                    BrojMjesta = 50,
                    Cijena = 130,
                    DatumPolaska = DateTime.Now.AddDays(-21),
                    DatumPovratka = DateTime.Now.AddDays(-17),
                    PutovanjeId = 2,
                    SmjestajId = 2,
                    VodicId = 3,
                    Slika = null,

                },
                 new TerminiPutovanja()
                 {
                     TerminPutovanjaId = 6,
                     Aktivno = true,
                     BrojMjesta = 50,
                     Cijena = 130,
                     DatumPolaska = DateTime.Now.AddDays(-21),
                     DatumPovratka = DateTime.Now.AddDays(-17),
                     PutovanjeId = 7,
                     SmjestajId = 11,
                     VodicId = 3,
                     Slika = null,

                 },
                   new TerminiPutovanja()
                   {
                       TerminPutovanjaId = 7,
                       Aktivno = true,
                       BrojMjesta = 40,
                       Cijena = 25,
                       DatumPolaska = DateTime.Now.AddDays(-15),
                       DatumPovratka = DateTime.Now.AddDays(-11),
                       PutovanjeId = 1,
                       SmjestajId = 2,
                       VodicId = 1,
                       Slika = null,

                   },
                   new TerminiPutovanja()
                   {
                       TerminPutovanjaId = 8,
                       Aktivno = true,
                       BrojMjesta = 40,
                       Cijena = 25,
                       DatumPolaska = DateTime.Now.AddDays(-15),
                       DatumPovratka = DateTime.Now.AddDays(-11),
                       PutovanjeId = 1,

                       SmjestajId = 2,
                       VodicId = 1,
                       Slika =null,

                   },
                    new TerminiPutovanja()
                    {
                        TerminPutovanjaId = 9,
                        Aktivno = true,
                        BrojMjesta = 55,
                        Cijena = 250,
                        DatumPolaska = DateTime.Now.AddDays(-9),
                        DatumPovratka = DateTime.Now.AddDays(+1),
                        PutovanjeId = 2,
                        SmjestajId = 2,
                        VodicId = 2,
                        Slika = null,

                    },
                    new TerminiPutovanja()
                    {
                        TerminPutovanjaId = 10,
                        Aktivno = true,
                        BrojMjesta = 50,
                        Cijena = 330,
                        DatumPolaska = DateTime.Now.AddDays(+20),
                        DatumPovratka = DateTime.Now.AddDays(+25),
                        PutovanjeId = 9,
                        SmjestajId = 14,
                        VodicId = 3,
                        Slika = null,

                    },
                     new TerminiPutovanja()
                     {
                         TerminPutovanjaId = 11,
                         Aktivno = true,
                         BrojMjesta = 50,
                         Cijena = 120,
                         DatumPolaska = DateTime.Now.AddDays(+40),
                         DatumPovratka = DateTime.Now.AddDays(+45),
                         PutovanjeId = 8,
                         SmjestajId = 15,
                         VodicId = 4,
                         Slika = null,

                     },
                      new TerminiPutovanja()
                      {
                          TerminPutovanjaId = 12,
                          Aktivno = true,
                          BrojMjesta = 50,
                          Cijena = 200,
                          DatumPolaska = DateTime.Now.AddDays(+15),
                          DatumPovratka = DateTime.Now.AddDays(+23),
                          PutovanjeId = 10,
                          SmjestajId = 13,
                          VodicId = 1,
                          Slika = null,

                      },
                       new TerminiPutovanja()
                       {
                           TerminPutovanjaId = 13,
                           Aktivno = true,
                           BrojMjesta = 50,
                           Cijena = 45,
                           DatumPolaska = DateTime.Now.AddDays(+-10),
                           DatumPovratka = DateTime.Now.AddDays(+1),
                           PutovanjeId = 11,
                           SmjestajId = 2,
                           VodicId = 2,
                           Slika = null,

                       },
                       new TerminiPutovanja()
                       {
                           TerminPutovanjaId = 14,
                           Aktivno = true,
                           BrojMjesta = 44,
                           Cijena = 67,
                           DatumPolaska = DateTime.Now.AddDays(+25),
                           DatumPovratka = DateTime.Now.AddDays(+29),
                           PutovanjeId = 12,
                           SmjestajId = 2,
                           VodicId = 3,
                           Slika = null,

                       },

                         new TerminiPutovanja()
                         {
                             TerminPutovanjaId = 15,
                             Aktivno = true,
                             BrojMjesta = 55,
                             Cijena = 120,
                             DatumPolaska = DateTime.Now.AddDays(+2),
                             DatumPovratka = DateTime.Now.AddDays(+9),
                             PutovanjeId = 13,
                             SmjestajId = 15,
                             VodicId = 3,
                             Slika = null,

                         },
                         new TerminiPutovanja()
                         {
                             TerminPutovanjaId = 1016,
                             Aktivno = true,
                             BrojMjesta = 33,
                             Cijena = 40,
                             DatumPolaska = DateTime.Now.AddDays(-8),
                             DatumPovratka = DateTime.Now.AddDays(+2),
                             PutovanjeId = 1,
                             SmjestajId = 2,
                             VodicId = 2,
                             Slika = null,

                         },
                         new TerminiPutovanja()
                         {
                             TerminPutovanjaId = 1017,
                             Aktivno = true,
                             BrojMjesta = 33,
                             Cijena = 40,
                             DatumPolaska = DateTime.Now.AddDays(-7),
                             DatumPovratka = DateTime.Now.AddDays(+2),
                             PutovanjeId = 1,
                             SmjestajId = 2,
                             VodicId = 2,
                             Slika = null,

                         },
                         new TerminiPutovanja()
                         {
                             TerminPutovanjaId = 1018,
                             Aktivno = true,
                             BrojMjesta = 4,
                             Cijena = 4,
                             DatumPolaska = DateTime.Now.AddDays(-8),
                             DatumPovratka = DateTime.Now.AddDays(-7),
                             PutovanjeId = 1,
                             SmjestajId = 2,
                             VodicId = 3,
                             Slika = null,

                         },

                         new TerminiPutovanja()
                         {
                             TerminPutovanjaId = 1023,
                             Aktivno = true,
                             BrojMjesta = 44,
                             Cijena = 5555,
                             DatumPolaska = DateTime.Now.AddDays(-6),
                             DatumPovratka = DateTime.Now.AddDays(+4),
                             PutovanjeId = 1,
                             SmjestajId = 2,
                             VodicId = 2,
                             Slika = null,

                         },
                         new TerminiPutovanja()
                         {
                             TerminPutovanjaId = 1025,
                             Aktivno = true,
                             BrojMjesta = 55,
                             Cijena = 250,
                             DatumPolaska = DateTime.Now.AddDays(+25),
                             DatumPovratka = DateTime.Now.AddDays(+32),
                             PutovanjeId = 6,
                             SmjestajId = 12,
                             VodicId = 5,
                             Slika = null,

                         });


            modelBuilder.Entity<TipPrevoza>().HasData(
             new TipPrevoza() { TipPrevozaId = 1, NazivTipa = "Autobus" },
             new TipPrevoza() { TipPrevozaId = 2, NazivTipa = "Avion" },
             new TipPrevoza() { TipPrevozaId = 3, NazivTipa = "Brod" });

            modelBuilder.Entity<Uplate>().HasData(
           new Uplate() { UplataId = 1, DatumUplate = DateTime.Now.AddDays(-15), Iznos = 45, RezervacijaId = 2 },
           new Uplate() { UplataId = 2, DatumUplate = DateTime.Now.AddDays(-12), Iznos = 250, RezervacijaId = 3 },
           new Uplate() { UplataId = 4, DatumUplate = DateTime.Now.AddDays(-13), Iznos = 10, RezervacijaId = 4 },
           new Uplate() { UplataId = 5, DatumUplate = DateTime.Now.AddDays(-14), Iznos = 10, RezervacijaId = 4 },
           new Uplate() { UplataId = 6, DatumUplate = DateTime.Now.AddDays(-10), Iznos = 25, RezervacijaId = 4 },
           new Uplate() { UplataId = 7, DatumUplate = DateTime.Now.AddDays(-5), Iznos = 25, RezervacijaId = 4 },
           new Uplate() { UplataId = 8, DatumUplate = DateTime.Now.AddDays(-15), Iznos = 25, RezervacijaId = 4 },
           new Uplate() { UplataId = 9, DatumUplate = DateTime.Now.AddDays(-5), Iznos = 25, RezervacijaId = 4 },
           new Uplate() { UplataId = 10, DatumUplate = DateTime.Now.AddDays(-4), Iznos = 4, RezervacijaId = 4 },
           new Uplate() { UplataId = 11, DatumUplate = DateTime.Now.AddDays(-3), Iznos = 44, RezervacijaId = 4 },
           new Uplate() { UplataId = 15, DatumUplate = DateTime.Now.AddDays(-2), Iznos = 40, RezervacijaId = 8 },
           new Uplate() { UplataId = 16, DatumUplate = DateTime.Now.AddDays(-1), Iznos = 30, RezervacijaId = 4 });





            modelBuilder.Entity<Vodici>().HasData(
             new Vodici()
             {
                 VodicId = 1,
                 Ime = "Amila",
                 Prezime = "Peco",
                 Jmbg = "1231231232321",
                 Kontakt = "+062 71 485 300",
                 Zauzet = true,
                 Slika = null,

             },
              new Vodici()
              {
                  VodicId = 2,
                  Ime = "Jasmin",
                  Prezime = "Azemovic",
                  Jmbg = "4324322423423",
                  Kontakt = "+123 45 678 910",
                  Zauzet = false,
                  Slika = null,

              },
              new Vodici()
              {
                  VodicId = 3,
                  Ime = "Elmir",
                  Prezime = "Babovic",
                  Jmbg = "4324322423423",
                  Kontakt = "+123 45 678 3",
                  Zauzet = false,
                  Slika = null,

              },
               new Vodici()
               {
                   VodicId = 4,
                   Ime = "Emina",
                   Prezime = "Junuz",
                   Jmbg = "4324322423423",
                   Kontakt = "+123 45 678 3",
                   Zauzet = false,
                   Slika = null,

               },
                new Vodici()
                {
                    VodicId = 5,
                    Ime = "Amila2",
                    Prezime = "Peco",
                    Jmbg = "4324322423423",
                    Kontakt = "+123 45 678 3",
                    Zauzet = false,
                    Slika = null,

                });

            modelBuilder.Entity<VrstePutovanja>().HasData(
             new VrstePutovanja()
             { VrstaPutovanjaId = 4, Oznaka = "Evropsko", Vrijednost = 1, },
             new VrstePutovanja() { VrstaPutovanjaId = 5, Oznaka = "Jadran", Vrijednost = 2 },
             new VrstePutovanja() { VrstaPutovanjaId = 6, Oznaka = "Mediteran", Vrijednost = 3 },
             new VrstePutovanja() { VrstaPutovanjaId = 7, Oznaka = "Školsko", Vrijednost = 4 });




















































        }
    }
}
