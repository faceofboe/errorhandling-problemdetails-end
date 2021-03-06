using errorhandling_problemdetails.Repository.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace errorhandling_problemdetails.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllPrpoducts();
        Task<Product> GetProductById(int id);
        Task CreateNewProduct(Product product);
        Task<Product> GetProductByName(string name);
    }
}
