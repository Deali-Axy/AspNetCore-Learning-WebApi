using System.ComponentModel.DataAnnotations;

namespace Library.Api.Models {
    public class BookForCreationDto {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
    }
}