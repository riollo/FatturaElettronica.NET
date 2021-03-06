﻿using System.Collections.Generic;
using System.Xml;
using FatturaElettronica.Common;

namespace FatturaElettronica.Ordinaria.FatturaElettronicaBody.DatiPagamento
{
    /// <summary>
    /// Dati relativi al pagamento.
    /// </summary>
    public class DatiPagamento : BaseClassSerializable
    {
        /// <summary>
        /// Dati relativi al pagamento.
        /// </summary>
        public DatiPagamento()
        {
            DettaglioPagamento = new List<DettaglioPagamento>();
        }

        public DatiPagamento(XmlReader r) : base(r) { }

        /// <summary>
        /// Condizioni di pagamento.
        /// </summary>
        [DataProperty]
        public string CondizioniPagamento { get; set; }

        /// <summary>
        /// Dati di dettaglio del pagamento.
        /// </summary>
        [DataProperty]
        public List<DettaglioPagamento> DettaglioPagamento { get; set; }
    }
}
