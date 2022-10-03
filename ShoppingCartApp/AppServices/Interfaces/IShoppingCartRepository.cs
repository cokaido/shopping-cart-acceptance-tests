using ShoppingCartApp.Domain.Entities;
using ShoppingCartApp.Domain.Entities.Base;

namespace ShoppingCartApp.AppServices.Interfaces;

public interface IShoppingCartRepository
{
    public void Create(ShoppingCart cart);
    ShoppingCart Get(Id id);
    void Save(ShoppingCart shoppingCart);
}