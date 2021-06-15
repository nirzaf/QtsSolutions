using System.ComponentModel.DataAnnotations;

namespace QtsSolutions.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}