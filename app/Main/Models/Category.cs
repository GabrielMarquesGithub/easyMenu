using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Models;

[Table("Categories")]
public sealed class Category
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome da categoria")]
    [StringLength(80, MinimumLength = 3, ErrorMessage = "O tamanho deve ser entre {2} e {1} caracteres")]
    [Display(Name = "Nome")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Informe a descrição da categoria")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "O tamanho deve ser entre {2} e {1} caracteres")]
    [Display(Name = "Descrição")]
    public string Description { get; set; }

    public List<Food> Foods { get; set; }
}
