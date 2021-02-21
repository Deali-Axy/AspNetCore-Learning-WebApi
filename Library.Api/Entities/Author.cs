using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Api.Entities {
    public class Author {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public DateTimeOffset BirthDate { get; set; }

        [Required]
        [MaxLength(40)]
        public string BirthPlace { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}