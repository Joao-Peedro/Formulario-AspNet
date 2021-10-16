using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título deve ter entre 3 e 60 caracteres.")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto.")]
        [Required(ErrorMessage = "O campo Data de Lancamento é obrigatório.")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Genero em formato inválido.")]
        [Required(ErrorMessage = "O campo Genero é obrigatório.")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres.")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor deve ser de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o campo Valor.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números de 0 a 5.")]
        [Required(ErrorMessage = "Preencha o campo Avaliação.")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
