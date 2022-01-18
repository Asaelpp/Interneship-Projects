using System.ComponentModel.DataAnnotations;

namespace ConstNavesTeste.Models
{
    public class SpaceShip
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "o Campo nome é Obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Modelo é Obrigatório")]
        public string Modelo { get; set; }
        public int IdNave { get; set; }
    }
}



// aqui é colocado o que será enviado para a requisição