using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaGranAPI.Models
{
    public class Produto
    {
        [Key]

        public int Id { get; set; }

        [Required]

        public int CategoriaId { get; set; }

        [Required]

        public string Nome { get; set; }

        [Required]

        public string Descricao { get; set; }

        [Required]

        public int Estoque { get; set; }

        [Required]

        public decimal ValorCusto { get; set; }

        [Required]

        public decimal ValorVenda { get; set; }

        [Required]

        public bool Destaque { get; set; }
    }
}