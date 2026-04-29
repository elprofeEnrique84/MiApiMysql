using MIAPIMYSQL.DTOs;
using MIAPIMYSQL.Models;

namespace MIAPIMYSQL.Services
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetAllAsync();
        Task<Producto?> GetByIdAsync(int id);
        Task<Producto> CreateAsync(ProductoDto dto);
        Task<Producto?> UpdateAsync(int id, ProductoDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
