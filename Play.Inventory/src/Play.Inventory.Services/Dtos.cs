using System;

namespace Play.Inventory.Services.Dtos
{
    public record GrantItemsDto(Guid userId, Guid catalogItemId, int Quantity);

    public record InventoryItemDto(Guid CatalogItemId, string Name, string Description, int Quantity, DateTimeOffset AcquiredDate);

    public record CatalogItemDto(Guid Id, string Name, string Description);

}