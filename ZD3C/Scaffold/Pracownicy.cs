﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ZD3C.Scaffold
{
    public partial class Pracownicy
    {
        public Pracownicy()
        {
            Zamówienia = new HashSet<Zamówienium>();
        }

        public int Idpracownika { get; set; }
        public string Nazwisko { get; set; }
        public string Imię { get; set; }
        public string Stanowisko { get; set; }
        public string ZwrotGrzecznościowy { get; set; }
        public DateTime? DataUrodzenia { get; set; }
        public DateTime? DataZatrudnienia { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public string Region { get; set; }
        public string KodPocztowy { get; set; }
        public string Kraj { get; set; }
        public string TelefonDomowy { get; set; }
        public string TelefonWewnętrzny { get; set; }
        public byte[] Fotografia { get; set; }
        public string Uwagi { get; set; }
        public int? Szef { get; set; }

        public virtual ICollection<Zamówienium> Zamówienia { get; set; }
    }
}
