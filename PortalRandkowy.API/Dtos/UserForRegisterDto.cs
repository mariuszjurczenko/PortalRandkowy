using System.ComponentModel.DataAnnotations;

namespace PortalRandkowy.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage="Nazwa użytkownika jest wymagana")]
        public string Username { get; set; }
        [Required(ErrorMessage="Hasło jest wymagane")]
        [StringLength(12, MinimumLength=6, ErrorMessage="Hasło musi się składać z 6 do 12 znaków")]
        public string Password { get; set; }
    }
}