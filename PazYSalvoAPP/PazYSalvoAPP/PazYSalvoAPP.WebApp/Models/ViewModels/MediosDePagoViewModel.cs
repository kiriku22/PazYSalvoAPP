using PazYSalvoAPP.Models;
using System.ComponentModel.DataAnnotations;

namespace PazYSalvoAPP.WebApp.Models.ViewModels
{
    public class MediosDePagoViewModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        public DateTime? FechaDeCreacion { get; set; }

    }
}

