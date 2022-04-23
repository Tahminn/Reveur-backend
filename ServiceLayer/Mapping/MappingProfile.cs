using AutoMapper;
using DomainLayer.Entities.BookEntities;
using ServiceLayer.DTOs.BookDTOs;

namespace ServiceLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDTO>()
                .ForMember(bdto => bdto.BookImages, opt => opt.MapFrom(b => b.BookImages))
                .ForMember(bdto => bdto.BookAuthors, opt => opt.MapFrom(b => b.BookAuthors))
                .ForAllMembers(m => m.Condition((dest, src, obj) => obj != null));

            CreateMap<Author, AuthorDTO>();
            CreateMap<BookAuthor, BookAuthorDTO>()
                .ForMember(bdto => bdto.AuthorId, opt => opt.MapFrom(b => b.Author.Id))
                .ForMember(bdto => bdto.BookId, opt => opt.MapFrom(b => b.Book.Id));

            CreateMap<BookImage, BookImageDTO>();

            CreateMap<BookDTO, Book>().ForAllMembers(m => m.Condition((dest, src, obj) => obj != null));
        }
    }
}
