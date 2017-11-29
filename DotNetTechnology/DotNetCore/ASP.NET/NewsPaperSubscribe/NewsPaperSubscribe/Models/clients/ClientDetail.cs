using System.ComponentModel.DataAnnotations;

namespace NewsPaperSubscribe.Models
{
    public class ClientDetails
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Company name is required filed")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Client name must be required")]
        public string Client { get; set; }

        [Required]
        public bool NewsPaper { get; set; }
    }
}
