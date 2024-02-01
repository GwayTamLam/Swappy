using Swappy.Server.Data;
using Swappy.Server.IRepository;
using Swappy.Server.Models;
using Swappy.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Swappy.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<User> _users;
        //private IGenericRepository<Cart> _carts;
        private IGenericRepository<CartItem> _cartitems;
        private IGenericRepository<Category> _categories;
        //private IGenericRepository<Message> _messages;
        private IGenericRepository<Order> _orders;
        //private IGenericRepository<OrderItem> _orderitems;
       // private IGenericRepository<Payment> _payments;
        private IGenericRepository<Product> _products;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<User> Users
            => _users ??= new GenericRepository<User>(_context);

        //public IGenericRepository<Cart> Carts
        //    => _carts ??= new GenericRepository<Cart>(_context);
        public IGenericRepository<CartItem> CartItems
            => _cartitems ??= new GenericRepository<CartItem>(_context);
        public IGenericRepository<Category> Categories
            => _categories ??= new GenericRepository<Category>(_context);
        //public IGenericRepository<Message> Messages
        //    => _messages ??= new GenericRepository<Message>(_context);
        public IGenericRepository<Order> Orders
            => _orders ??= new GenericRepository<Order>(_context);

        //public IGenericRepository<OrderItem> OrderItems
        //    => _orderitems ??= new GenericRepository<OrderItem>(_context);
        //public IGenericRepository<Payment> Payments
        //    => _payments ??= new GenericRepository<Payment>(_context);
        public IGenericRepository<Product> Products
            => _products ??= new GenericRepository<Product>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}