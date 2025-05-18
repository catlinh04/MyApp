using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Application.DTOs.ItemDto.Requests;
using MyApp.Application.Exceptions;
using MyApp.Application.Interfaces;

namespace MyApp.Application.Services
{
    public class ItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public async Task UpdateItemAsync(Guid itemId, ItemUpdateRequest request)
        {
            var item = await _itemRepository.GetByIdAsync(itemId) ??
                throw new NotFoundException("Item");
            if (request.Quantity is null && request.Price is null)
                throw new BadRequestException("At least one of the fields must be provided.");
            if (request.Quantity < 0)
                throw new BadRequestException("Quantity must be greater than or equal to 0.");
            if (request.Price < 0)
                throw new BadRequestException("Price must be greater than or equal to 0.");
            item.Price = request.Price ?? item.Price;
            item.Quantity = request.Quantity ?? item.Quantity;
            item.UpdatedAt = DateTime.UtcNow;
            await _itemRepository.UpdateAsync(item);
            await _itemRepository.SaveChangesAsync();
        }

        public async Task DeleteItemAsync(Guid id)
        {
            var item = await _itemRepository.GetByIdAsync(id) ??
                throw new NotFoundException("Item");
            item.DeletedAt = DateTime.UtcNow;
            await _itemRepository.UpdateAsync(item);
            await _itemRepository.SaveChangesAsync();
        }
    }
}