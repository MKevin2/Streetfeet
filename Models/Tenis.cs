using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto3DS.Models
{
    [Table("Tenis")]
    public class Tenis{

        [MaxLength(200)]
        [MinLength(20)]
        public string desc_curta { get; set; }

        public string desc_detalhe { get; set; }

        public bool em_estoque { get; set; }

        [Key]
        public int tenis_id { get; set; }

        [Required(ErrorMessage = "O nome do tênis deve ser informado")]
        [Display(Name = "Nome do Tênis")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Tamanho Inválido")]
        public string nome { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99)]
        public decimal preco { get; set; }

        public string img_url { get; set; }
        [NotMapped]
        public string tenis_preferido { get; set; }

        public string img_miniatura { get; set; }

        public int categoria_id { get; set; }

        public string Categoria { get; set; }

        public virtual Categoria categoria { get; set; }
    }
}


