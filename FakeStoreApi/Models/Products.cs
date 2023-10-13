using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStoreApi.Models
{
    /// <summary>
    /// Entidad Producto representa un item de venta
    /// </summary>
    internal class Products
    {
        public int id { get; set; }
        public string title { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public List<string> images { get; set; }
        public DateTime creationAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Category category { get; set; }
    }
}
