using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Annons
    {
        public int AnnonsId { get; private set; }
        public string Titel { get; private set; }
        public decimal Pris { get; private set; }
        private DateTime Publiceringsdatum { get; set; }
        public AnnonsStatus StatusAnnons { get; private set; }
        public AnnonsSkick Skick { get; private set; }
        public Student Säljare { get; }
        public Kurs Kurs { get; private set; }

        public Annons(int annonsId, string titel, decimal pris,
            AnnonsSkick skick, AnnonsStatus status,
            DateTime publiceringsdatum, Student säljare, Kurs kurs)
        {
            AnnonsId = annonsId;
            Titel = titel;
            Pris = pris;
            StatusAnnons = status;
            Skick = skick;
            Publiceringsdatum = publiceringsdatum;
            Säljare = säljare;
            Kurs = kurs;
        }

        public bool KontrolleraStatus()
        {
            return StatusAnnons == AnnonsStatus.TillSalu;
        }

        public void UppdateraAnnonsStatus(AnnonsStatus nyAnnonsStatus)
        {
            StatusAnnons = nyAnnonsStatus;
        }
        public void UppdateraAnnons(string nyTitel, decimal nyttPris, AnnonsSkick nyttSkick)
        {
            Titel = nyTitel;
            Pris = nyttPris;
            Skick = nyttSkick;
        }

        public override string ToString()
        {
            string status = StatusAnnons switch //switchen betyder i andra fall
            {
                AnnonsStatus.TillSalu => "Till salu",
                AnnonsStatus.Reserverad => "Reserverad",
                AnnonsStatus.Sald => "Såld",
                _ => StatusAnnons.ToString()
            };
            return $"[{AnnonsId}] {Titel} - {Pris} kr, {Skick}, {status}";
        }
    }
}