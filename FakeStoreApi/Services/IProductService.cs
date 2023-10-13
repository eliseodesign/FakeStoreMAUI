using FakeStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStoreApi.Services
{
    /// <summary>
    /// Servicio para manejar los productos
    /// </summary>
    internal interface IProductService
    {
        /// <summary>
        /// Este metodo devuelve los productos de la lista de productos
        /// </summary>
        /// <returns>  List Products la lista </returns>
        public Task<List<Products>> GetAllProducts();
    }
}
