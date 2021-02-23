using System;
using AutoMapper;
using Library.Api.Entities;
using Library.Api.Models;

namespace Library.Api.Helpers {
    public class LibraryMappingProfile : Profile {
        public LibraryMappingProfile() {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Age,
                    config =>
                        config.MapFrom(src => DateTime.Now.Year - src.BirthDate.Year));
            CreateMap<AuthorForCreationDto, Author>();

            CreateMap<Book, BookDto>();
            CreateMap<Book, BookForCreationDto>();
            CreateMap<BookForCreationDto, Book>();
            CreateMap<Book, BookForUpdateDto>();
            CreateMap<BookForUpdateDto, Book>();
        }
    }
}