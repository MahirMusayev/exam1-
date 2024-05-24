using System.ComponentModel.DataAnnotations;

namespace AgencyExam.ViemModel.Account
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Name daxil edin")]
        [MaxLength(25,ErrorMessage ="25 simvolan cox olmamalidi")]
        [MinLength(3, ErrorMessage = "3 simvolan cox olmalidi")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname daxil edin")]
        [MaxLength(25, ErrorMessage = "25 simvolan cox olmamalidi")]
        [MinLength(3, ErrorMessage = "3 simvolan cox olmalidi")]
        public string Surname {  get; set; }
        [Required(ErrorMessage = "Usename daxil edin")]
        [MaxLength(25, ErrorMessage = "25 simvolan cox olmamalidi")]
        [MinLength(3, ErrorMessage = "3 simvolan cox olmalidi")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email daxil edin")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password daxil edin")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password daxil edin")]
        [DataType(DataType.Password),Compare("Password")]
        public string ComparePassword {  get; set; }
    }
}
