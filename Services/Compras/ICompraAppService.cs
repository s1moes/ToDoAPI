﻿using API_ToDo.Models;

namespace API_ToDo.Services.Compras
{
    public interface ICompraAppService
    {
        //Task<CompraDto> CreateAsync(CreateCompraDto input);
        Task<List<Compra>> GetAllComprasAsync();
        //Task DeleteAllComprasAsync();
        //Task<bool> DeleteByIdCompraAsync(Guid id);
    }
}
