using AutoMapper;
using DomainLayer.Entities.BookEntities;
using RepositoryLayer.Repositories.Interfaces.BookEntitiesInterfaces;
using ServiceLayer.DTOs.BookDTOs;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.BookEntitiesServices
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository,
                                           IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookDTO>> GetAllBooksWithAuthorsAndImagesAsync()
        {
            List<Book> books = await _bookRepository.GetAllBooksWithAuthorsAndImagesAsync();
            var mappedData = _mapper.Map<List<BookDTO>>(books);
            return mappedData;
        }

    }
}
