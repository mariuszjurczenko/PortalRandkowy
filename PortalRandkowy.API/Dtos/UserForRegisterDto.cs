using System.ComponentModel.DataAnnotations;

namespace PortalRandkowy.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage="Nazwa użytkownika jest wymagana")]
        public string Username { get; set; }
        [Required(ErrorMessage="Hasło jest wymagane")]
        [StringLength(12, MinimumLength=6, ErrorMessage="Hasło musi się składać z 4 do 8 znaków")]
        public string Password { get; set; }
    }
}