using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dev_backend.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar Senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar Senha!")]
        public Perfil Perfil { get; set; }
    }
    public enum Perfil
    {
        Admin,
        User
    }
}
