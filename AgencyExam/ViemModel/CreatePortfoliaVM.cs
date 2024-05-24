using System.ComponentModel.DataAnnotations;

namespace AgencyExam.ViemModel
{
    public class CreatePortfoliaVM
    {
        [Required(ErrorMessage = "Name Daxil edin")]
        [MaxLength(50,ErrorMessage ="50 Simvoldan Artiq Olmaz")]
        [MinLength(3, ErrorMessage = "3 Simvoldan Artiq Olmalidi")]
        public string Name { get; set; }
        [Required(ErrorMessage = "SubTitle Daxil edin")]
        [MinLength(3, ErrorMessage = "3 Simvoldan Artiq Olmalidi")]
        public string Subtitle { get; set; }
        [Required(ErrorMessage ="Image Daxil edin")]
        public string ImageUrl { get; set; }
    }
}
