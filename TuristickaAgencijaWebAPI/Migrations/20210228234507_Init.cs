using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuristickaAgencijaWebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzaveID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivDrzave = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzaveID);
                });

            migrationBuilder.CreateTable(
                name: "Firme",
                columns: table => new
                {
                    FirmaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivFirme = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firme", x => x.FirmaID);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vrijednost = table.Column<string>(maxLength: 10, nullable: true),
                    VrijednostBrojcano = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjenaID);
                });

            migrationBuilder.CreateTable(
                name: "OnlinePay",
                columns: table => new
                {
                    OnlinePayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnickoIme = table.Column<string>(nullable: false),
                    Iznos = table.Column<float>(nullable: false),
                    PutniciKorisniciID = table.Column<int>(nullable: false),
                    DatumUplate = table.Column<DateTime>(nullable: false),
                    Svrha = table.Column<string>(maxLength: 350, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlinePay", x => x.OnlinePayID);
                });

            migrationBuilder.CreateTable(
                name: "PutniciKorisnici",
                columns: table => new
                {
                    PutnikKorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Ime = table.Column<string>(maxLength: 30, nullable: false),
                    Kontakt = table.Column<string>(maxLength: 50, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PutniciKorisnici", x => x.PutnikKorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "TipPrevoza",
                columns: table => new
                {
                    TipPrevozaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivTipa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipPrevoza", x => x.TipPrevozaID);
                });

            migrationBuilder.CreateTable(
                name: "Vodici",
                columns: table => new
                {
                    VodicID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    JMBG = table.Column<string>(nullable: true),
                    Kontakt = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Zauzet = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vodici", x => x.VodicID);
                });

            migrationBuilder.CreateTable(
                name: "VrstePutovanja",
                columns: table => new
                {
                    VrstaPutovanjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Oznaka = table.Column<string>(maxLength: 10, nullable: true),
                    Vrijednost = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstePutovanja", x => x.VrstaPutovanjaID);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenici",
                columns: table => new
                {
                    ZaposlenikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 20, nullable: false),
                    Ime = table.Column<string>(maxLength: 20, nullable: false),
                    Kontakt = table.Column<string>(maxLength: 50, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenici", x => x.ZaposlenikID);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivGrada = table.Column<string>(nullable: false),
                    DrzaveID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave",
                        column: x => x.DrzaveID,
                        principalTable: "Drzave",
                        principalColumn: "DrzaveID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prevoz",
                columns: table => new
                {
                    PrevozID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojMjesta = table.Column<int>(nullable: false),
                    CijenaPoMjestu = table.Column<float>(nullable: false),
                    FirmaID = table.Column<int>(nullable: true),
                    TipPrevozaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prevoz", x => x.PrevozID);
                    table.ForeignKey(
                        name: "FK_Prevoz_Firma",
                        column: x => x.FirmaID,
                        principalTable: "Firme",
                        principalColumn: "FirmaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prevoz_TipPrevoza",
                        column: x => x.TipPrevozaID,
                        principalTable: "TipPrevoza",
                        principalColumn: "TipPrevozaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pretplate",
                columns: table => new
                {
                    PretplataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Aktivno = table.Column<bool>(nullable: true),
                    PutnikKorisnikId = table.Column<int>(nullable: true),
                    VrstaPutovanjaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pretplate", x => x.PretplataId);
                    table.ForeignKey(
                        name: "FK_Pretplate_PutniciKorisnici",
                        column: x => x.PutnikKorisnikId,
                        principalTable: "PutniciKorisnici",
                        principalColumn: "PutnikKorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pretplate_VrstePutovanja",
                        column: x => x.VrstaPutovanjaId,
                        principalTable: "VrstePutovanja",
                        principalColumn: "VrstaPutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Smjestaj",
                columns: table => new
                {
                    SmjestajID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CijenaNoc = table.Column<double>(nullable: true),
                    GradID = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(unicode: false, nullable: true),
                    TipSobe = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smjestaj", x => x.SmjestajID);
                    table.ForeignKey(
                        name: "FK_Smjestaj_Gradovi",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Putovanja",
                columns: table => new
                {
                    PutovanjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GradID = table.Column<int>(nullable: true),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    VrstaPutovanjaID = table.Column<int>(nullable: true),
                    ZaposlenikID = table.Column<int>(nullable: true),
                    PrevozID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Putovanja", x => x.PutovanjaID);
                    table.ForeignKey(
                        name: "FK_Putovanja_Gradovi",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Putovanja_",
                        column: x => x.PrevozID,
                        principalTable: "Prevoz",
                        principalColumn: "PrevozID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Putovanja_VrstePutovanja",
                        column: x => x.VrstaPutovanjaID,
                        principalTable: "VrstePutovanja",
                        principalColumn: "VrstaPutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Putovanja_Zaposlenici",
                        column: x => x.ZaposlenikID,
                        principalTable: "Zaposlenici",
                        principalColumn: "ZaposlenikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentari",
                columns: table => new
                {
                    KomentarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PutnikKorisnikID = table.Column<int>(nullable: true),
                    PutovanjeID = table.Column<int>(nullable: true),
                    Sadrzaj = table.Column<string>(maxLength: 250, nullable: true),
                    Vrijeme = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentari", x => x.KomentarID);
                    table.ForeignKey(
                        name: "FK_Komentari_PutniciKorisnici",
                        column: x => x.PutnikKorisnikID,
                        principalTable: "PutniciKorisnici",
                        principalColumn: "PutnikKorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Komentari_Putovanja",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novosti",
                columns: table => new
                {
                    NovostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naslov = table.Column<string>(maxLength: 50, nullable: false),
                    PutovanjeID = table.Column<int>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    ZaposlenikID = table.Column<int>(nullable: true),
                    DatumVrijeme = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novosti", x => x.NovostID);
                    table.ForeignKey(
                        name: "FK_Novosti_Putovanja",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Novosti_Zaposlenici",
                        column: x => x.ZaposlenikID,
                        principalTable: "Zaposlenici",
                        principalColumn: "ZaposlenikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OcjenePutovanja",
                columns: table => new
                {
                    OcjenaPutovanjeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OcjenaID = table.Column<int>(nullable: true),
                    PutnikKorisnikID = table.Column<int>(nullable: true),
                    PutovanjeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcjenePutovanja", x => x.OcjenaPutovanjeID);
                    table.ForeignKey(
                        name: "FK_OcjenePutovanja_Ocjene",
                        column: x => x.OcjenaID,
                        principalTable: "Ocjene",
                        principalColumn: "OcjenaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OcjenePutovanja_PutniciKorisnici",
                        column: x => x.PutnikKorisnikID,
                        principalTable: "PutniciKorisnici",
                        principalColumn: "PutnikKorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OcjenePutovanja_Putovanja",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TerminiPutovanja",
                columns: table => new
                {
                    TerminPutovanjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Aktivno = table.Column<bool>(nullable: true),
                    BrojMjesta = table.Column<int>(nullable: true),
                    Cijena = table.Column<double>(nullable: true),
                    PutovanjeID = table.Column<int>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    SmjestajID = table.Column<int>(nullable: true),
                    VodicID = table.Column<int>(nullable: true),
                    DatumPolaska = table.Column<DateTime>(nullable: true),
                    DatumPovratka = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminiPutovanja", x => x.TerminPutovanjaID);
                    table.ForeignKey(
                        name: "FK_TerminiPutovanja_Putovanja",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TerminiPutovanja_Smjestaj",
                        column: x => x.SmjestajID,
                        principalTable: "Smjestaj",
                        principalColumn: "SmjestajID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TerminiPutovanja_Vodici",
                        column: x => x.VodicID,
                        principalTable: "Vodici",
                        principalColumn: "VodicID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PutnikKorisnikID = table.Column<int>(nullable: false),
                    TerminPutovanjaID = table.Column<int>(nullable: false),
                    Vrijeme = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "FK_PutniciKorisniciPutovanja_PutniciKorisnici_PutnikKorisnikID",
                        column: x => x.PutnikKorisnikID,
                        principalTable: "PutniciKorisnici",
                        principalColumn: "PutnikKorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacije_TerminiPutovanja",
                        column: x => x.TerminPutovanjaID,
                        principalTable: "TerminiPutovanja",
                        principalColumn: "TerminPutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uplate",
                columns: table => new
                {
                    UplataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumUplate = table.Column<DateTime>(nullable: false),
                    Iznos = table.Column<float>(nullable: false),
                    RezervacijaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplate", x => x.UplataID);
                    table.ForeignKey(
                        name: "FK_Uplate_Rezervacije",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Drzave",
                columns: new[] { "DrzaveID", "NazivDrzave" },
                values: new object[,]
                {
                    { 1, "Bosna i Hercegovina" },
                    { 2, "Hrvatska" },
                    { 3, "Švicarska" },
                    { 4, "Grcka" },
                    { 5, "Italija" },
                    { 6, "Spanija" },
                    { 7, "Portugal" },
                    { 8, "Francuska" }
                });

            migrationBuilder.InsertData(
                table: "Firme",
                columns: new[] { "FirmaID", "NazivFirme" },
                values: new object[,]
                {
                    { 4, "Airlens" },
                    { 3, "Globtour" },
                    { 2, "Autoprevoz Mostar" },
                    { 1, "Travnik Trans" }
                });

            migrationBuilder.InsertData(
                table: "Ocjene",
                columns: new[] { "OcjenaID", "Vrijednost", "VrijednostBrojcano" },
                values: new object[,]
                {
                    { 2, "Ocjena 1/5", 1 },
                    { 3, "Ocjena 2/5", 2 },
                    { 4, "Ocjena 3/5", 3 },
                    { 5, "Ocjena 4/5", 4 },
                    { 6, "Ocjena 5/5", 5 }
                });

            migrationBuilder.InsertData(
                table: "OnlinePay",
                columns: new[] { "OnlinePayID", "DatumUplate", "Iznos", "KorisnickoIme", "PutniciKorisniciID", "Svrha" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 3, 21, 0, 45, 6, 83, DateTimeKind.Local), 30f, "amila", 0, "BanjaLuka 10.02.2021" },
                    { 8, new DateTime(2021, 3, 6, 0, 45, 6, 83, DateTimeKind.Local), 25f, "amila", 0, "BanjaLuka 10.02.2021" },
                    { 6, new DateTime(2021, 2, 23, 0, 45, 6, 82, DateTimeKind.Local), 55f, "amila", 0, "Instabul 16.02.2021" },
                    { 7, new DateTime(2021, 2, 23, 0, 45, 6, 83, DateTimeKind.Local), 200f, "amila", 0, "BanjaLuka 17.2.2020" }
                });

            migrationBuilder.InsertData(
                table: "PutniciKorisnici",
                columns: new[] { "PutnikKorisnikID", "Email", "Ime", "Kontakt", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime" },
                values: new object[] { 1, "amila.peco@gmail.com", "Amila", "123 456 745", "amila", "nX3I2MXaMLX9oQegdQ6Yz31sI9Q=", "LD4329GODyCIepothCV5HQ==", "Peco" });

            migrationBuilder.InsertData(
                table: "TipPrevoza",
                columns: new[] { "TipPrevozaID", "NazivTipa" },
                values: new object[,]
                {
                    { 1, "Autobus" },
                    { 2, "Avion" },
                    { 3, "Brod" }
                });

            migrationBuilder.InsertData(
                table: "Vodici",
                columns: new[] { "VodicID", "Ime", "JMBG", "Kontakt", "Prezime", "Slika", "Zauzet" },
                values: new object[,]
                {
                    { 1, "Amila", "1231231232321", "+062 71 485 300", "Peco", null, true },
                    { 2, "Jasmin", "4324322423423", "+123 45 678 910", "Azemovic", null, false },
                    { 3, "Elmir", "4324322423423", "+123 45 678 3", "Babovic", null, false },
                    { 4, "Emina", "4324322423423", "+123 45 678 3", "Junuz", null, false },
                    { 5, "Amila2", "4324322423423", "+123 45 678 3", "Peco", null, false }
                });

            migrationBuilder.InsertData(
                table: "VrstePutovanja",
                columns: new[] { "VrstaPutovanjaID", "Oznaka", "Vrijednost" },
                values: new object[,]
                {
                    { 7, "Školsko", 4 },
                    { 4, "Evropsko", 1 },
                    { 5, "Jadran", 2 },
                    { 6, "Mediteran", 3 }
                });

            migrationBuilder.InsertData(
                table: "Zaposlenici",
                columns: new[] { "ZaposlenikID", "Email", "Ime", "Kontakt", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime" },
                values: new object[] { 1, "alem.peco@edu.fit.ba", "Alem", "svakikon", "alem", "Hkygp3aJFIgOMtbHckDaXN5HYBA=", "DMUTs++b9XRsy8TQxXWtzw==", "Peco" });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "GradID", "DrzaveID", "NazivGrada" },
                values: new object[,]
                {
                    { 1, 1, "Travnik" },
                    { 20, 8, "Pariz" },
                    { 19, 7, "Lisabon" },
                    { 15, 5, "Palermo" },
                    { 14, 4, "Zakintos" },
                    { 10, 3, "Zürich" },
                    { 17, 2, "Tucepi" },
                    { 16, 2, "Tucepi" },
                    { 9, 2, "Makarska" },
                    { 13, 1, "Jajce" },
                    { 18, 6, "Barselona" },
                    { 11, 1, "Zenica" },
                    { 8, 1, "Visoko" },
                    { 7, 1, "Instabul" },
                    { 6, 1, "Bihac" },
                    { 5, 1, "Tuzla" },
                    { 4, 1, "Sarajevo" },
                    { 12, 1, "Mostar" },
                    { 3, 1, "Turbe" },
                    { 2, 1, "Sanski Most" }
                });

            migrationBuilder.InsertData(
                table: "Novosti",
                columns: new[] { "NovostID", "DatumVrijeme", "Naslov", "PutovanjeID", "Sadrzaj", "Slika", "ZaposlenikID" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 2, 17, 0, 45, 6, 80, DateTimeKind.Local), "Kako se obuci za putovanje", null, "Obuci se sto laganije za sva putovanja", null, 1 },
                    { 2, new DateTime(2021, 2, 24, 0, 45, 6, 80, DateTimeKind.Local), "Vazna obavjest", null, "Sva putovavanja uslijed pogorsanja epidemioloske situacije se odgađaju do daljnjeg.", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Pretplate",
                columns: new[] { "PretplataId", "Aktivno", "PutnikKorisnikId", "VrstaPutovanjaId" },
                values: new object[,]
                {
                    { 6, null, 1, 4 },
                    { 2, null, 1, 5 },
                    { 7, null, 1, 6 },
                    { 4, null, 1, 7 }
                });

            migrationBuilder.InsertData(
                table: "Prevoz",
                columns: new[] { "PrevozID", "BrojMjesta", "CijenaPoMjestu", "FirmaID", "TipPrevozaID" },
                values: new object[,]
                {
                    { 3, 50, 11f, 2, 1 },
                    { 5, 120, 60f, 3, 1 },
                    { 6, 50, 50f, 1, 1 },
                    { 7, 10, 10f, 2, 1 },
                    { 8, 10, 10f, 3, 1 },
                    { 9, 49, 6f, 1, 1 },
                    { 10, 130, 150f, 4, 2 },
                    { 1, 10, 10f, 1, 1 },
                    { 4, 49, 10f, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Putovanja",
                columns: new[] { "PutovanjaID", "GradID", "Naziv", "Opis", "PrevozID", "Slika", "VrstaPutovanjaID", "ZaposlenikID" },
                values: new object[,]
                {
                    { 13, 4, "Ljetovanje Makarska", " Makarska je priobalni grad u Splitsko-dalmatinskoj županiji, smješten podno planine Biokovo. Središte je Makarskog primorja (poznato pod imenom, Makarska .", 4, null, 5, 1 },
                    { 2, 19, "Putovanje u Barselonu", "Super ponuda ", 10, null, 4, 1 },
                    { 4, 1, "Obilazak grada Travnika", "Tvrđava Stari grad jedan je od najljepših i najočuvanijih fortifikacijskih objekata srednjovjekovne Bosne u kojem su naredni istorijski periodi ostavili svoja specifična obilježja", 9, null, 7, 1 },
                    { 7, 9, "Cari Instabula", "Upoznajte Instabul ", 8, null, 4, 1 },
                    { 6, 9, "Putovanje do Instabula", "Upoznajte Instabul ", 8, null, 4, 1 },
                    { 12, 15, "Putovanje na Siciliju", " Ne porpustite jedno od najljepsih putovanja iz nase ponude", 5, null, 6, 1 },
                    { 10, 19, "Putovanje u Portugal", " Lisabonje poznat po svojoj kolonijalističkoj povijesti.", 5, null, 4, 1 },
                    { 5, 14, "Vrelo Bune", "Najnovije putovanje ", 5, null, 7, 1 },
                    { 1, 1, "Banja Luka", "Skolska ekskurzija u Banja Luku", 5, null, 7, 1 },
                    { 9, 15, "Ljetovanje Grcka", "Super ponuda ", 10, null, 6, 1 },
                    { 11, 6, "Ekskurzija školska Jajce", " Tražite istorijske spomenike? Ne samo da ih ima, već je ovo jedan od gradova sa najviše nacionalnih spomenika u BiH! Jajce ima čak 30 nacionalnih spomenika.", 4, null, 7, 1 },
                    { 8, 18, "Ljetovanje Tucepi", "Ljepote Jadrana ", 3, null, 5, 1 },
                    { 3, 20, "Let do Pariza", "Najnovije putovanje ", 10, null, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Smjestaj",
                columns: new[] { "SmjestajID", "CijenaNoc", "GradID", "Naziv", "Opis", "Slika", "TipSobe" },
                values: new object[,]
                {
                    { 13, 100.0, 19, "Hotel Rossio Garden Hotel ", "Hotel 4 zvjezdice", null, "Svi Tip " },
                    { 15, 60.0, 18, "Hotel Tamaris Tucepi  ", "Hotel 3 zvjezdice", null, "Svi Tip " },
                    { 16, 50.0, 17, "Hotel Astoria Palace Hotel   ", "Hotel 4 zvjezdice", null, "Svi Tip " },
                    { 14, 30.0, 16, "Phoenix Hotel  ", "Hotel 5 zvjezdice", null, "Svi Tip " },
                    { 12, 40.0, 9, "Cheers Lighthouse", "Hotel 3 zvjezdice", null, "Tip " },
                    { 2, 100.0, 4, "Hotel Nacional", "Hotel 3 zvjezdice", null, "jednokrevetne" },
                    { 11, 100.0, 1, "Hotel Vezir Palace", "Hotel 3 zvjezdice", null, "dvokrevetna " }
                });

            migrationBuilder.InsertData(
                table: "Komentari",
                columns: new[] { "KomentarID", "PutnikKorisnikID", "PutovanjeID", "Sadrzaj", "Vrijeme" },
                values: new object[,]
                {
                    { 5, 1, 9, "Izgleda wooow", new DateTime(2021, 2, 22, 0, 45, 6, 79, DateTimeKind.Local) },
                    { 4, 1, 9, "Super putovanje ..preporuka", new DateTime(2021, 2, 20, 0, 45, 6, 79, DateTimeKind.Local) },
                    { 3, 1, 9, "Top", new DateTime(2021, 2, 20, 0, 45, 6, 79, DateTimeKind.Local) },
                    { 2, 1, 9, "Top", new DateTime(2021, 2, 20, 0, 45, 6, 79, DateTimeKind.Local) },
                    { 1, 1, 9, "Odlicno", new DateTime(2021, 2, 19, 0, 45, 6, 73, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Novosti",
                columns: new[] { "NovostID", "DatumVrijeme", "Naslov", "PutovanjeID", "Sadrzaj", "Slika", "ZaposlenikID" },
                values: new object[,]
                {
                    { 3, new DateTime(2021, 2, 22, 0, 45, 6, 80, DateTimeKind.Local), "Pomjera satnice za putnike u Barselonu", 2, "Pomjeranje putovanja satnice sa predviđenih 7:00h na 8:30h.", null, 1 },
                    { 1, new DateTime(2021, 2, 19, 0, 45, 6, 80, DateTimeKind.Local), "Vazna obavjest", 2, "Termin putovanja se pomjena sa 11h na 13h", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "OcjenePutovanja",
                columns: new[] { "OcjenaPutovanjeID", "OcjenaID", "PutnikKorisnikID", "PutovanjeID" },
                values: new object[,]
                {
                    { 4, 6, 1, 9 },
                    { 3, 6, 1, 9 },
                    { 2, 6, 1, 9 },
                    { 1, 6, 1, 2 },
                    { 5, 6, 1, 9 }
                });

            migrationBuilder.InsertData(
                table: "TerminiPutovanja",
                columns: new[] { "TerminPutovanjaID", "Aktivno", "BrojMjesta", "Cijena", "DatumPolaska", "DatumPovratka", "PutovanjeID", "Slika", "SmjestajID", "VodicID" },
                values: new object[,]
                {
                    { 11, true, 50, 120.0, new DateTime(2021, 4, 10, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 4, 15, 0, 45, 6, 89, DateTimeKind.Local), 8, null, 15, 4 },
                    { 2, true, 30, 150.0, new DateTime(2021, 2, 9, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 2, 11, 0, 45, 6, 89, DateTimeKind.Local), 3, null, 2, 2 },
                    { 9, true, 55, 250.0, new DateTime(2021, 2, 20, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 3, 2, 0, 45, 6, 89, DateTimeKind.Local), 2, null, 2, 2 },
                    { 5, true, 50, 130.0, new DateTime(2021, 2, 8, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 2, 12, 0, 45, 6, 89, DateTimeKind.Local), 2, null, 2, 3 },
                    { 6, true, 50, 130.0, new DateTime(2021, 2, 8, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 2, 12, 0, 45, 6, 89, DateTimeKind.Local), 7, null, 11, 3 },
                    { 14, true, 44, 67.0, new DateTime(2021, 3, 26, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 3, 30, 0, 45, 6, 89, DateTimeKind.Local), 12, null, 2, 3 },
                    { 12, true, 50, 200.0, new DateTime(2021, 3, 16, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 3, 24, 0, 45, 6, 89, DateTimeKind.Local), 10, null, 13, 1 },
                    { 4, true, 12, 44.0, new DateTime(2021, 2, 17, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 2, 12, 0, 45, 6, 89, DateTimeKind.Local), 5, null, 2, 3 },
                    { 1023, true, 44, 5555.0, new DateTime(2021, 2, 23, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 3, 5, 0, 45, 6, 89, DateTimeKind.Local), 1, null, 2, 2 },
                    { 1018, true, 4, 4.0, new DateTime(2021, 2, 21, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 2, 22, 0, 45, 6, 89, DateTimeKind.Local), 1, null, 2, 3 },
                    { 1017, true, 33, 40.0, new DateTime(2021, 2, 22, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 3, 3, 0, 45, 6, 89, DateTimeKind.Local), 1, null, 2, 2 },
                    { 1016, true, 33, 40.0, new DateTime(2021, 2, 21, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 3, 3, 0, 45, 6, 89, DateTimeKind.Local), 1, null, 2, 2 },
                    { 8, true, 40, 25.0, new DateTime(2021, 2, 14, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 2, 18, 0, 45, 6, 89, DateTimeKind.Local), 1, null, 2, 1 },
                    { 7, true, 40, 25.0, new DateTime(2021, 2, 14, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 2, 18, 0, 45, 6, 89, DateTimeKind.Local), 1, null, 2, 1 },
                    { 3, true, 40, 50.0, new DateTime(2021, 2, 14, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 2, 15, 0, 45, 6, 89, DateTimeKind.Local), 1, null, 11, 3 },
                    { 1, true, 40, 10.0, new DateTime(2021, 2, 9, 0, 45, 6, 88, DateTimeKind.Local), new DateTime(2021, 2, 11, 0, 45, 6, 88, DateTimeKind.Local), 1, null, 2, 2 },
                    { 15, true, 55, 120.0, new DateTime(2021, 3, 3, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 3, 10, 0, 45, 6, 89, DateTimeKind.Local), 13, null, 15, 3 },
                    { 13, true, 50, 45.0, new DateTime(2021, 2, 19, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 3, 2, 0, 45, 6, 89, DateTimeKind.Local), 11, null, 2, 2 },
                    { 1025, true, 55, 250.0, new DateTime(2021, 3, 26, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 4, 2, 0, 45, 6, 89, DateTimeKind.Local), 6, null, 12, 5 },
                    { 10, true, 50, 330.0, new DateTime(2021, 3, 21, 0, 45, 6, 89, DateTimeKind.Local), new DateTime(2021, 3, 26, 0, 45, 6, 89, DateTimeKind.Local), 9, null, 14, 3 }
                });

            migrationBuilder.InsertData(
                table: "Rezervacije",
                columns: new[] { "RezervacijaID", "PutnikKorisnikID", "TerminPutovanjaID", "Vrijeme" },
                values: new object[,]
                {
                    { 10, 1, 11, new DateTime(2021, 2, 20, 0, 45, 6, 86, DateTimeKind.Local) },
                    { 2, 1, 3, new DateTime(2021, 3, 5, 0, 45, 6, 86, DateTimeKind.Local) },
                    { 4, 1, 3, new DateTime(2021, 2, 14, 0, 45, 6, 86, DateTimeKind.Local) },
                    { 3, 1, 6, new DateTime(2021, 3, 5, 0, 45, 6, 86, DateTimeKind.Local) },
                    { 8, 1, 9, new DateTime(2021, 2, 20, 0, 45, 6, 86, DateTimeKind.Local) },
                    { 9, 1, 10, new DateTime(2021, 2, 20, 0, 45, 6, 86, DateTimeKind.Local) },
                    { 11, 1, 10, new DateTime(2021, 2, 28, 0, 45, 6, 86, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Uplate",
                columns: new[] { "UplataID", "DatumUplate", "Iznos", "RezervacijaID" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 14, 0, 45, 6, 90, DateTimeKind.Local), 45f, 2 },
                    { 4, new DateTime(2021, 2, 16, 0, 45, 6, 90, DateTimeKind.Local), 10f, 4 },
                    { 5, new DateTime(2021, 2, 15, 0, 45, 6, 90, DateTimeKind.Local), 10f, 4 },
                    { 6, new DateTime(2021, 2, 19, 0, 45, 6, 90, DateTimeKind.Local), 25f, 4 },
                    { 7, new DateTime(2021, 2, 24, 0, 45, 6, 90, DateTimeKind.Local), 25f, 4 },
                    { 8, new DateTime(2021, 2, 14, 0, 45, 6, 90, DateTimeKind.Local), 25f, 4 },
                    { 9, new DateTime(2021, 2, 24, 0, 45, 6, 90, DateTimeKind.Local), 25f, 4 },
                    { 10, new DateTime(2021, 2, 25, 0, 45, 6, 90, DateTimeKind.Local), 4f, 4 },
                    { 11, new DateTime(2021, 2, 26, 0, 45, 6, 90, DateTimeKind.Local), 44f, 4 },
                    { 16, new DateTime(2021, 2, 28, 0, 45, 6, 90, DateTimeKind.Local), 30f, 4 },
                    { 2, new DateTime(2021, 2, 17, 0, 45, 6, 90, DateTimeKind.Local), 250f, 3 },
                    { 15, new DateTime(2021, 2, 27, 0, 45, 6, 90, DateTimeKind.Local), 40f, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzaveID",
                table: "Gradovi",
                column: "DrzaveID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_PutnikKorisnikID",
                table: "Komentari",
                column: "PutnikKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_PutovanjeID",
                table: "Komentari",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Novosti_PutovanjeID",
                table: "Novosti",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Novosti_ZaposlenikID",
                table: "Novosti",
                column: "ZaposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenePutovanja_OcjenaID",
                table: "OcjenePutovanja",
                column: "OcjenaID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenePutovanja_PutnikKorisnikID",
                table: "OcjenePutovanja",
                column: "PutnikKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenePutovanja_PutovanjeID",
                table: "OcjenePutovanja",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Pretplate_PutnikKorisnikId",
                table: "Pretplate",
                column: "PutnikKorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Pretplate_VrstaPutovanjaId",
                table: "Pretplate",
                column: "VrstaPutovanjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prevoz_FirmaID",
                table: "Prevoz",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Prevoz_TipPrevozaID",
                table: "Prevoz",
                column: "TipPrevozaID");

            migrationBuilder.CreateIndex(
                name: "IX_Putovanja_GradID",
                table: "Putovanja",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Putovanja_PrevozID",
                table: "Putovanja",
                column: "PrevozID");

            migrationBuilder.CreateIndex(
                name: "IX_Putovanja_VrstaPutovanjaID",
                table: "Putovanja",
                column: "VrstaPutovanjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Putovanja_ZaposlenikID",
                table: "Putovanja",
                column: "ZaposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_PutnikKorisnikID",
                table: "Rezervacije",
                column: "PutnikKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_TerminPutovanjaID",
                table: "Rezervacije",
                column: "TerminPutovanjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Smjestaj_GradID",
                table: "Smjestaj",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_TerminiPutovanja_PutovanjeID",
                table: "TerminiPutovanja",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_TerminiPutovanja_SmjestajID",
                table: "TerminiPutovanja",
                column: "SmjestajID");

            migrationBuilder.CreateIndex(
                name: "IX_TerminiPutovanja_VodicID",
                table: "TerminiPutovanja",
                column: "VodicID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_RezervacijaID",
                table: "Uplate",
                column: "RezervacijaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komentari");

            migrationBuilder.DropTable(
                name: "Novosti");

            migrationBuilder.DropTable(
                name: "OcjenePutovanja");

            migrationBuilder.DropTable(
                name: "OnlinePay");

            migrationBuilder.DropTable(
                name: "Pretplate");

            migrationBuilder.DropTable(
                name: "Uplate");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "PutniciKorisnici");

            migrationBuilder.DropTable(
                name: "TerminiPutovanja");

            migrationBuilder.DropTable(
                name: "Putovanja");

            migrationBuilder.DropTable(
                name: "Smjestaj");

            migrationBuilder.DropTable(
                name: "Vodici");

            migrationBuilder.DropTable(
                name: "Prevoz");

            migrationBuilder.DropTable(
                name: "VrstePutovanja");

            migrationBuilder.DropTable(
                name: "Zaposlenici");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Firme");

            migrationBuilder.DropTable(
                name: "TipPrevoza");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
