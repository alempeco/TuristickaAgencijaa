using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencijaWebAPI.Database;

namespace TuristickaAgencijaWebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Gradovi, GradoviInsertRequest>().ReverseMap();
            CreateMap<Gradovi, TuristickaAgencija.Model.Gradovi>().ReverseMap();

            CreateMap<Firme, FirmeInsertRequest>().ReverseMap();
            CreateMap<Firme, TuristickaAgencija.Model.Firme>().ReverseMap();

            CreateMap<Drzave, DrzaveInsertRequest>().ReverseMap();
            CreateMap<Drzave, TuristickaAgencija.Model.Drzave>().ReverseMap();
            CreateMap<TipPrevoza, TipPrevozaInsertRequest>().ReverseMap();
            CreateMap<TipPrevoza, TuristickaAgencija.Model.TipPrevoza>().ReverseMap();


            CreateMap<Smjestaj, TuristickaAgencija.Model.Smjestaj>().ReverseMap();
            CreateMap<Smjestaj, TuristickaAgencija.Model.Requests.SmjestajInsertRequest>().ReverseMap();
            CreateMap<Smjestaj, TuristickaAgencija.Model.Smjestaj>().ReverseMap();


            CreateMap<Prevoz, TuristickaAgencija.Model.Prevoz>().ReverseMap();
            CreateMap<Prevoz, TuristickaAgencija.Model.Requests.PrevozInsertRequest>().ReverseMap();
            CreateMap<Prevoz, TuristickaAgencija.Model.Prevoz>().ReverseMap();


            CreateMap<Vodici, TuristickaAgencija.Model.Requests.VodicInsertRequest>().ReverseMap();
            CreateMap<Vodici, TuristickaAgencija.Model.Vodici>().ReverseMap();



            CreateMap<VrstePutovanja, TuristickaAgencija.Model.VrstaPutovanja>().ReverseMap();
            CreateMap<VrstePutovanja, VrstaPutovanjaInsertRequest>().ReverseMap();



            CreateMap<Ocjene, TuristickaAgencija.Model.Ocjene>().ReverseMap();
            CreateMap<Ocjene, OcjeneInsertRequest>().ReverseMap();


            CreateMap<Zaposlenici, TuristickaAgencija.Model.Zaposlenici>().ReverseMap();
            CreateMap<Zaposlenici, ZaposleniciInsertRequest>().ReverseMap();

            CreateMap<PutniciKorisnici, PutniciKorisniciInsertRequest>().ReverseMap();
            CreateMap<PutniciKorisnici, TuristickaAgencija.Model.PutniciKorisnici>().ReverseMap();


            CreateMap<Database.Zaposlenici, TuristickaAgencija.Model.KorisnikLogin>().ReverseMap();
            CreateMap<Database.PutniciKorisnici, TuristickaAgencija.Model.KorisnikLogin>().ReverseMap();



            CreateMap<Putovanja, PutovanjaInsertRequest>().ReverseMap();
            CreateMap<Putovanja, TuristickaAgencija.Model.Putovanja>().ReverseMap();
            CreateMap<Putovanja, TuristickaAgencija.Model.Putovanja>().ReverseMap();



            CreateMap<TerminiPutovanja, TerminiPutovanjaInsertRequest>().ReverseMap();
            CreateMap<TerminiPutovanja, TuristickaAgencija.Model.TerminiPutovanja>().ReverseMap();
            CreateMap<TerminiPutovanja, TuristickaAgencija.Model.TerminiPutovanja>().ReverseMap();


            CreateMap<TerminiPutovanja, TerminiPutovanjaInsertRequest>().ReverseMap();
            CreateMap<TerminiPutovanja, TuristickaAgencija.Model.TerminiPutovanja>().ReverseMap();
            CreateMap<TerminiPutovanja, TuristickaAgencija.Model.TerminiPutovanja>().ReverseMap();




            CreateMap<Novosti, TuristickaAgencija.Model.Novosti>().ReverseMap();
            CreateMap<Novosti, NovostiInsertRequest>().ReverseMap();
            CreateMap<Novosti, TuristickaAgencija.Model.Novosti>()
            .ReverseMap();

            CreateMap<Rezervacije, TuristickaAgencija.Model.Rezervacije>().ReverseMap();
            CreateMap<Rezervacije, RezervacijeInsertRequest>().ReverseMap();
            CreateMap<Rezervacije, TuristickaAgencija.Model.Rezervacije>().ReverseMap();




            CreateMap<Uplate, UplateInsertRequest>().ReverseMap();
            CreateMap<Uplate, TuristickaAgencija.Model.Uplate>().ReverseMap();
            CreateMap<Uplate, TuristickaAgencija.Model.Uplate>().ReverseMap();




            CreateMap<Pretplate, TuristickaAgencija.Model.Pretplate>().ReverseMap();
            CreateMap<Pretplate, PretplateInsertRequest>().ReverseMap();
            CreateMap<Pretplate, TuristickaAgencija.Model.Pretplate>().ReverseMap();






            CreateMap<Komentari, KomentariInsertRequest>().ReverseMap();
            CreateMap<Komentari, TuristickaAgencija.Model.Komentari>().ReverseMap();
            CreateMap<Komentari, TuristickaAgencija.Model.Komentari>().ReverseMap();


            CreateMap<OcjenePutovanja, OcjenePutovanjaInsertRequest>().ReverseMap();
            CreateMap<OcjenePutovanja, TuristickaAgencija.Model.OcjenePutovanja>().ReverseMap();
            CreateMap<OcjenePutovanja, TuristickaAgencija.Model.OcjenePutovanja>().ReverseMap();









            //CreateMap<OnlinePay, OnlinePayInsertRequest>().ReverseMap();
            //CreateMap<OnlinePay, TuristickaAgencija.Model.OnlinePay>().ReverseMap();
            //CreateMap<OnlinePay, TuristickaAgencija.Model.OnlinePay>().
            //ForMember(x => x.PutniciKorisniciId,
            //a => a.MapFrom(y => new MyContext().PutniciKorisnici.
            //Where(x => x.PutnikKorisnikId == y.PutniciKorisniciId);





            CreateMap<OnlinePay, TuristickaAgencija.Model.OnlinePay>().ReverseMap();
            CreateMap<OnlinePay, TuristickaAgencija.Model.Requests.OnlinePayInsertRequest>().ReverseMap();
            CreateMap<OnlinePay, TuristickaAgencija.Model.OnlinePay>().ReverseMap();





        }


    }
}
