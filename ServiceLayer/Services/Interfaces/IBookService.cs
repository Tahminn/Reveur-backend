using ServiceLayer.DTOs.BookDTOs;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBookService
    {
        Task<List<BookDTO>> GetAllAsync();
        Task<BookDetailsDTO> GetByIdAsync(int id);
    }
}
