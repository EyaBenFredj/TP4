using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotellerie_X.Models.HotellerieModel
{
    public class Appreciation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom de la personne est requis.")]
        [Display(Name = "Nom Personne")]
        public string NomPers { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le commentaire est obligatoire.")]
        public string Commentaire { get; set; }

        [Required(ErrorMessage = "La note est obligatoire.")]
        [Range(1, 10, ErrorMessage = "La note doit être entre 1 et 10.")]
        public int Note { get; set; } = 5;

        // Foreign key
        public int HotelId { get; set; }

        // Navigation
        public Hotel? Hotel { get; set; }
    }
}