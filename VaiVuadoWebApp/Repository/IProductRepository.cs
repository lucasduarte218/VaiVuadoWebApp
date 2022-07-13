using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaiVuadoWebApp.Models;

namespace VaiVuadoWebApp.Repository
{
    public interface IProductRepository
    {
        Product Create(Product product);
        Product Alter(Product product);
        Product Delete(Product product);
    }
}
