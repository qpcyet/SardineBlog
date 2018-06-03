using System.ComponentModel.DataAnnotations;

namespace SardineBlog.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}