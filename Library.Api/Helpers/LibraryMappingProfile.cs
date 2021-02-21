using AutoMapper;
using Library.Api.Entities;
using Library.Api.Models;

namespace Library.Api.Helpers {
    public class LibraryMappingProfile : Profile {
        public LibraryMappingProfile() {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Age,
                    config =>
                        config.MapFrom(src => src.BirthDate.Year));
            CreateMap<AuthorForCreationDto, Author>();
            
            CreateMap<Book, BookDto>();
            CreateMap<BookForCreationDto, Book>();
            CreateMap<BookForUpdateDto, Book>();
        }
    }
}