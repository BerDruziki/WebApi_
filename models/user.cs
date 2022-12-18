using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Users")]
public class User
{
    [Key]
    [Required]
    public int id { get; set; }
        
    [Required]
    public string uuId { get; set; }
    
    [Required]
    public string name { get; set; }

    [Required]
    public string email { get; set; }

    [Required]
    public string password { get; set; }

    [Required]
    public string company { get; set; }

    [Required]
    public int cpf { get; set; }

    [Required]
    public int phone { get; set; }
}