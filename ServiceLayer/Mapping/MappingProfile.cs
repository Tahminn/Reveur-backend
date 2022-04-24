using AutoMapper;
using DomainLayer.Entities.BookEntities;
using ServiceLayer.DTOs.BookDTOs;

namespace ServiceLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Book Entities Mapping

            CreateMap<Author, AuthorDTO>()
                .ForAllMembers(b => b.Condition((dest, src, obj) => obj != null));

            CreateMap<Book, BookDetailsDTO>()
                .ForMember(badto => badto.Publisher, opt => opt.MapFrom(ba => ba.BookDetails.Publisher))
                .ForMember(badto => badto.Description, opt => opt.MapFrom(ba => ba.BookDetails.Description))
                .ForMember(badto => badto.PageCount, opt => opt.MapFrom(ba => ba.BookDetails.PageCount))
                .ForMember(badto => badto.UnitsSold, opt => opt.MapFrom(ba => ba.BookDetails.UnitsSold))
                .ForMember(badto => badto.UnitsQuantity, opt => opt.MapFrom(ba => ba.BookDetails.UnitsQuantity))
                .ForMember(badto => badto.Excerpt, opt => opt.MapFrom(ba => ba.BookDetails.Excerpt))
                .ForMember(badto => badto.BookImages, opt => opt.MapFrom(ba => ba.BookImages.ToList()))
                .ForMember(badto => badto.Authors, opt => opt.MapFrom(ba => ba.BookAuthors.Select(ba => ba.Author).ToList()))
                .ForMember(badto => badto.BookGenres, opt => opt.MapFrom(ba => ba.BookGenres.Select(ba => ba.Genre).ToList()))
                .ForMember(badto => badto.BookLanguages, opt => opt.MapFrom(ba => ba.BookLanguages.Select(ba => ba.Language).ToList()))
                .ForMember(badto => badto.BookTags, opt => opt.MapFrom(ba => ba.BookTags.Select(ba => ba.Tag).ToList()))
                .ForAllMembers(b => b.Condition((dest, src, obj) => obj != null));

            CreateMap<Book, BookDTO>()
               .ForMember(badto => badto.Authors, opt => opt.MapFrom(ba => ba.BookAuthors.Select(ba => ba.Author).ToList()))
               .ForAllMembers(b => b.Condition((dest, src, obj) => obj != null));

            CreateMap<BookImage, BookImageDTO>()
                .ForAllMembers(b => b.Condition((dest, src, obj) => obj != null));

            CreateMap<Category, CategoryDTO>()
               .ForAllMembers(b => b.Condition((dest, src, obj) => obj != null));

            CreateMap<Genre, GenreDTO>()
                .ForAllMembers(b => b.Condition((dest, src, obj) => obj != null));

            CreateMap<Language, LanguageDTO>()
                .ForAllMembers(b => b.Condition((dest, src, obj) => obj != null));

            CreateMap<Tag, TagDTO>()
                .ForAllMembers(b => b.Condition((dest, src, obj) => obj != null));

            #endregion
        }
    }
}
