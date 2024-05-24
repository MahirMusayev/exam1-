using System.ComponentModel.DataAnnotations;

namespace AgencyExam.ViemModel.Account
{
    public class LoginVM
    {
        [Required,MinLength(3,ErrorMessage ="3 simvoldan artiq olmalidi")]
        public string UserOrEmail {  get; set; }
        [Required,]
        public string Password { get; set; }
    }
}
