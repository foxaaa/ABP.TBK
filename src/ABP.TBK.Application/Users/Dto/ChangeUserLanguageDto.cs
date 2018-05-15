using System.ComponentModel.DataAnnotations;

namespace ABP.TBK.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}