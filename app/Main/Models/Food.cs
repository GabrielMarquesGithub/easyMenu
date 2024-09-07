using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Models;

[Table("Foods")]
public sealed class Food
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome do prato")]
    [StringLength(80, MinimumLength = 3, ErrorMessage = "O tamanho deve ser entre {2} e {1} caracteres")]
    [Display(Name = "Nome")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Informe a descrição do prato")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "O tamanho deve ser entre {2} e {1} caracteres")]
    [Display(Name = "Descrição")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Informe a descrição detalhada do prato")]
    [StringLength(1000, MinimumLength = 3, ErrorMessage = "O tamanho deve ser entre {2} e {1} caracteres")]
    [Display(Name = "Descrição Detalhada")]
    public string DetailedDescription { get; set; }

    [StringLength(200, ErrorMessage = "O tamanho deve ser entre {2} e {1} caracteres")]
    [Display(Name = "URL da Imagem")]
    public string ImageUrl { get; set; }

    [StringLength(200, ErrorMessage = "O tamanho deve ser entre {2} e {1} caracteres")]
    [Display(Name = "URL da Miniatura")]
    public string ThumbnailUrl { get; set; }

    [Required(ErrorMessage = "Informe o preço do prato")]
    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(0.01, 99999.99, ErrorMessage = "O preço deve ser entre {1} e {2}")]
    public decimal Price { get; set; }

    [Display(Name = "Disponível")]
    public bool IsAvailable { get; set; }

    [Display(Name = "Preferido")]
    public bool IsFavorite { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
