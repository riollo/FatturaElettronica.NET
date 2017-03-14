﻿using FatturaElettronica.Tabelle;
using FluentValidation.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class DatiAnagraficiCedentePrestatoreValidator 
        : BaseClass<FatturaElettronica.FatturaElettronicaHeader.CedentePrestatore.DatiAnagraficiCedentePrestatore,
            FatturaElettronica.Validators.DatiAnagraficiCedentePrestatoreValidator>
    {
        [TestMethod]
        public void IdFiscaleIVAHasChildValidator()
        {
            validator.ShouldHaveChildValidator(x => x.IdFiscaleIVA, typeof(FatturaElettronica.Validators.IdFiscaleIVAValidator));
        }
        [TestMethod]
        public void CodiceFiscaleIsOptional()
        {
            AssertOptional(x => x.CodiceFiscale);
        }
        [TestMethod]
        public void CodiceFiscaleMinMaxLength()
        {
            AssertMinMaxLength(x => x.CodiceFiscale, 11, 16);
        }
        [TestMethod]
        public void AnagraficaHasChildValidator()
        {
            validator.ShouldHaveChildValidator(x => x.Anagrafica, typeof(FatturaElettronica.Validators.AnagraficaValidator));
        }
        [TestMethod]
        public void AlboProfessionalIsOptional()
        {
            AssertOptional(x => x.AlboProfessionale);
        }
        [TestMethod]
        public void AlboProfessionaleMinMaxLength()
        {
            AssertMinMaxLength(x => x.AlboProfessionale, 1, 60);
        }
        [TestMethod]
        public void ProvinciaAlboIsOptional()
        {
            AssertOptional(x => x.ProvinciaAlbo);
        }
        [TestMethod]
        public void ProvinciaAlboOnlyAcceptsTableValues()
        {
            AssertOnlyAcceptsTableValues<Provincia>(x => x.ProvinciaAlbo);
        }
        [TestMethod]
        public void NumeroIscrizioneAlboIsOptional()
        {
            AssertOptional(x => x.NumeroIscrizioneAlbo);
        }
        [TestMethod]
        public void NumeroIscrizioneAlboMinMaxLength()
        {
            AssertMinMaxLength(x => x.NumeroIscrizioneAlbo, 1, 60);
        }
        [TestMethod]
        public void RegimeFiscaleIsRequired()
        {
            AssertRequired(x => x.RegimeFiscale);
        }
        [TestMethod]
        public void RegimeFiscaleOnlyAcceptsTableValues()
        {
            AssertOnlyAcceptsTableValues<RegimeFiscale>(x => x.RegimeFiscale);
        }
    }
}