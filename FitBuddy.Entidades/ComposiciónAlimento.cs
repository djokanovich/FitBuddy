using System.ComponentModel.DataAnnotations.Schema;

namespace FitBuddy.Entidades
{
    [Table("ComposiciónAlimentos")]
    public class ComposiciónAlimento
    {
        public int Id { get; set; }
        public string Alimento { get; set; }
        public float Calorías { get; set; }
        public float ProteínaEnGramos { get; set; }
        public float GrasasEnGramos { get; set; }
        public float ChoDEnGramos { get; set; }
        public float ChoTEnGramos { get; set; }
        public float FibraTEnGramos { get; set; }
        public float CalcioEnMiligramos { get; set; }
        public float FósforoEnMiligramos { get; set; }
        public float HierroEnMiligramos { get; set; }
        public float MagnesioEnMiligramos { get; set; }
        public float ZincEnMiligramos { get; set; }
        public float CobreEnMiligramos { get; set; }
        public float SodioEnMiligramos { get; set; }
        public float PotasioEnMiligramos { get; set; }
        public float VitaminaAEr { get; set; }
        public float BetaCarotenoEt { get; set; }
        public float TiaminaEnMiligramos { get; set; }
        public float RiboflavinaEnMiligramos { get; set; }
        public float NiacinaEnMiligramos { get; set; }
        public float VitaminaB6EnMiligramos { get; set; }
        public float ÁcidoAscEnMiligramos { get; set; }
    }
}
