using Swappy.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Swappy.Server.IRepository
{
     public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<User> Users { get; }
        IGenericRepository<Cart> Carts { get; }
        IGenericRepository<CartItem> CartItems { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Message> Messages { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<OrderItem> OrderItems { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Product> Products { get; }

    }
}