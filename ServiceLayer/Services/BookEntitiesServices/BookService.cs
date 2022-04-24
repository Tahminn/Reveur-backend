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
        internal readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository,
                                           IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookDTO>> GetAllAsync()
        {
            return _mapper.Map<List<BookDTO>>(await _bookRepository.GetAllAsync());
        }

        public async Task<BookDetailsDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<BookDetailsDTO>(await _bookRepository.GetByIdAsync(id));
        }

    }
}
