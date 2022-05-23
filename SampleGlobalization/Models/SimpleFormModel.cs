using System.ComponentModel.DataAnnotations;

namespace SampleGlobalization.Models
{
    public class SimpleFormModel
    {
        [StringLength(30, MinimumLength = 1)]
        [Required]
        [Display(Name = "NickName", ResourceType = typeof(App_GlobalResources.Resource))]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Invalid nick")]
        public string Nick { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email is not valid")]
        [Display(Name = "EmailName", ResourceType = typeof(App_GlobalResources.Resource))]
        public string Email { get; set; }
    }
}