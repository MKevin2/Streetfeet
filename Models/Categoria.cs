using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Projeto3DS.Models
{
   public class Categoria
        {
        public int categoria_id { get; set; }

        [StringLength(100, ErrorMessage = "Tamanho Inválido")]
        public string categoria_nome { get; set; }
        public string desc { get; set; }
        public List<Tenis> Tenis { get; set; }
        }
}
