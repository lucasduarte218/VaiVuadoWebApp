using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaiVuadoWebApp.Models;

namespace VaiVuadoWebApp.Interfaces
{
    interface IProduct
    {
        List<Product> List();
        Product Create(Product product);
        Product Update(Product product);
        Product GetOne(int id);
        Product Delete(int id);
    }
}
