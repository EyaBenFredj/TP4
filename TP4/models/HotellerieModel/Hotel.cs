using System.ComponentModel.DataAnnotations;

namespace Hotellerie_X.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        public string? Tel { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Le nom doit être entre 3 et 20 caractères.")]
        public string Nom { get; set; }

        [Range(1, 5, ErrorMessage = "Les étoiles doivent être entre 1 et 5.")]
        public int Etoiles { get; set; }

        [Required(ErrorMessage = "La ville est obligatoire.")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "Le Site Web est obligatoire.")]
        [Url(ErrorMessage = "Le champ Site Web doit contenir une URL valide.")]
        [Display(Name = "Site Web")]
        public string SiteWeb { get; set; }
        public ICollection<Appreciation>? Appreciations { get; set; }
        public string Pays { get; set; } = "Tunisie";

    }
}
