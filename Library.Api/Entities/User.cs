using System;
using Microsoft.AspNetCore.Identity;

namespace Library.Api.Entities {
    public class User : IdentityUser {
        public DateTimeOffset BirthDate { get; set; }
    }
}