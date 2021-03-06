﻿using System;
namespace RentACar.Models
{
    public class Rezervacija : IRezervisi
    {
        public enum NacinPlacanja
        {
            URADNJI,
            SADA
        };

        private int id;
        private int brojDana;
        private Klijent klijent;
        private Vozilo vozilo;
        private int nacinPlacanja;
        private Grad gradPreuzimanja;
        private Grad gradVracanja;
        private DateTime datumPreuzimanja;
        private DateTime datumVracanja;
        private int klijentId;
        private int voziloId;
        private int gradPreuzimanjaId;
        private int gradVracanjaId;


        public int Id { get => id; set => id = value; }
        public int BrojDana { get => brojDana; set => brojDana = value; }
        public Vozilo Vozilo { get => vozilo; set => vozilo = value; }
        public int NacinPlacanja1 { get => nacinPlacanja; set => nacinPlacanja = value; }
        public Grad GradPreuzimanja { get => gradPreuzimanja; set => gradPreuzimanja = value; }
        public Grad GradVracanja { get => gradVracanja; set => gradVracanja = value; }
        public DateTime DatumPreuzimanja { get => datumPreuzimanja; set => datumPreuzimanja = value; }
        public DateTime DatumVracanja { get => datumVracanja; set => datumVracanja = value; }
        public int KlijentId { get => klijentId; set => klijentId = value; }
        public int VoziloId { get => voziloId; set => voziloId = value; }
        public int GradPreuzimanjaId { get => gradPreuzimanjaId; set => gradPreuzimanjaId = value; }
        public int GradVracanjaId { get => gradVracanjaId; set => gradVracanjaId = value; }
        public Klijent Klijent { get => klijent; set => klijent = value; }

        public Rezervacija()
        {
        }

        public Rezervacija(int id, int brojDana, Klijent klijent, Vozilo voizlo, int nacinPlacanja, Grad gradPreuzimanja, Grad gradVracanja, DateTime datumPreuzimanja, DateTime datumVracanja)
        {
            this.Id = id;
            this.BrojDana = brojDana;
            this.Klijent = klijent;
            this.Vozilo = voizlo;
            this.NacinPlacanja1 = nacinPlacanja;
            this.GradPreuzimanja = gradPreuzimanja;
            this.GradVracanja = gradVracanja;
            this.DatumPreuzimanja = datumPreuzimanja;
            this.DatumVracanja = datumVracanja;
        }

        public void rezervisi()
        {
            throw new NotImplementedException();
        }
    }
}
