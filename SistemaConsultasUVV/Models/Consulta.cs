using System.ComponentModel.DataAnnotations;

namespace SistemaConsultasUVV.Models
{
    public class Consulta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do médico é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do médico não pode exceder 100 caracteres.")]
        public string Medico { get; set; } = string.Empty;

        [Required(ErrorMessage = "A especialidade é obrigatória.")]
        [StringLength(100, ErrorMessage = "A especialidade não pode exceder 100 caracteres.")]
        public string Especialidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data e hora são obrigatórias.")]
        [Display(Name = "Data e Hora")]
        public DateTime DataHora { get; set; } = TimeZoneInfo.ConvertTimeFromUtc(
            DateTime.UtcNow, 
            TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time")
        );

        public string Status { get; set; } = "Agendada";

        [StringLength(500, ErrorMessage = "As observações não podem exceder 500 caracteres.")]
        public string? Observacoes { get; set; }

        // Chave Estrangeira do Usuário (Relacionamento)
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}