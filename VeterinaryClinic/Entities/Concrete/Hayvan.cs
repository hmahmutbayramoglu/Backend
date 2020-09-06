using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Hayvan : IEntity
    {

        public int İd { get; set; }

        public int Musteriİd { get; set; }

        public int Turİd { get; set; }

        public int İrkİd { get; set; }

        public string Adi { get; set; }

        public string Kurk { get; set; }

        public string OnemliHastaligi { get; set; }

        public string Aciklama { get; set; }

        public DateTime DogumTarihi { get; set; }

        public DateTime KayitTarihi { get; set; }

        public bool AktiflikDurumu { get; set; }


    }
}
