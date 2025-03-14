using ToDoList.Application.Compras.Dto;

namespace ToDoList.Application.Compras
{
    public interface ICompraAppService
    {
        Task<CompraDto> CreateAsync(CreateCompraDto input);
        Task<List<CompraDto>> GetAllComprasAsync();
        Task DeleteAllComprasAsync();
        Task<bool> DeleteByIdCompraAsync(Guid id);
    }
}
