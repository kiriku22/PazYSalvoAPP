using PazYSalvoAPP.Models;
using System.ComponentModel.DataAnnotations;

namespace PazYSalvoAPP.WebApp.Models.ViewModels
{
    public class PagoViewModel
    {
        public int Id { get; set; }

        public decimal? MontoDePago { get; set; }

        public int? FacturaId { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaDeCreacion { get; set; }

    }
}

